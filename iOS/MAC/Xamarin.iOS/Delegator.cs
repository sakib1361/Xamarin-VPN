using Foundation;
using IOSVpnAdapter;
using NetworkExtension;
using System;

namespace NetworkHandler
{
    public class Delegator : OpenVPNAdapterDelegate
    {
        private readonly PacketTunnelProvider _provider;
        private readonly ConfigHandler _configHandler;
        private OpenVPNAdapter _adapter;
        public Delegator(PacketTunnelProvider provider, ConfigHandler configHandler)
        {
            _provider = provider;
            _configHandler = configHandler;
        }

        public override async void OpenVPNAdapter(OpenVPNAdapter openVPNAdapter, NEPacketTunnelNetworkSettings networkSettings, Action<OpenVPNAdapterPacketFlow> completionHandler)
        {
            _adapter = openVPNAdapter;
            if (networkSettings != null && networkSettings.DnsSettings != null)
            {
                networkSettings.DnsSettings.MatchDomains = new string[] { };
            }
            Console.WriteLine("Delegator Applying Config");
            await _provider.SetTunnelNetworkSettingsAsync(networkSettings);
            try
            {
                //_adapter.CreatePacketFlow(_provider.PacketFlow, completionHandler);
                var _custom = new CustomPacketFlow(_provider.PacketFlow);
                completionHandler(_custom);
                Console.WriteLine("Configuration Applied");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void OpenVPNAdapter(OpenVPNAdapter openVPNAdapter, NSError error)
        {
            _adapter = openVPNAdapter;
            Console.WriteLine("Delegator Error " + error.LocalizedDescription +
                error.Description + error.LocalizedRecoverySuggestion);
        }

        public override void OpenVPNAdapter(OpenVPNAdapter openVPNAdapter, OpenVPNAdapterEvent @event, string message)
        {
            _adapter = openVPNAdapter;
            var vpnEvent = @event.ToString();
            switch (vpnEvent)
            {
                case "Connected":
                    _provider.StartHandler();
                    break;
                case "Disconnected":
                    _provider.StopHandler();
                    break;

            }
            Console.WriteLine("DelegatorMessage " + vpnEvent + " " + message);
        }

        public override void OpenVPNAdapter(OpenVPNAdapter openVPNAdapter, string logMessage)
        {
            //base.OpenVPNAdapter(openVPNAdapter, logMessage);
            Console.WriteLine("LogMessage " + logMessage);
        }

        public override void OpenVPNAdapterDidReceiveClockTick(OpenVPNAdapter openVPNAdapter)
        {
            var t = openVPNAdapter.TransportStatistics;
            if (t != null)
            {
                _configHandler.Update(t.BytesIn, t.BytesOut);
            }
        }
    }

    public class CustomPacketFlow : OpenVPNAdapterPacketFlow
    {
        private readonly NEPacketTunnelFlow _flow;

        public CustomPacketFlow(NEPacketTunnelFlow flow)
        {
            _flow = flow;
        }
        public override async void ReadPacketsWithCompletionHandler(Action<NSArray<NSData>, NSArray<NSNumber>> completionHandler)
        {
            var data = await _flow.ReadPacketsAsync();
            var nData = NSArray<NSData>.FromNSObjects(data.Packets);
            var pData = NSArray<NSNumber>.FromNSObjects(data.Protocols);
            completionHandler(nData, pData);

            nData.Dispose();
            pData.Dispose();
        }

        public override bool WritePackets(NSData[] packets, NSNumber[] protocols)
        {
            return _flow.WritePackets(packets, protocols);
        }
    }
}