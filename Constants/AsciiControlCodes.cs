// Copyright and trademark notices at the end of this file.


namespace SharperHacks.CoreLibs.Constants;

/// <summary>
/// ASCII control codes. First 31 symbols of the ASCII table.
/// <remarks>
/// Ripped from https://www.asciitable.com/
/// </remarks>
/// </summary>
public static class AsciiControlCodes
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public const char NUL = '\u0000';
    public const char SOH = '\u0001';
    public const char STX = '\u0002';
    public const char ETX = '\u0003';
    public const char EOT = '\u0004';
    public const char ENQ = '\u0005';
    public const char ACK = '\u0006';
    public const char BEL = '\u0007';
    public const char BS  = '\u0008';
    public const char TAB = '\u0009';
    public const char LF  = '\u000A'; // 10
    public const char VT  = '\u000B'; // 11
    public const char FF  = '\u000C'; // 12
    public const char CR  = '\u000D'; // 13
    public const char SO  = '\u000E'; // 14
    public const char SI  = '\u000F'; // 15
    public const char DLE = '\u0010'; // 16
    public const char DC1 = '\u0011'; // 17
    public const char DC2 = '\u0012'; // 18
    public const char DC3 = '\u0013'; // 19
    public const char DC4 = '\u0014'; // 20
    public const char NAK = '\u0015'; // 21
    public const char SYN = '\u0016'; // 22
    public const char ETB = '\u0017'; // 23
    public const char CAN = '\u0018'; // 24
    public const char EM  = '\u0019'; // 25
    public const char SUB = '\u001A'; // 26
    public const char ESC = '\u001B'; // 27
    public const char FS  = '\u001C'; // 28
    public const char GS  = '\u001D'; // 29
    public const char RS  = '\u001E'; // 30
    public const char US  = '\u001F'; // 31
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// Get an array, filled with the control codes.
    /// </summary>
    public static char[] AsArray
    {
        get
        {
            return [
                NUL,
                SOH,
                STX,
                ETX,
                EOT,
                ENQ,
                ACK,
                BEL,
                BS,
                TAB,
                LF,
                VT,
                FF,
                CR,
                SO,
                SI,
                DLE,
                DC1,
                DC2,
                DC3,
                DC4,
                NAK,
                SYN,
                ETB,
                CAN,
                EM,
                SUB,
                ESC,
                FS,
                GS,
                RS,
                US
                ];
        }
    }
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
