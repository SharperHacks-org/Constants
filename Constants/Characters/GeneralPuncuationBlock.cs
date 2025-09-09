// Copyright and trademark notices at the end of this file.

using System.Runtime.CompilerServices;

using static System.Net.WebRequestMethods;

namespace SharperHacks.CoreLibs.Constants;

/// <summary>
/// See https://en.wikipedia.org/wiki/General_Punctuation
/// </summary>
public static partial class Characters
{
    /// <summary>
    /// Width of one en. U+2002 is canonically equivalent to this character; U+2002 is preferred.
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#NQSP
    /// </remarks>
    /// </summary>
    public const char EnQuad = '\u2000';

    /// <summary>
    /// Also known as "mutton quad". Width of one em. U+2003 is canonically equivalent to this 
    /// character; U+2003 is preferred.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#MQSP
    /// </remarks>
    public const char EmQuad = '\u2001';

    /// <summary>
    /// Also known as "nut". Width of one en. U+2000 En Quad is canonically equivalent to this 
    /// character; U+2002 is preferred. HTML/XML named entity: &amp;ensp;, LaTeX: \enspace(the LaTeX 
    /// en space is a no-break space)
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#ENSP
    /// </remarks>
    public const char EnSpace = '\u2002';

    /// <summary>
    /// Also known as "mutton". Width of one em. U+2001 Em Quad is canonically equivalent to this 
    /// character; U+2003 is preferred. HTML/XML named entity: &amp;emsp;, LaTeX: \quad
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#EMSP
    /// </remarks>
    public const char EmSpace = '\u2003';

    /// <summary>
    /// Also known as "thick space". One third of an em wide. HTML/XML named entity: &amp;emsp13;, 
    /// LaTeX: \; (the LaTeX thick space is a no-break space)
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#THPMSP
    /// </remarks>
    public const char ThreePerEmSpace = '\u2004';

    /// <summary>
    /// Also known as "mid space". One fourth of an em wide. HTML/XML named entity: &amp;emsp14;
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#FPMSP
    /// </remarks>
    public const char FourPerEmSpace = '\u2005';

    /// <summary>
    /// One sixth of an em wide. In computer typography, sometimes equated to U+2009.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#SPMSP
    /// </remarks>
    public const char SixPerEmSpace = '\u2006';

    /// <summary>
    /// Figure space. In fonts with monospaced digits, equal to the width of one digit.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Figure_space
    /// </remarks>
    public const char FigureSpace = '\u2007';

    /// <summary>
    /// As wide as the narrow punctuation in a font, i.e. the advance width of the period or comma.
    /// HTML/XML named entity: &amp;puncsp;
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#PSP
    /// </remarks>
    public const char PuncuationSpace = '\u2008';

    /// <summary>
    /// Recommended for use as a thousands separator for measures made with SI units. Unlike U+2002 
    /// to U+2008, its width may get adjusted in typesetting. HTML/XML named entity: &amp;thinsp;, 
    /// &amp;ThinSpace;, LaTeX: \, (the LaTeX thin space is a no-break space).
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Thin_space
    /// </remarks>
    public const char ThinSpace = '\u2009';

    /// <summary>
    /// Thinner than a thin space. HTML/XML named entity: &amp;hairsp;, &amp;VeryThinSpace;
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#HSP
    /// </remarks>
    public const char HairSpace = '\u200A';

    /// <summary>
    /// ZWSP, zero-width space. Used to indicate word boundaries to text processing systems when 
    /// using scripts that do not use explicit spacing. It is similar to the soft hyphen, with the 
    /// difference that the latter is used to indicate syllable boundaries, and should display a
    /// visible hyphen when the line breaks at it. HTML/XML named entity: &amp;ZeroWidthSpace;
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#ZWSP
    /// </remarks>
    public const char ZeroWidthSpace = '\u200B';

    /// <summary>
    /// ZWNJ, zero-width non-joiner. When placed between two characters that would otherwise be 
    /// connected, a ZWNJ causes them to be printed in their final and initial forms, respectively.
    /// HTML/XML named entity: &amp;zwnj;
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#ZWNJ
    /// </remarks>
    public const char ZeroWidthNonJoiner = '\u200C';

    /// <summary>
    /// ZWJ, zero-width joiner. When placed between two characters that would otherwise not be connected, 
    /// a ZWJ causes them to be printed in their connected forms. Can also be used to display joining 
    /// forms in isolation. Depending on whether a ligature or conjunct is expected by default, can either
    /// induce (as in emoji and in Sinhala) or suppress (as in Devanagari) substitution with a single glyph,
    /// whilst still permitting use of individual joining forms (unlike ZWNJ). HTML/XML named entity: &amp;zwj;
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Whitespace_character#ZWJ
    /// </remarks>
    public const char ZeroWidthJoiner = '\u200D';

    /// <summary>
    /// LRM, left-to-right mark (&amp;lrm).
    /// </summary>
    /// <remarks>
    /// https://en.wikipedia.org/wiki/Implicit_directional_marks#Unicode
    /// </remarks>
    public const char LeftToRightMark = '\u200E';

    /// <summary>
    /// RLM, right-to-left mark (&amp;rlm).
    /// </summary>
    /// <remarks>
    /// https://en.wikipedia.org/wiki/Implicit_directional_marks#Unicode
    /// </remarks>
    public const char RightToLeftMark = '\u200F';

    /// <summary>
    /// Punctuation mark used to join words and to separate syllables of a single word.
    /// Not to be confused with Hyphen-Minus. This code is seldom used.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Hyphen#Hyphen-minuses
    /// </remarks>
    public const char Hyphen = '\u2010';

    /// <summary>
    /// Non-breaking hypehn.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Hyphen#Nonbreaking_hyphens
    /// </remarks>
    public const char NonBreakingHypen = '\u2011';

    /// <summary>
    /// The figure dash ‒ (U+2012 ‒ FIGURE DASH) has the same width as a numerical digit 
    /// (many computer fonts have digits of equal width[9]). It is used within numbers, such 
    /// as the phone number 555‒0199, especially in columns so as to maintain alignment.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Dash#Figure_dash
    /// </remarks>
    public const char FigureDash = '\u2012';

    /// <summary>
    /// The en dash, en rule, or nut dash[12] – is traditionally half the width of an em dash.
    /// In modern fonts, the length of the en dash is not standardized, and the en dash is often 
    /// more than half the width of the em dash
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Dash#En_dash
    /// </remarks>
    public const char EnDash = '\u2013';

    /// <summary>
    /// Em Dash.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Dash#Em_dash
    /// </remarks>
    public const char EmDash = '\u2014';

    /// <summary>
    /// Horizontal bar (aka quotation dash).
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Dash#Horizontal_bar
    /// </remarks>
    public const char HorizontalBar = '\u2015';

    /// <summary>
    /// Double vertical bar.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Vertical_bar#Mathematics
    /// </remarks>
    public const char DoubleVerticalBar = '\u2016';

    /// <summary>
    /// Double low line.
    /// </summary>
    public const char DoubleLowLine = '\u2017';

    /// <summary>
    /// Single curved quote, left. Also known as inverted comma or turned comma
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Quotation_mark#Unicode_code_point_table
    /// </remarks>
    public const char LeftSingleQuotationMark = '\u2018';

    /// <summary>
    /// See LeftSingleQuotationMark.
    /// </summary>
    public const char LsqMark = LeftSingleQuotationMark;

    /// <summary>
    /// Single curved quote, right.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Quotation_mark#Unicode_code_point_table
    /// </remarks>
    public const char RightSingleQuotationMark = '\u2019';

    /// <summary>
    /// See RightSingleQuoteMark.
    /// </summary>
    public const char RsqMark = RightSingleQuotationMark;

    /// <summary>
    /// Low single curved quote
    /// </summary>
    public const char SingleLowNineQuotationMark = '\u201A';

    /// <summary>
    /// See SinleLowNineQuotationMark.
    /// </summary>
    public const char SlnqMark = SingleLowNineQuotationMark;

    /// <summary>
    /// Single High-Reversed-9 Quotation Mark. Also called single reversed comma, quotation mark.
    /// </summary>
    public const char SingleHighReversedNineQuotationMark = '\u201B';

    /// <summary>
    /// See SingleHighReversedNineQuotationMark.
    /// </summary>
    public const char SlhrnqMark = SingleHighReversedNineQuotationMark;

    /// <summary>
    /// Left double quotation mark. (&amp;ldquo, &amp;OpenCurlyDoubleQuote).
    /// </summary>
    public const char LeftDoubleQuotationMark = '\u201C';

    /// <summary>
    /// Right double quotation mark. (&amp;rldquo, &amp;CloseCurlyDoubleQuote).
    /// </summary>
    public const char RightDoubleQuotationMark = '\u201D';

    /// <summary>
    /// Low double curved quote, left.
    /// </summary>
    public const char DoubleLowNineQuotationMark = '\u201E';

    /// <summary>
    /// Double High-Reversed-9 Quotation Mark.
    /// </summary>
    public const char DoubleHighReversedNineQuotationMark = '\u201F';

    /// <summary>
    /// Daggar (†).
    /// </summary>
    public const char Dagger = '\u2020';

    /// <summary>
    /// Double dagger (‡).
    /// </summary>
    public const char DoubleDagger = '\u2021';

    /// <summary>
    /// Bullet (•)
    /// </summary>
    public const char Bullet = '\u2022';

    /// <summary>
    /// Triangular Bullet (‣)
    /// </summary>
    public const char TriangularBullet = '\u2023';

    /// <summary>
    /// One Dot Leadter (․)
    /// </summary>
    public const char OneDotLeader = '\u2024';

    /// <summary>
    /// Two Dot Leader (‥)
    /// </summary>
    public const char TwoDotLeader = '\u2025';

    /// <summary>
    /// Horizontal Elipsis (…)
    /// </summary>
    public const char HorizontalElipsis = '\u2026';

    /// <summary>
    /// Hyphenation Point (‧)
    /// </summary>
    public const char HyphenationPoint = '\u2027';

    /// <summary>
    /// Line Separator.
    /// </summary>
    public const char LineSeparator = '\u2028';

    /// <summary>
    /// Paragraph Separator.
    /// </summary>
    public const char ParagraphSeparator = '\u2029';

    /// <summary>
    /// Left To Right Embedding.
    /// </summary>
    public const char LeftToRightEmbedding = '\u202A';

    /// <summary>
    /// Right To Left Embedding.
    /// </summary>
    public const char RightToLeftEmbedding = '\u202B';

    /// <summary>
    /// Pop Directional Formatting. format control character used in Unicode to
    /// terminate the effect of a previous directional formatting control, such
    /// as a left-to-right or right-to-left embedding or override.
    /// </summary>
    public const char PopDirectionalFormatting = '\u202C';

    /// <summary>
    /// Left To Right Override. 
    /// </summary>
    public const char LeftToRightOverride = '\u202D';

    /// <summary>
    /// Right To Left Override.
    /// </summary>
    public const char RightToLeftOverride = '\u202E';

    /// <summary>
    /// Narrow No Break Space.  It is a narrow form of a no-break space, typically
    /// the width of a thin space or a mid space. The character is also commonly
    /// abbreviated as NNBSP.
    /// </summary>
    public const char NarrowNoBreakSpace = '\u202F';

    /// <summary>
    /// Per mille sign (‰). Parts per thousand.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Per_mille.
    /// </remarks>
    public const char Permille = '\u2030';

    /// <summary>
    /// Permyriad sign (‱). AKA: basis point, one hundredth of one percent,
    /// or one tenthousandth.
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Basis_point.
    /// </remarks>
    public const char Permyriad = '\u2031';

    /// <inheritdoc cref="Permyriad"/>
    public const char BasisPoint = Permyriad;

    /// <summary>
    /// Prime symbol (′).
    /// </summary>
    /// <remarks>
    /// See: https://en.wikipedia.org/wiki/Prime_(symbol)
    /// </remarks>
    public const char Prime = '\u2032';

    /// <summary>
    /// Double Prime symbols (″").
    /// </summary>
    /// <remarks>
    /// See: https://en.wikipedia.org/wiki/Prime_(symbol)#Double_prime
    /// </remarks>
    public const char DoublePrime = '\u2033';

    /// <summary>
    /// Triple Prime (‴)
    /// </summary>
    public const char TriplePrime = '\u2034';

    /// <summary>
    /// Reverse Prime (‵).
    /// </summary>
    public const char ReversedPrime = '\u2035';

    /// <summary>
    /// Reversed Double Prime (‶).
    /// </summary>
    public const char ReversedDoublePrime = '\u2036';

    /// <summary>
    /// Reversed Triple Prime (‷).
    /// </summary>
    public const char ReversedTriplePrime = '\u2037';

    /// <summary>
    /// Caret 
    /// </summary>
    public const char Caret = '\u2038';
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


