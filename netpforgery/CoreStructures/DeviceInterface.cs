using System.Runtime.InteropServices;

namespace netpforgery.CoreStructures
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DeviceInterface
    {
        public IntPtr Next;
        [MarshalAs(UnmanagedType.LPStr)]
        public string Name;
        [MarshalAs(UnmanagedType.LPStr)]
        public string Description;
    }
}
