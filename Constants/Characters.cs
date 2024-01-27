// Copyright and trademark notices at the end of this file.

namespace SharperHacks.CoreLibs.Constants;

/// <summary>
/// A collection of character constants.
/// </summary>
public static class Characters
{
    // ToDo: Fill in all non-alphanumeric characters in the lower 256 code point range.

    ///
    public const char Comma = ',';

    ///
    public const char Period = '.';

    ///
    public const char OpenBrace = '{';

    ///
    public const char CloseBrace = '}';

    ///
    public const char OpenBracket = '[';

    ///
    public const char CloseBracket = ']';

    ///
    public const char OpenParen = '(';

    ///
    public const char CloseParen = ')';

    ///
    public const char Hyphen = '-';

    ///
    public const char Space = ' ';

    /// <summary>
    /// Exclamation point|mark (U+0021).
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Exclamation_mark.
    /// </remarks>
    public const char Exclamation = '!';

    /// <summary>
    /// Asperand, AKA "at symbol".
    /// </summary>
    [Obsolete($"Use 'Characters.At' instead. This will be removed in the next major release.")]
    public const char Asperand = '@';

    /// <summary>
    /// At symbol (U+0040), AKA; arobase, arroba, ampersat or asperand.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/At_sign.
    /// </remarks>
    public const char At = '@';

    /// <summary>
    /// Hash character AKA Number Sign (U+0023).
    /// </summary>
    /// <remarks>
    /// The name "Hash" was chosen here for compactness and to reflect modern
    /// usage. It is not a "hashtag". See https://en.wikipedia.org/wiki/Number_sign.
    /// </remarks>
    public const char Hash = '#';

    /// <summary>
    /// Dollar sign (U+0024), AKA; peso sign.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Dollar_sign.
    /// </remarks>
    public const char DollarSign = '$';

    /// <summary>
    /// Ampersand symbol (U+0026), AKA "and" symbol.
    /// </summary>
    public const char Ampersand = '&';

    //////////////////////////////////////////////////////////
    // These do not map to ASCII or extended ASCII.

    /// <summary>
    /// Sharp character (U+266F).
    /// </summary>
    /// <remarks>
    /// DO NOT CONFUSE WITH HASH (#) SYMBOL! Not in the lower 127 ASCII/Unicode set.
    /// </remarks>
    public const char Sharp = '♯';
}

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
