using System.IO;
using System.Threading.Tasks;

namespace Xtra.Async
{
    public static class StreamExtension
    {
        public static async Task<int> ReadByteAsync(this Stream stream)
        {
            var buffer = new byte[1];
            if (await stream.ReadAsync(buffer, 0, 1) == 0)
                return -1;
            return buffer[0];
        }

        public static Task WriteByteAsync(this Stream stream, byte value)
        {
            return stream.WriteAsync(new[] {value}, 0, 1);
        }
    }
}