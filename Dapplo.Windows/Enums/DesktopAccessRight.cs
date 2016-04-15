﻿/*
 * dapplo - building blocks for desktop applications
 * Copyright (C) Dapplo 2015-2016
 * 
 * For more information see: http://dapplo.net/
 * dapplo repositories are hosted on GitHub: https://github.com/dapplo
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace Dapplo.Windows.Enums
{
	/// <summary>
	/// Used to open a desktop
	/// </summary>
	[Flags]
	public enum DesktopAccessRight : uint
	{
		DESKTOP_READOBJECTS = 0x00000001,
		DESKTOP_CREATEWINDOW = 0x00000002,
		DESKTOP_CREATEMENU = 0x00000004,
		DESKTOP_HOOKCONTROL = 0x00000008,
		DESKTOP_JOURNALRECORD = 0x00000010,
		DESKTOP_JOURNALPLAYBACK = 0x00000020,
		DESKTOP_ENUMERATE = 0x00000040,
		DESKTOP_WRITEOBJECTS = 0x00000080,
		DESKTOP_SWITCHDESKTOP = 0x00000100,

		GENERIC_ALL = (DESKTOP_READOBJECTS | DESKTOP_CREATEWINDOW | DESKTOP_CREATEMENU |
			DESKTOP_HOOKCONTROL | DESKTOP_JOURNALRECORD | DESKTOP_JOURNALPLAYBACK |
			DESKTOP_ENUMERATE | DESKTOP_WRITEOBJECTS | DESKTOP_SWITCHDESKTOP)
	};
}
