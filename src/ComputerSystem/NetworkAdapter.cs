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
    /// <summary>
    /// Summary description for NetworkConfiguration.
    /// </summary>
    public class NetworkAdapter
    {
        public String Model { get; set; }
        public String DatabasePath { get; set; }
        public bool DhcpEnabled { get; set; }
        public DateTime DhcpLeaseExpirationDate { get; set; }
        public DateTime DhcpLeaseObtainedDate { get; set; }
        public String DhcpServer { get; set; }
        public String DnsDomain { get; set; }
        public String DnsHostName { get; set; }
        public String[] DnsServers { get; set; }
        public String[] Gateways { get; set; }
        public String[] IPAddresses { get; set; }
        public bool IPEnabled { get; set; }
        public String[] IPSubnets { get; set; }
        public String MacAddress { get; set; }
        public String WinsHostLookupFile { get; set; }
        public bool WinsLMHostLookupEnabled { get; set; }
        public String WinsPrimaryServer { get; set; }
        public String WinsSecondaryServer { get; set; }
    }
}
