using System.Runtime.InteropServices;

namespace netpforgery
{
    public static class BinaryConverter
    {
        public static byte[] GetBytes<T>(T obj) where T : struct
        {
            int size = Marshal.SizeOf(obj);
            IntPtr p = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(obj, p, false);

            byte[] buffer = new byte[size];
            Marshal.Copy(p, buffer, 0, size);
            Marshal.FreeHGlobal(p);
            return buffer;
        }
        public static byte[] ToByteArray(string[] strings, int nBase = 10)
        {
            int size = strings.Length;

            byte[] bytes = new byte[size];
            for (int i = 0; i < size; i++)
            {
                bytes[i] = Convert.ToByte(strings[i], nBase);
            }
            return bytes;
        }
    }
}
