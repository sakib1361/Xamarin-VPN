using Foundation;
using IOSVpnAdapter;
using NetworkExtension;
using System;

namespace NetworkHandler
{
    [Register("PacketTunnelProvider")]
    public class PacketTunnelProvider : NEPacketTunnelProvider
    {
        private readonly OpenVPNAdapter vpnAdapter;
        private readonly OpenVPNReachability vpnReachability;
        private readonly ConfigHandler configHandler;
        Action<NSError> _connectedHandler;
        private Action _stopHandler;

        public PacketTunnelProvider()
        {
            Console.WriteLine("VpnCreate");
            vpnAdapter = new OpenVPNAdapter();
            vpnReachability = new OpenVPNReachability();
            configHandler = new ConfigHandler(this);
            vpnAdapter.Delegate = new Delegator(this, configHandler);
        }

        public override void StartTunnel(NSDictionary<NSString, NSObject> options, Action<NSError> completionHandler)
        {
            Console.WriteLine("Vpn Start tunnel");
            try
            {
                var data = options["Profile"].ToString();
                Console.WriteLine("Config:-" + data);
                var config = new OpenVPNConfiguration
                {
                    FileContent = NSData.FromString(data),
                    TunPersist = true,
                    ClockTick = 5000
                };

                var pr = vpnAdapter.ApplyConfiguration(config, out NSError nSError);
                if (nSError == null)
                {
                    var credentials = new OpenVPNCredentials
                    {
                        Username = options["Username"].ToString(),
                        Password = options["Password"].ToString()
                    };
                    vpnAdapter.ProvideCredentials(credentials, out NSError error);
                    vpnReachability.StartTrackingWithCallback(TrackVPN);
                    vpnAdapter.Connect();
                    _connectedHandler = completionHandler;
                }
                else
                {
                    Console.WriteLine("Start Error" + nSError.LocalizedDescription);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Start Exception" + ex.ToString());
            }
        }

        internal void StartHandler()
        {
            if (_connectedHandler == null)
                return;
            else
            {
                _connectedHandler.Invoke(null);
                _connectedHandler = null;
                Console.WriteLine("Start Sequence Complete");
            }
            configHandler.Start();
        }

        internal void StopHandler()
        {
            if (vpnReachability.Tracking)
                vpnReachability.StopTracking();
            _stopHandler?.Invoke();

        }

        public override void StopTunnel(NEProviderStopReason reason, Action completionHandler)
        {
            _stopHandler = completionHandler;
            if (vpnReachability.Tracking)
                vpnReachability.StopTracking();

            vpnAdapter.Disconnect();
            configHandler.Stop();
        }

        private void TrackVPN(OpenVPNReachabilityStatus obj)
        {
            Console.WriteLine("Track " + obj.ToString());
            if (obj == OpenVPNReachabilityStatus.NotReachable)
                vpnAdapter.ReconnectAfterTimeInterval(5);
        }
    }
}