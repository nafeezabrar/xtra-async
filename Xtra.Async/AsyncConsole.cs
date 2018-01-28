using System;
using System.Threading.Tasks;

namespace Xtra.Async
{
    public static class AsyncConsole
    {
        /// <summary>Asynchronously clears all buffers for the current writer and causes any buffered data to be written to the underlying device.</summary>
        /// <returns>A task that represents the asynchronous flush operation.</returns>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The writer is currently in use by a previous write operation.</exception>
        public static Task FlushAsync()
        {
            return Console.Out.FlushAsync();
        }

        /// <summary>Writes a character to the text string or stream asynchronously.</summary>
        /// <param name="value">The character to write to the text stream.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteAsync(char value)
        {
            return Console.Out.WriteAsync(value);
        }

        /// <summary>Writes a character array to the text string or stream asynchronously.</summary>
        /// <param name="buffer">The character array to write to the text stream. If buffer is null, nothing is written.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteAsync(char[] buffer)
        {
            return Console.Out.WriteAsync(buffer);
        }

        /// <summary>Writes a subarray of characters to the text string or stream asynchronously.</summary>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The character position in the buffer at which to start retrieving data.</param>
        /// <param name="count">The number of characters to write.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentException">The <paramref name="index">index</paramref> plus <paramref name="count">count</paramref> is greater than the buffer length.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index">index</paramref> or <paramref name="count">count</paramref> is negative.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteAsync(char[] buffer, int index, int count)
        {
            return Console.Out.WriteAsync(buffer, index, count);
        }

        /// <summary>Writes a string to the text string or stream asynchronously.</summary>
        /// <param name="value">The string to write. If value is null, nothing is written to the text stream.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteAsync(string value)
        {
            return Console.Out.WriteAsync(value);
        }

        /// <summary>Writes a line terminator asynchronously to the text string or stream.</summary>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteLineAsync()
        {
            return Console.Out.WriteLineAsync();
        }

        /// <summary>Writes a character followed by a line terminator asynchronously to the text string or stream.</summary>
        /// <param name="value">The character to write to the text stream.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteLineAsync(char value)
        {
            return Console.Out.WriteLineAsync(value);
        }

        /// <summary>Writes an array of characters followed by a line terminator asynchronously to the text string or stream.</summary>
        /// <param name="buffer">The character array to write to the text stream. If the character array is null, only the line terminator is written.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteLineAsync(char[] buffer)
        {
            return Console.Out.WriteLineAsync(buffer);
        }

        /// <summary>Writes a subarray of characters followed by a line terminator asynchronously to the text string or stream.</summary>
        /// <param name="buffer">The character array to write data from.</param>
        /// <param name="index">The character position in the buffer at which to start retrieving data.</param>
        /// <param name="count">The number of characters to write.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="buffer">buffer</paramref> is null.</exception>
        /// <exception cref="T:System.ArgumentException">The <paramref name="index">index</paramref> plus <paramref name="count">count</paramref> is greater than the buffer length.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index">index</paramref> or <paramref name="count">count</paramref> is negative.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteLineAsync(char[] buffer, int index, int count)
        {
            return Console.Out.WriteLineAsync(buffer, index, count);
        }

        /// <summary>Writes a string followed by a line terminator asynchronously to the text string or stream.</summary>
        /// <param name="value">The string to write. If the value is null, only a line terminator is written.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        /// <exception cref="T:System.ObjectDisposedException">The text writer is disposed.</exception>
        /// <exception cref="T:System.InvalidOperationException">The text writer is currently in use by a previous write operation.</exception>
        public static Task WriteLineAsync(string value)
        {
            return Console.Out.WriteLineAsync(value);
        }
    }
}