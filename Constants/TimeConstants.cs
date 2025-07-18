// Copyright and trademark notices at the end of this file.

using System.Diagnostics.CodeAnalysis;

namespace SharperHacks.CoreLibs.Constants;

/// <summary>
/// A collection of useful time constants.
/// </summary>
[ExcludeFromCodeCoverage]
public static class TimeConstants
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public const decimal SecondsPerMinute = 60;
    public const decimal MinutesPerHour = 60;
    public const decimal HoursPerDay = 24;
    public const decimal SecondsPerHour = SecondsPerMinute * MinutesPerHour;

    public const decimal NanosecondsPerMicroSecond = 1e3M;
    public const decimal NanosecondsPerMilliSecond = 1e6M;
    public const decimal NanosecondsPerSecond = 1e9M;
    public const decimal NanosecondsPerMinute = NanosecondsPerSecond * SecondsPerMinute;
    public const decimal NanosecondsPerHour = NanosecondsPerMinute * MinutesPerHour;
    public const decimal NanosecondsPerDay = NanosecondsPerHour * HoursPerDay;

    public const decimal MicrosecondsPerMilliSecond = 1e3M;
    public const decimal MicrosecondsPerSecond = 1e6M;
    public const decimal MicrosecondsPerMinute = MicrosecondsPerSecond * SecondsPerMinute;
    public const decimal MicrosecondsPerHour = MicrosecondsPerMinute * MinutesPerHour;
    public const decimal MicrosecondsPerDay = MicrosecondsPerHour * HoursPerDay;

    public const decimal MillisecondsPerSecond = 1e3M;
    public const decimal MillisecondsPerMinute = MillisecondsPerSecond * SecondsPerMinute;
    public const decimal MillisecondsPerHour = MillisecondsPerMinute * MinutesPerHour;
    public const decimal MillisecondsPerDay = MillisecondsPerHour * HoursPerDay;

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
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

