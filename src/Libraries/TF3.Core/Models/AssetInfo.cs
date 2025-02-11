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

namespace TF3.Common.Core.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Game asset info.
    /// </summary>
    public class AssetInfo
    {
        /// <summary>
        /// Gets or sets the asset id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the list of output names.
        /// </summary>
        public List<string> OutputNames { get; set; }

        /// <summary>
        /// Gets or sets the list of files in this asset.
        /// </summary>
        public List<FileInfo> Files { get; set; }

        /// <summary>
        /// Gets or sets the list of converters needed to merge the asset files into a single format.
        /// </summary>
        public List<ConverterInfo> Mergers { get; set; }

        /// <summary>
        /// Gets or sets the list of converters needed to extract the translatable contents.
        /// </summary>
        public List<ConverterInfo> Extractors { get; set; }

        /// <summary>
        /// Gets or sets the list of converters needed to merge the translation files into a single node format.
        /// </summary>
        public List<ConverterInfo> TranslationMergers { get; set; }

        /// <summary>
        /// Gets or sets the name of the translator converter.
        /// </summary>
        public string Translator { get; set; }

        /// <summary>
        /// Gets or sets the list of converters needed to split the asset format into files.
        /// </summary>
        public List<ConverterInfo> Splitters { get; set; }
    }
}
