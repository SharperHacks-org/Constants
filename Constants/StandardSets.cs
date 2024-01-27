// Copyright and trademark notices at the end of this file.

using System.Collections.Immutable;

namespace SharperHacks.CoreLibs.Constants;

/// <summary>
/// A collection of immutable sets.
/// </summary>
public static class StandardSets
{
    #region Private

    private static readonly char[] _upperAlphaChars = new []
    {
        'A',
        'B',
        'C',
        'D',
        'E',
        'F',
        'G',
        'H',
        'I',
        'J',
        'K',
        'L',
        'M',
        'N',
        'O',
        'P',
        'Q',
        'R',
        'S',
        'T',
        'U',
        'V',
        'W',
        'X',
        'Y',
        'Z'
    };
    private static ImmutableHashSet<char>? _upperAlphaCharSet;

    private static readonly char[] _lowerAlphaChars = new []
    {
        'a',
        'b',
        'c',
        'd',
        'e',
        'f',
        'g',
        'h',
        'i',
        'j',
        'k',
        'l',
        'm',
        'n',
        'o',
        'p',
        'q',
        'r',
        's',
        't',
        'u',
        'v',
        'w',
        'x',
        'y',
        'z'
    };
    private static ImmutableHashSet<char>? _lowerAlphaCharSet;

    private static readonly char[] _decimalChars = new[]
    {
        '0',
        '1',
        '2',
        '3',
        '4',
        '5',
        '6',
        '7',
        '8',
        '9'
    };
    private static ImmutableHashSet<char>? _decimalCharSet;

    private static readonly char[] _hexChars = new[]
    {
        '0',
        '1',
        '2',
        '3',
        '4',
        '5',
        '6',
        '7',
        '8',
        '9',
        'A',
        'a',
        'B',
        'b',
        'C',
        'c',
        'D',
        'd',
        'E',
        'e',
        'F',
        'f'
    };
    private static ImmutableHashSet<char>? _hexCharSet;

    #endregion

    /// <summary>
    /// Upper alpha character code points (US-EN)
    /// </summary>
    public static ImmutableHashSet<char> UpperAlphaCharacters => _upperAlphaCharSet ??= _upperAlphaChars.ToImmutableHashSet();

    /// <summary>
    /// Lower alpha character code points (US-EN)
    /// </summary>
    public static ImmutableHashSet<char> LowerAlphaCharacters => _lowerAlphaCharSet ??= _lowerAlphaChars.ToImmutableHashSet();

    /// <summary>
    /// Decimal digit code points.
    /// </summary>
    public static ImmutableHashSet<char> DecimalDigits => _decimalCharSet ??= _decimalChars.ToImmutableHashSet();

    /// <summary>
    /// Hex digit code points.
    /// </summary>
    public static ImmutableHashSet<char> HexDigits => _hexCharSet ??= _hexChars.ToImmutableHashSet();
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

