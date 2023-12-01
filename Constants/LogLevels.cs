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

namespace SharperHacks.CoreLibs.Constants;

/// <summary>
/// Designates the minimum logging level.
/// </summary>
/// <remarks>
/// These are here to avoid cirucular dependency between LogWrappers and AppConfig.
/// </remarks>
public enum LogLevel
{
    /// <summary>
    /// Anything and everything you might want to know about a running block of code.
    /// </summary>
    Verbose,

    /// <summary>
    /// Internal system events that aren't necessarily user observable.
    /// </summary>
    Debug,

    /// <summary>
    /// The lifeblood of operational intelligence - things happen.
    /// </summary>
    Information,

    /// <summary>
    /// Service is degraded or endangered.
    /// </summary>
    Warning,

    /// <summary>
    /// Functionality is unavailable, invariants are broken or data is corrupted.
    /// </summary>
    Error,

    /// <summary>
    /// If you have a pager, it goes off when one of these occurs.
    /// </summary>
    Fatal
}
