using Foundation;
using System;

namespace NetworkHandler
{
    public class ConfigHandler
    {
        public ConfigHandler(PacketTunnelProvider provider)
        {
        }

        internal void Update(nint bytesIn, nint bytesOut)
        {
            Debug.Writeline("Speed Update");
        }

        internal void Stop()
        {
            Debug.Writeline("Stop");
        }

        internal void Start()
        {
            Debug.Writeline("Start");
        }
    }
}