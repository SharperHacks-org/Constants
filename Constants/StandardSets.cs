// Copyright and trademark notices at the end of this file.

using System.Collections.Immutable;

namespace SharperHacks.CoreLibs.Constants;

//using CtrlCodes = AsciiControlCodes;

/// <summary>
/// A collection of immutable hash sets.
/// </summary>
public static partial class StandardSets
{
    #region Private

    private static ImmutableHashSet<char>? _asciiCtrlCodes;

    private static ImmutableHashSet<char>? _upperAlphaCharSet;

    private static ImmutableHashSet<char>? _lowerAlphaCharSet;

    private static ImmutableHashSet<char>? _decimalCharSet;

    private static ImmutableHashSet<char>? _hexCharSet;

    private static ImmutableHashSet<char>? _numericBase64Chars;
    private static ImmutableHashSet<char>? _stdBase64Chars;
    private static ImmutableHashSet<char>? _urlBase64CharSet;

    private static ImmutableHashSet<char>? _whiteSpaceCharSet;

    #endregion Private

    /// <summary>
    /// ASCII control codes. First 32 characters of the ASCII table.
    /// </summary>
    public static ImmutableHashSet<char> AsciiControlCodes => 
        _asciiCtrlCodes ??= [.. ImmutableArrays.AsciiControlCodes];

    /// <summary>
    /// Upper alpha character code points (US-EN)
    /// </summary>
    public static ImmutableHashSet<char> UpperAlphaCharacters =>
        _upperAlphaCharSet ??= [.. ImmutableArrays.UpperAlphaCharacters];

    /// <summary>
    /// Lower alpha character code points (US-EN)
    /// </summary>
    public static ImmutableHashSet<char> LowerAlphaCharacters =>
        _lowerAlphaCharSet ??= [.. ImmutableArrays.LowerAlphaCharacters];

    /// <summary>
    /// Decimal digit code points.
    /// </summary>
    public static ImmutableHashSet<char> DecimalDigits => 
        _decimalCharSet ??= [.. ImmutableArrays.DecimalDigits];

    /// <summary>
    /// Hex digit code points.
    /// </summary>
    public static ImmutableHashSet<char> HexDigits => 
        _hexCharSet ??= [.. ImmutableArrays.HexChars];

    public static ImmutableHashSet<char> NumericBase64Digits =>
        _numericBase64Chars ??= [.. ImmutableArrays.NumericBase64Chars];

    /// <summary>
    /// Standard base 64 code points, as per RFC 4648.
    /// </summary>
    public static ImmutableHashSet<char> StdBase64Digits => 
        _stdBase64Chars ??= [.. ImmutableArrays.StdBase64Chars];

    /// <summary>
    /// URL base 64 code points, as per RFC 4648.
    /// </summary>
    public static ImmutableHashSet<char> UrlBase64Digits => 
        _urlBase64CharSet ??= [.. ImmutableArrays.UrlBase64Chars];

    /// <summary>
    /// Non-printable characters, commonly used for horizontal and vertical 
    /// whitespace/control characters.
    /// </summary>
    public static ImmutableHashSet<char> WhiteSpace => 
        _whiteSpaceCharSet ??= [.. ImmutableArrays.WhiteSpaceChars];
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

