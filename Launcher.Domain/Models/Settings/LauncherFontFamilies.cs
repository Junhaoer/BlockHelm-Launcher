/*
 * BlockHelm Launcher
 * Copyright (C) 2026 Quan Zhou
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <https://www.gnu.org/licenses/>.
 *
 * SPDX-License-Identifier: GPL-3.0-only
 */

namespace Launcher.Domain.Models;

public static class LauncherFontFamilies
{
    public const string MicrosoftYaHeiUI = "Microsoft YaHei UI";
    public const string MicrosoftYaHei = "Microsoft YaHei";
    public const string SimHei = "SimHei";
    public const string SimSun = "SimSun";
    public const string DengXian = "DengXian";
    public const string KaiTi = "KaiTi";
    public const string FangSong = "FangSong";
    public const string SegoeUI = "Segoe UI";
    public const string Arial = "Arial";
    public const string TimesNewRoman = "Times New Roman";
    public const string Consolas = "Consolas";

    public static IReadOnlyList<string> All { get; } =
    [
        MicrosoftYaHeiUI,
        MicrosoftYaHei,
        SimHei,
        SimSun,
        DengXian,
        KaiTi,
        FangSong,
        SegoeUI,
        Arial,
        TimesNewRoman,
        Consolas
    ];

    public static string Normalize(string? fontFamily)
    {
        foreach (var knownFontFamily in All)
        {
            if (string.Equals(knownFontFamily, fontFamily, StringComparison.OrdinalIgnoreCase))
                return knownFontFamily;
        }

        return MicrosoftYaHeiUI;
    }
}
