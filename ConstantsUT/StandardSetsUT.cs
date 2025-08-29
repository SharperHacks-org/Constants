// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.Math;
using SharperHacks.CoreLibs.Math.Interfaces;

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace SharperHacks.CoreLibs.Constants.ConstantsUT;

using CtrlCodes = AsciiControlCodes;

[ExcludeFromCodeCoverage]
[TestClass]
public class StandardSetsUT
{
    private static void VerifySetInInterval(
        IInterval<char>[] intervals,
        int lowerInclusiveBound,
        int upperInclusiveBound,
        int expectedCount,
        ImmutableHashSet<char> iut,
        string nameofMemberUnderTest)
    {
        var count = 0;
        var lowest = upperInclusiveBound;
        var highest = lowerInclusiveBound;

        foreach (var t in iut)
        {
            if (t < lowest) lowest = t;
            if (t > highest) highest = t;

            var found = false;

            foreach (var interval in intervals)
            {
                if (interval.Contains(t))
                {
                    found = true;
                    count++;
                    break;
                }

                if (found) break;
            }

            Assert.IsTrue(found,
                $"{nameofMemberUnderTest} contains out of range value: {(int)t}");
        }

        Assert.AreEqual(expectedCount, count);

        Assert.AreEqual(lowerInclusiveBound, lowest);
        Assert.AreEqual(upperInclusiveBound, highest);
    }


    [TestMethod]
    public void VerifyAsciiControlCodes()
    {
        var asciiCtrlCodeRange = new Interval<char>(
            (char)0, 
            IntervalBoundaryType.Inclusive, 
            (char)31,
            IntervalBoundaryType.Inclusive) as IInterval<char>;

        VerifySetInInterval(
            [asciiCtrlCodeRange],
            0,
            31,
            32,
            StandardSets.AsciiControlCodes,
            nameof(StandardSets.AsciiControlCodes));

        var ctrlCodeArray = AsciiControlCodes.AsArray;

        Assert.AreEqual(32, ctrlCodeArray.Length);

        for(int idx = 0; idx < 32; idx++)
        {
            Assert.AreEqual(idx, ctrlCodeArray[idx]);
        }
    }

    [TestMethod]
    public void VerifyUpperAlphaCharacters()
    {
        var upperAlphaCharacterRange = new Interval<char>(
            'A',
            IntervalBoundaryType.Inclusive,
            'Z',
            IntervalBoundaryType.Inclusive) as IInterval<char>;
        VerifySetInInterval(
            [upperAlphaCharacterRange],
            'A',
            'Z',
            26,
            StandardSets.UpperAlphaCharacters,
            nameof(StandardSets.UpperAlphaCharacters));
    }

    [TestMethod]
    public void VerifyLowerAlphaCharacters()
    {
        var lowerAlphaCharacterRange = new Interval<char>(
            'a',
            IntervalBoundaryType.Inclusive,
            'z',
            IntervalBoundaryType.Inclusive) as IInterval<char>;
        VerifySetInInterval(
            [lowerAlphaCharacterRange],
            'a',
            'z',
            26,
            StandardSets.LowerAlphaCharacters,
            nameof(StandardSets.LowerAlphaCharacters));
    }

    [TestMethod]
    public void VerifyDecimalDigits()
    {
        var decimalDigitsRange = new Interval<char>(
            '0',
            IntervalBoundaryType.Inclusive,
            '9',
            IntervalBoundaryType.Inclusive) as IInterval<char>;
        VerifySetInInterval(
            [decimalDigitsRange],
            (int)'0',
            (int)'9',
            10,
            StandardSets.DecimalDigits,
            nameof(StandardSets.DecimalDigits));
    }

    [TestMethod]
    public void VerifyHexDigits()
    {
        var decimalDigitsRange = new Interval<char>(
            '0',
            IntervalBoundaryType.Inclusive,
            '9',
            IntervalBoundaryType.Inclusive) as IInterval<char>;
        var lowerCaseDigitsRange = new Interval<char>(
            'a',
            IntervalBoundaryType.Inclusive,
            'f',
            IntervalBoundaryType.Inclusive) as IInterval<char>;
        var upperCaseDigitsRange = new Interval<char>(
            'A',
            IntervalBoundaryType.Inclusive,
            'F',
            IntervalBoundaryType.Inclusive) as IInterval<char>;

        VerifySetInInterval(
            [decimalDigitsRange, lowerCaseDigitsRange, upperCaseDigitsRange],
            (int)'0',
            (int)'f',
            22,
            StandardSets.HexDigits,
            nameof(StandardSets.HexDigits));
    }

    [TestMethod]
    public void VerifyWhiteSpace()
    {
        Assert.AreEqual(4, StandardSets.WhiteSpace.Count);
        Assert.IsTrue(StandardSets.WhiteSpace.Contains(Characters.Space));
        Assert.IsTrue(StandardSets.WhiteSpace.Contains('\n'));
        Assert.IsTrue(StandardSets.WhiteSpace.Contains('\r'));
        Assert.IsTrue(StandardSets.WhiteSpace.Contains('\t'));
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
