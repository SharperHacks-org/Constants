// Copyright Joseph W Donahue and Sharper Hacks LLC (US-WA)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SharperHacks is a trademark of Sharper Hacks LLC (US-Wa), and may not be
// applied to distributions of derivative works, without the express written
// permission of a registered officer of Sharper Hacks LLC (US-WA).

using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace SharperHacks.CoreLibs.Constants;

/// <summary>
/// Provides predefined serializer options.
/// </summary>
public static class SerializerOptions
{
    /// <summary>
    /// Provides serailizers for compact and pretty printed Json.
    /// </summary>
    public static class Json
    {
        private static TextEncoderSettings? _encoderSettings;
        private static JsonSerializerOptions? _prettyPrintSerializer;
        private static JsonSerializerOptions? _compactSerializer;

        /// <summary>
        /// Creates or returns JsonSerializerOptions and TextEncoderSettings configured for pretty Json.
        /// </summary>
        public static JsonSerializerOptions PrettyPrint => _prettyPrintSerializer ??= new JsonSerializerOptions()
        {
            Encoder = JavaScriptEncoder.Create(_encoderSettings ??= new TextEncoderSettings(UnicodeRanges.All)),

            WriteIndented = true,
        };

        /// <summary>
        /// Creates or returns JsonSerializerOptions and TextEncoderSettings configured for compact Json.
        /// </summary>
        public static JsonSerializerOptions Compact => _compactSerializer ??= new JsonSerializerOptions()
        {
            Encoder = JavaScriptEncoder.Create(_encoderSettings ??= new TextEncoderSettings(UnicodeRanges.All)),

            WriteIndented = false,
        };
    }
}
