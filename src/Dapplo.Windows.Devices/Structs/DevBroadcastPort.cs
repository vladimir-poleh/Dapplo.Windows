﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2017-2019 Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.Windows
// 
//  Dapplo.Windows is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.Windows is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Windows. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

using System.Runtime.InteropServices;
using Dapplo.Windows.Devices.Enums;

namespace Dapplo.Windows.Devices.Structs
{
    /// <summary>
    /// Contains information about a modem, serial, or parallel port.
    /// See <a href="https://docs.microsoft.com/en-us/windows/win32/api/dbt/ns-dbt-dev_broadcast_port_w">DEV_BROADCAST_PORT_W structure</a>
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DevBroadcastPort
    {
        private int _size;
        // The device type, which determines the event-specific information that follows the first three members. 
        private DeviceBroadcastDeviceType _deviceType;
        private readonly int _reserved;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
        private readonly string _name;

        /// <summary>
        /// The name of the device.
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// Factory for an empty DevBroadcastPort
        /// </summary>
        /// <returns>DevBroadcastPort</returns>
        public static DevBroadcastPort Create()
        {
            return new DevBroadcastPort
            {
                _deviceType = DeviceBroadcastDeviceType.Port,
                _size = Marshal.SizeOf(typeof(DevBroadcastPort))
            };
        }
    }
}
