using netpforgery.CoreStructures;
using System.Runtime.InteropServices;

namespace netpforgery.Packets
{
    [StructLayout(LayoutKind.Sequential, Size = 14, Pack = 2)]
    public struct Ethernet
    {
        public Ethernet(ushort type, MacAddress target, MacAddress source)
        {
            Type = type;
            TargetAddress = target;
            SourceAddress = source;
        }

        public MacAddress TargetAddress;
        public MacAddress SourceAddress;
        public ushort Type;
    }
}
