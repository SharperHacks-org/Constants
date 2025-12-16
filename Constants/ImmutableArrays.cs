// Copyright and trademark notices at the end of this file.


using System.Collections.Immutable;

namespace SharperHacks.CoreLibs.Constants;

using CtrlCodes = AsciiControlCodes;

// Collection of immutable arrays of useful ordered values.
//
public class ImmutableArrays
{
    private static readonly char[] _controlCodes =
        [
                CtrlCodes.NUL,
                CtrlCodes.SOH,
                CtrlCodes.STX,
                CtrlCodes.ETX,
                CtrlCodes.EOT,
                CtrlCodes.ENQ,
                CtrlCodes.ACK,
                CtrlCodes.BEL,
                CtrlCodes.BS,
                CtrlCodes.TAB,
                CtrlCodes.LF,
                CtrlCodes.VT,
                CtrlCodes.FF,
                CtrlCodes.CR,
                CtrlCodes.SO,
                CtrlCodes.SI,
                CtrlCodes.DLE,
                CtrlCodes.DC1,
                CtrlCodes.DC2,
                CtrlCodes.DC3,
                CtrlCodes.DC4,
                CtrlCodes.NAK,
                CtrlCodes.SYN,
                CtrlCodes.ETB,
                CtrlCodes.CAN,
                CtrlCodes.EM,
                CtrlCodes.SUB,
                CtrlCodes.ESC,
                CtrlCodes.FS,
                CtrlCodes.GS,
                CtrlCodes.RS,
                CtrlCodes.US
        ];
    private static ImmutableArray<char>? _immutableControlCodes;

    private static readonly char[] _upperAlphaChars =
    [
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
    ];
    private static ImmutableArray<char>? _immutableUpperAlphaChars;

    private static readonly char[] _lowerAlphaChars =
    [
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
    ];
    private static ImmutableArray<char>? _immutableLowerAlphaChars;

    private static readonly char[] _decimalChars =
    [
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
    ];
    private static ImmutableArray<char>? _immutableDecimalChars;

    private static readonly char[] _hexChars =
    [
        '0', // U+0030
        '1', // U+0031
        '2', // U+0032
        '3', // U+0033
        '4', // U+0034
        '5', // U+0035
        '6', // U+0036
        '7', // U+0037
        '8', // U+0038
        '9', // U+0039
        'A', // U+0041
        'a', // U+0061
        'B', // U+0042
        'b', // U+0062
        'C', // U+0043
        'c', // U+0063
        'D', // U+0044
        'd', // U+0064
        'E', // U+0045
        'e', // U+0065
        'F', // U+0046
        'f'  // U+0066
    ];
    private static ImmutableArray<char>? _immutableHexChars;

    // Non-standard.
    private static readonly char[] _numericBase64Chars =
    [
        '0', // 0
        '1',
        '2',
        '3',
        '4',
        '5',
        '6',
        '7',
        '8',
        '9', // 9
        'A', // 10
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
        'Z', // 35
        'a', // 36
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
        'z', // 61
        '+', // 62
        '/', // 63
        '=', // Pad
    ];
    private static ImmutableArray<char>? _immutableNumericBase64Chars;

    // RFC 4648
    private static readonly char[] _stdBase64Chars =
    [
        'A', // 0
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
        'Z', // 25
        'a', // 26
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
        'z', // 51
        '0', // 52
        '1',
        '2',
        '3',
        '4',
        '5',
        '6',
        '7',
        '8',
        '9', // 61
        '+', // 62
        '/', // 63
        '=', // Pad
    ];
    private static ImmutableArray<char>? _immutableStdBase64Chars;

    // RFC 4648
    private static readonly char[] _urlBase64Chars =
    [
        'A', // 0
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
        'Z', // 25
        'a', // 26
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
        'z', // 51
        '0', // 52
        '1',
        '2',
        '3',
        '4',
        '5',
        '6',
        '7',
        '8',
        '9', // 61
        '-', // 62
        '_', // 63
        '=', // Pad
    ];
    private static ImmutableArray<char>? _immutableUrlBase64Chars;

    // ToDo: Are there other characters that should be part of this set?
    private static readonly char[] _whiteSpace =
    [
        Characters.Space,   // ' '
        CtrlCodes.LF,       // '\n',
        CtrlCodes.CR,       // '\r',
        CtrlCodes.TAB,      // '\t',
    ];
    private static ImmutableArray<char>? _immutableWhiteSpaceChars;

    public static ImmutableArray<char> AsciiControlCodes =>
        _immutableControlCodes ??= ImmutableArray.Create(_controlCodes);

    // Lower alpha character code points (US-EN)
    public static ImmutableArray<char> LowerAlphaCharacters =>
        _immutableLowerAlphaChars ??= ImmutableArray.Create(_lowerAlphaChars);

    // Upper alpha character code points (US-EN)
    public static ImmutableArray<char> UpperAlphaCharacters =>
        _immutableUpperAlphaChars ??= ImmutableArray.Create(_upperAlphaChars);

    // Decimal characters.
    //
    public static ImmutableArray<char> DecimalDigits =>
        _immutableDecimalChars ??= ImmutableArray.Create(_decimalChars);

    // Hexidecimal characters.
    //
    public static ImmutableArray<char> HexChars =>
        _immutableHexChars ??= ImmutableArray.Create(_hexChars);

    // Numeric base 64 code points, as if base 64 followed the pattern set for
    // octal and hex.
    //
    // Not a common standard.
    //
    public static ImmutableArray<char> NumericBase64Chars =>
        _immutableNumericBase64Chars ??= ImmutableArray.Create(_numericBase64Chars);

    // Standard base 64 code points, as per RFC 4648 ordering.
    //
    // Usefull for encoding arrays of data via lookup.
    //
    public static ImmutableArray<char> StdBase64Chars =>
        _immutableStdBase64Chars ??= ImmutableArray.Create(_stdBase64Chars);

    // URL base 64 code points, as per RFC 4648 ordering.
    //
    // Usefull for encoding arrays of data via lookup.
    //
    public static ImmutableArray<char> UrlBase64Chars => 
        _immutableUrlBase64Chars ??= ImmutableArray.Create(_urlBase64Chars);

    // Non-printable characters, commonly used for horizontal and vertical
    // whitespace/control characters.
    //
    public static ImmutableArray<char> WhiteSpaceChars =>
        _immutableWhiteSpaceChars ??= ImmutableArray.Create(_whiteSpace);

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
