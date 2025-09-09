// Copyright and trademark notices at the end of this file.

namespace SharperHacks.CoreLibs.Constants;

/// <summary>
/// A collection of (mostly ASCII/lower-UTF8) character constants.
/// </summary>
/// <remarks>
/// WIP. Started with bits I needed for another project, and occassionally adding
/// new characters as I need them (plus a few extra as I go).
/// </remarks>
public static partial class Characters
{
    ///
    public const char Comma = ',';

    ///
    public const char Period = '.';

    ///
    public const char Colon = ':';

    ///
    public const char Semicolon = ';';

    ///
    public const char OpenBrace = '{';

    ///
    public const char CloseBrace = '}';

    ///
    public const char OpenBracket = '[';

    ///
    public const char CloseBracket = ']';

    ///
    [Obsolete("Use LeftParens instead.")]
    public const char OpenParen = '(';

    /// <summary>
    /// Left parenthesis (U+0028). AKA: open parenthesis.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Bracket#Parentheses_or_(round)_brackets.
    /// </remarks>
    public const char LeftParens = '(';

    ///
    [Obsolete("Use RightParens instead.")]
    public const char CloseParen = ')';

    /// <summary>
    /// Right parenthesis (U+0029). AKA: right parenthesis.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Bracket#Parentheses_or_(round)_brackets.
    /// </remarks>
    public const char RightParens = ')';

    /// <summary>
    /// Hyphen-minus (U+002D). Symbol used for the kyeboard minus sign.
    /// </summary>
    /// <remarks>
    /// See:
    ///  - https://en.wikipedia.org/wiki/Hyphen#Hyphen-minuses
    ///  - https://en.wikipedia.org/wiki/Plus_and_minus_signs#Minus_sign.
    /// </remarks>
    public const char HyphenMinus = '-';

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
    /// Asperand (U+0026), AKA "at symbol".
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
    /// Percent sign (U+2052). Parts per hundred.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Percent_sign.
    /// </remarks>
    public const char Percent = '%';

    /// <summary>
    /// Circumflex or circumflex accent, also used in mathmatics for exponentiation.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Caret.
    /// </remarks>
    public const char CircumflexAccent = '^';

    /// <inheritdoc cref="CircumflexAccent"/>
    public const char Circumflex = CircumflexAccent;

    /// <summary>
    /// Ampersand symbol (U+0026), AKA "and" symbol.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Ampersand.
    /// </remarks>
    public const char Ampersand = '&';

    /// <summary>
    ///  Asterisk (U+002A). AKA: star in mathematics.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Asterisk.
    /// </remarks>
    public const char Asterisk = '*';

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
