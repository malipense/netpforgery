using System;

namespace netpforgery.Packets
{
    public struct Loopback
    {
        public Loopback(uint family)
        {
            Family = family;
        }
        public uint Family;
    }
}
