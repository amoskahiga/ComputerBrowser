// Copyright (C) 2003-2009  Amos Kariuki <amoskahiga@gmail.com>
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace ComputerBrowser.ComputerSystem
{
    public class OperatingSystem
    {
        public ulong FreePhysicalMemory { get; set; }
        public ulong FreeVirtualMemory { get; set; }
        public DateTime InstallDate { get; set; }
        public DateTime LastBootUpTime { get; set; }
        public DateTime LocalDateTime { get; set; }
        public String Name { get; set; }
        public String SerialNumber { get; set; }
        public String ServicePack { get; set; }
        public String Version { get; set; }
        public String WindowsDirectory { get; set; }
    }

}
