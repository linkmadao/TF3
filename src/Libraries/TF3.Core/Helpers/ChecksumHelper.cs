// Copyright (c) 2021 Kaplas
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace TF3.Common.Core.Helpers
{
    using System.IO;
    using Standart.Hash.xxHash;

    /// <summary>
    /// Checksum functions.
    /// </summary>
    public static class ChecksumHelper
    {
        /// <summary>
        /// Calculate the checksum of a file.
        /// </summary>
        /// <param name="file">The input file.</param>
        /// <returns>The checksum value.</returns>
        public static ulong Calculate(string file)
        {
            return Calculate(new FileStream(file, FileMode.Open, FileAccess.Read));
        }

        /// <summary>
        /// Calculate the checksum of a stream.
        /// </summary>
        /// <param name="stream">The input stream.</param>
        /// <returns>The checksum value.</returns>
        public static ulong Calculate(Stream stream)
        {
            return xxHash64.ComputeHash(stream);
        }

        /// <summary>
        /// Validates the checksum of a file.
        /// </summary>
        /// <param name="file">The input file.</param>
        /// <param name="expected">The expected checksum value.</param>
        /// <returns>True if checksum matches with the expected value.</returns>
        public static bool Check(string file, ulong expected)
        {
            if (expected == 0)
            {
                return true;
            }

            ulong value = Calculate(file);
            return value == expected;
        }

        /// <summary>
        /// Validates the checksum of a stream.
        /// </summary>
        /// <param name="stream">The input stream.</param>
        /// <param name="expected">The expected checksum value.</param>
        /// <returns>True if checksum matches with the expected value.</returns>
        public static bool Check(Stream stream, ulong expected)
        {
            if (expected == 0)
            {
                return true;
            }

            ulong value = Calculate(stream);
            return value == expected;
        }
    }
}
