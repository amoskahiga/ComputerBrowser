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
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ComputerBrowser.ComputerSystem
{
    /// <summary>
    /// Summary description for Computer.
    /// </summary>
    public class Computer
    {        
        public String Name { get; set; }
        public OperatingSystem OperatingSystem { get; private set; }
        public System System { get; private set; }
        public List<NetworkAdapter> NetworkAdapters { get; private set; }
        public List<Printer> Printers { get; private set; }
        public List<Process> Processes { get; private set; }
        public List<Share> Shares { get; private set; }
        public List<LogicalDisk> LogicalDisks { get; private set; }
        public List<Processor> Processors { get; private set; }

        public Computer()
        {
            OperatingSystem = new OperatingSystem();
            Printers = new List<Printer>();
            System = new System();
            NetworkAdapters = new List<NetworkAdapter>();
            Processes = new List<Process>();
            Shares = new List<Share>();
            LogicalDisks = new List<LogicalDisk>();
            Processors = new List<Processor>();
        }
    }
}
