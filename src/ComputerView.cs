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

using ComputerBrowser.ComputerSystem;

namespace ComputerBrowser
{
    /// <summary>
    /// A helper class for adding a computer object to a TreeView as a node.
    /// </summary>
    public class ComputerView
    {
        /// <summary>
        /// Adds a Computer object to the specified TreeView.
        /// </summary>
        /// <param name="treeView">TreeView to add Computer to</param>
        /// <param name="computer">Computer added as a node to the TreeView</param>
        static public void AddComputerToView(TreeView treeView, Computer computer)
        {

            TreeNode computerNode = new TreeNode(computer.Name);

            AddOperatingSystemNode(computerNode, computer.OperatingSystem);
            AddPrintersNode(computerNode, computer.Printers);
            AddProcessesNode(computerNode, computer.Processes);
            AddSharesNode(computerNode, computer.Shares);
            AddLogicalDisksNode(computerNode, computer.LogicalDisks);
            AddComputerSystemNode(computerNode, computer.System);
            AddProcessorsNode(computerNode, computer.Processors);
            AddNetworkAdaptersNode(computerNode, computer.NetworkAdapters);

            // Add computer node and its related nodes to this tree view control
            treeView.BeginUpdate();
            treeView.Nodes.Add(computerNode);
            treeView.EndUpdate();
        }

        static private void AddComputerSystemNode(TreeNode computerNode, ComputerSystem.System computerSystem)
        {
            TreeNode computerSystemNode = new TreeNode("Computer System");

            computerSystemNode.Nodes.Add("Currently logged on user - " + computerSystem.LoggedOnUser);
            computerSystemNode.Nodes.Add("Manufacturer - " + computerSystem.Manufacturer);
            computerSystemNode.Nodes.Add("Model - " + computerSystem.Model);
            computerSystemNode.Nodes.Add("Domain - " + computerSystem.Domain);
            computerSystemNode.Nodes.Add("Total Memory - " + FormatBytes(computerSystem.TotalMemory));

            computerNode.Nodes.Add(computerSystemNode);
        }


        static private void AddOperatingSystemNode(TreeNode computerNode, ComputerSystem.OperatingSystem operatingSystem)
        {
            TreeNode operatingSystemNode = new TreeNode("Operating System");

            operatingSystemNode.Nodes.Add("Name - " + operatingSystem.Name);
            operatingSystemNode.Nodes.Add("Version - " + operatingSystem.Version);
            operatingSystemNode.Nodes.Add("OS Serial Number - " + operatingSystem.SerialNumber);
            operatingSystemNode.Nodes.Add("Service Packs - " + operatingSystem.ServicePack);
            operatingSystemNode.Nodes.Add("Windows Directory - " + operatingSystem.WindowsDirectory);
            operatingSystemNode.Nodes.Add("Free Physical Memory - " + FormatBytes(operatingSystem.FreePhysicalMemory));
            operatingSystemNode.Nodes.Add("Free Virtual Memory - " + FormatBytes(operatingSystem.FreeVirtualMemory));
            operatingSystemNode.Nodes.Add("Install Date - " + operatingSystem.InstallDate.ToString());
            operatingSystemNode.Nodes.Add("Local Date Time - " + operatingSystem.LocalDateTime.ToString());
            operatingSystemNode.Nodes.Add("Last Boot Time - " + operatingSystem.LastBootUpTime.ToString());

            computerNode.Nodes.Add(operatingSystemNode);
        }


        static private void AddPrintersNode(TreeNode computerNode, List<Printer> printers)
        {
            TreeNode printersNode = new TreeNode("Printers");
            computerNode.Nodes.Add(printersNode);

            // Add each printer to the Printers node.
            foreach (ComputerSystem.Printer printer in printers)
            {
                TreeNode printerNode = new TreeNode(printer.Name);

                printerNode.Nodes.Add("Server Name - " + printer.ServerName);
                printerNode.Nodes.Add("Share Name - " + printer.ShareName);
                printerNode.Nodes.Add("State - " + printer.State);
                printerNode.Nodes.Add("Status - " + printer.Status);
                printerNode.Nodes.Add("Datatype - " + printer.DataType);
                printerNode.Nodes.Add("Resolution - " + printer.HorizontalResolution + "x" + printer.VerticalResolution);

                printersNode.Nodes.Add(printerNode);
            }
        }


        static private void AddProcessesNode(TreeNode computerNode, List<Process> processes)
        {
            TreeNode processesNode = new TreeNode("Running Processes");
            computerNode.Nodes.Add(processesNode);

            foreach (ComputerSystem.Process process in processes)
            {
                TreeNode processNode = new TreeNode(process.Name);
                processNode.Nodes.Add("Path Name - " + process.Path);
                processesNode.Nodes.Add(processNode);
            }
        }


        static private void AddSharesNode(TreeNode computerNode, List<Share> shares)
        {
            TreeNode sharesNode = new TreeNode("Shares");
            computerNode.Nodes.Add(sharesNode);

            foreach (ComputerSystem.Share share in shares)
            {
                TreeNode shareNode = new TreeNode(share.Name);
                shareNode.Nodes.Add("Description - " + share.Description);
                shareNode.Nodes.Add("Path - " + share.Path);
                shareNode.Nodes.Add("Status - " + share.Status);
                shareNode.Nodes.Add("Type - " + share.Type);
                sharesNode.Nodes.Add(shareNode);
            }
        }


        static private void AddLogicalDisksNode(TreeNode computerNode, List<LogicalDisk> logicalDisks)
        {
            TreeNode logicalDisksNode = new TreeNode("Disk Volumes");
            computerNode.Nodes.Add(logicalDisksNode);

            foreach (ComputerSystem.LogicalDisk logicalDisk in logicalDisks)
            {
                TreeNode logicalDiskNode = new TreeNode(logicalDisk.Name);
                logicalDiskNode.Nodes.Add("Description - " + logicalDisk.Description);
                logicalDiskNode.Nodes.Add("Type - " + logicalDisk.Type);
                logicalDiskNode.Nodes.Add("File System - " + logicalDisk.FileSystem);
                logicalDiskNode.Nodes.Add("Size - " + FormatBytes(logicalDisk.Size));
                logicalDiskNode.Nodes.Add("Free Space - " + FormatBytes(logicalDisk.FreeSpace));
                logicalDiskNode.Nodes.Add("ShareName - " + logicalDisk.ShareName);
                
                logicalDisksNode.Nodes.Add(logicalDiskNode);
            }
        }


        static private void AddProcessorsNode(TreeNode computerNode, List<Processor> processors)
        {
            TreeNode processorsNode = new TreeNode("Processors");
            computerNode.Nodes.Add(processorsNode);

            foreach (Processor processor in processors)
            {
                TreeNode processorNode = new TreeNode(processor.Name);
                processorNode.Nodes.Add("Version - " + processor.Version);
                processorNode.Nodes.Add("Speed - " + processor.Speed + " MHz");
                processorNode.Nodes.Add("L2 Cache Size - " + FormatBytes(processor.L2CacheSize));
                processorNode.Nodes.Add("Upgrade Methods - " + processor.UpgradeMethod);

                processorsNode.Nodes.Add(processorNode);
            }
        }


        static private void AddNetworkAdaptersNode(TreeNode computerNode, List<NetworkAdapter> networkAdapters)
        {
            TreeNode networkAdaptersNode = new TreeNode("Network Adapters");
            computerNode.Nodes.Add(networkAdaptersNode);

            foreach (ComputerSystem.NetworkAdapter networkAdapter in networkAdapters)
            {
                TreeNode networkAdapterNode = new TreeNode(networkAdapter.Model);

                TreeNode generalNode = new TreeNode("General");
                generalNode.Nodes.Add("MAC address - " + networkAdapter.MacAddress);
                generalNode.Nodes.Add("Database path - " + networkAdapter.DatabasePath);
                if (networkAdapter.Gateways != null)
                    foreach (string gateway in networkAdapter.Gateways)
                    {
                        generalNode.Nodes.Add("Gateway - " + gateway);
                    }
                networkAdapterNode.Nodes.Add(generalNode);

                TreeNode ipNode = new TreeNode("IP");
                ipNode.Nodes.Add("IP enabled - " + networkAdapter.IPEnabled.ToString());
                foreach (string ip in networkAdapter.IPAddresses)
                {
                    ipNode.Nodes.Add("IP address - " + ip);
                }
                foreach (string subnet in networkAdapter.IPSubnets)
                {
                    ipNode.Nodes.Add("IP subnet - " + subnet);
                }
                networkAdapterNode.Nodes.Add(ipNode);

                TreeNode dhcpNode = new TreeNode("DHCP");
                dhcpNode.Nodes.Add("DHCP enabled - " + networkAdapter.DhcpEnabled.ToString());
                dhcpNode.Nodes.Add("DHCP server - " + networkAdapter.DhcpServer);
                dhcpNode.Nodes.Add("DHCP lease expires - " + networkAdapter.DhcpLeaseExpirationDate.ToString());
                dhcpNode.Nodes.Add("DHCP lease obtained - " + networkAdapter.DhcpLeaseObtainedDate.ToString());

                networkAdapterNode.Nodes.Add(dhcpNode);

                TreeNode winsNode = new TreeNode("WINS");
                winsNode.Nodes.Add("WINS primary server - " + networkAdapter.WinsPrimaryServer);
                winsNode.Nodes.Add("WINS secondary server - " + networkAdapter.WinsSecondaryServer);
                winsNode.Nodes.Add("WINS LMHost lookup enabled - " + networkAdapter.WinsLMHostLookupEnabled.ToString());
                winsNode.Nodes.Add("WINS Host lookup file - " + networkAdapter.WinsHostLookupFile);
                networkAdapterNode.Nodes.Add(winsNode);

                TreeNode dnsNode = new TreeNode("DNS");
                if (networkAdapter.DnsServers != null)
                {
                    foreach (string dnsServer in networkAdapter.DnsServers)
                    {
                        dnsNode.Nodes.Add("DNS server - " + dnsServer);
                    }
                }
                dnsNode.Nodes.Add("DNS domain - " + networkAdapter.DnsDomain);
                dnsNode.Nodes.Add("DNS host name - " + networkAdapter.DnsHostName);
                networkAdapterNode.Nodes.Add(dnsNode);

                networkAdaptersNode.Nodes.Add(networkAdapterNode);
            }
        }

        /// <summary>
        /// Formats an integer representation of a data size (in bytes) into a
        /// pretty string  (metric).
        /// </summary>
        /// <permission cref="http://sharpertutorials.com/pretty-format-bytes-kb-mb-gb/">Ben Laan</permission>
        /// <param name="bytes"></param>
        /// <returns></returns>
        static private string FormatBytes(ulong bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB", "Bytes" };
            ulong max = (ulong)Math.Pow(scale, orders.Length - 1);

            foreach (string order in orders)
            {
                if (bytes > max)
                    return string.Format("{0:##.##} {1}", decimal.Divide(bytes, max), order);

                max /= scale;
            }
            return "0 Bytes";
        }
    }
}
