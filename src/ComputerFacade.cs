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
using System.Management;
using ComputerBrowser.ComputerSystem;

namespace ComputerBrowser
{
    /// <summary>
    /// Contains methods to obtain a computer configuration by querying
    /// a computer through the WMI interface.
    /// </summary>
    public class ComputerFacade
    {
        /// <summary>
        /// Class cannot be instatiated, use static method to perform actions
        /// </summary>
        private ComputerFacade() { }

        private static Computer GetComputer(ManagementScope scope)
        {
            Computer Computer = new Computer();

            foreach (ROOT.CIMV2.Win32.OperatingSystem0 col in ROOT.CIMV2.Win32.OperatingSystem0.GetInstances(scope, ""))
            {
                AddOperatingSystem(Computer, col);
            }
            foreach (ROOT.CIMV2.Win32.ComputerSystem col in ROOT.CIMV2.Win32.ComputerSystem.GetInstances(scope, ""))
            {
                AddComputerSystem(Computer, col);
            }
            foreach (ROOT.CIMV2.Win32.Share col in ROOT.CIMV2.Win32.Share.GetInstances(scope, ""))
            {
                AddShare(Computer, col);
            }
            foreach (ROOT.CIMV2.Win32.Processor col in ROOT.CIMV2.Win32.Processor.GetInstances(scope, ""))
            {
                AddProcessor(Computer, col);
            }
            foreach (ROOT.CIMV2.Win32.LogicalDisk col in ROOT.CIMV2.Win32.LogicalDisk.GetInstances(scope, ""))
            {
                AddLogicalDisk(Computer, col);
            }
            foreach (ROOT.CIMV2.Win32.Process col in ROOT.CIMV2.Win32.Process.GetInstances(scope, ""))
            {
                AddProcess(Computer, col);
            }
            foreach (ROOT.CIMV2.Win32.Printer col in ROOT.CIMV2.Win32.Printer.GetInstances(scope, ""))
            {
                AddPrinter(Computer, col);
            }

            foreach (ROOT.CIMV2.Win32.NetworkAdapterConfiguration col in ROOT.CIMV2.Win32.NetworkAdapterConfiguration.GetInstances(scope, ""))
            {
                if (col.IPEnabled)
                {
                    AddNetworkAdapter(Computer, col);
                    //TreeNode CurrentNetworkAdapterConfigurationNode = new TreeNode( col.Description );
                    //AddNetworkAdapterConfiguration(CurrentNetworkAdapterConfigurationNode, col );
                    //NetworkAdapterConfigurationNode.Nodes.Add( CurrentNetworkAdapterConfigurationNode );
                }
            }

            return Computer;
        }


        /// <summary>
        /// Uses the WMI interface to query and creat a computer object.
        /// </summary>
        /// <param name="computerName"></param>
        /// <returns>Computer object containing properties obtined from querying it through the WMI.</returns>
        public static Computer GetComputer(String computerName)
        {
            ConnectionOptions options = new ConnectionOptions();
            return GetComputer(computerName, options);
        }


        /// <summary>
        /// Uses the WMI interface to query and creat a computer object. Supply the connection options
        /// e.g the Username and Password used in connecting to the PC.
        /// </summary>
        /// <param name="computerName">name of computer to query.</param>
        /// <param name="options">Options used in making the connection.</param>
        /// <returns>Computer object containing properties obtined from querying it through the WMI.</returns>
        public static Computer GetComputer(String computerName, ConnectionOptions options)
        {
            ManagementScope scope = new ManagementScope(@"\\" + computerName.Trim() + @"\root\cimv2", options);
            return GetComputer(scope);
        }


        #region Different methods to add different computer properties to nodes

        private static void AddComputerSystem(Computer computer, ROOT.CIMV2.Win32.ComputerSystem wmiComputerSystem)
        {
            // Set computer name
            computer.Name = wmiComputerSystem.Name;

            computer.System.LoggedOnUser = wmiComputerSystem.UserName;
            computer.System.Manufacturer = wmiComputerSystem.Manufacturer;
            computer.System.Model = wmiComputerSystem.Model;
            computer.System.Domain = wmiComputerSystem.Domain;
            computer.System.TotalMemory = wmiComputerSystem.TotalPhysicalMemory;
        }


        private static void AddProcessor(Computer computer, ROOT.CIMV2.Win32.Processor wmiProcessor)
        {
            Processor processor = new Processor();

            processor.Name = wmiProcessor.Name.Trim();
            processor.Speed = wmiProcessor.MaxClockSpeed;
            processor.L2CacheSize = wmiProcessor.L2CacheSize;
            processor.UpgradeMethod = wmiProcessor.UpgradeMethod.ToString();
            processor.Version = wmiProcessor.Version;

            computer.Processors.Add(processor);
        }


        private static void AddLogicalDisk(Computer computer, ROOT.CIMV2.Win32.LogicalDisk wmiLogicalDisk)
        {
            LogicalDisk logicalDisk = new LogicalDisk();

            logicalDisk.Description = wmiLogicalDisk.Description;
            logicalDisk.Name = wmiLogicalDisk.Name;
            logicalDisk.ShareName = wmiLogicalDisk.ProviderName;
            logicalDisk.Type = wmiLogicalDisk.DriveType.ToString();
            logicalDisk.FileSystem = wmiLogicalDisk.FileSystem;
            logicalDisk.FreeSpace = wmiLogicalDisk.FreeSpace;
            logicalDisk.Size = wmiLogicalDisk.Size;

            computer.LogicalDisks.Add(logicalDisk);
        }


        private static void AddOperatingSystem(Computer computer, ROOT.CIMV2.Win32.OperatingSystem0 wmiOS)
        {
            computer.OperatingSystem.FreePhysicalMemory = wmiOS.FreePhysicalMemory;
            computer.OperatingSystem.FreeVirtualMemory = wmiOS.FreeVirtualMemory;
            computer.OperatingSystem.InstallDate = wmiOS.InstallDate;
            computer.OperatingSystem.LastBootUpTime = wmiOS.LastBootUpTime;
            computer.OperatingSystem.LocalDateTime = wmiOS.LocalDateTime;
            computer.OperatingSystem.Name = wmiOS.Caption;
            computer.OperatingSystem.SerialNumber = wmiOS.SerialNumber;
            computer.OperatingSystem.ServicePack = wmiOS.CSDVersion;
            computer.OperatingSystem.Version = wmiOS.Version;
            computer.OperatingSystem.WindowsDirectory = wmiOS.WindowsDirectory;
        }


        private static void AddShare(Computer computer, ROOT.CIMV2.Win32.Share wmiShare)
        {
            Share share = new Share();
            share.Name = wmiShare.Name;
            share.Description = wmiShare.Description;
            share.Path = wmiShare.Path0;
            share.Type = wmiShare.Type.ToString();

            computer.Shares.Add(share);
        }


        private static void AddPrinter(Computer computer, ROOT.CIMV2.Win32.Printer wmiPrinter)
        {
            Printer printer = new Printer();
            printer.Name = wmiPrinter.Name;
            printer.ShareName = wmiPrinter.ShareName;
            printer.ServerName = wmiPrinter.ServerName;
            printer.State = wmiPrinter.PrinterState.ToString();
            printer.Status = wmiPrinter.PrinterStatus.ToString();
            printer.DataType = wmiPrinter.PrintJobDataType;
            printer.HorizontalResolution = wmiPrinter.HorizontalResolution;
            printer.VerticalResolution = wmiPrinter.VerticalResolution;

            computer.Printers.Add(printer);
        }


        private static void AddProcess(Computer computer, ROOT.CIMV2.Win32.Process wmiProcess)
        {
            Process process = new Process();
            process.Name = wmiProcess.Name;
            process.Path = wmiProcess.ExecutablePath;

            computer.Processes.Add(process);
        }


        private static void AddNetworkAdapter(Computer computer, ROOT.CIMV2.Win32.NetworkAdapterConfiguration wmiNetworkAdapter)
        {
            NetworkAdapter networkAdapter = new NetworkAdapter();
            networkAdapter.Model = wmiNetworkAdapter.Description;
            networkAdapter.DnsDomain = wmiNetworkAdapter.DNSDomain;
            networkAdapter.DnsHostName = wmiNetworkAdapter.DNSHostName;
            networkAdapter.MacAddress = wmiNetworkAdapter.MACAddress;
            networkAdapter.DhcpEnabled = wmiNetworkAdapter.DHCPEnabled;
            networkAdapter.DhcpLeaseExpirationDate = wmiNetworkAdapter.DHCPLeaseExpires;
            networkAdapter.DhcpLeaseObtainedDate = wmiNetworkAdapter.DHCPLeaseObtained;
            networkAdapter.DhcpServer = wmiNetworkAdapter.DHCPServer;
            networkAdapter.DatabasePath = wmiNetworkAdapter.DatabasePath;
            networkAdapter.WinsLMHostLookupEnabled = wmiNetworkAdapter.WINSEnableLMHostsLookup;
            networkAdapter.WinsHostLookupFile = wmiNetworkAdapter.WINSHostLookupFile;
            networkAdapter.WinsPrimaryServer = wmiNetworkAdapter.WINSPrimaryServer;
            networkAdapter.WinsSecondaryServer = wmiNetworkAdapter.WINSSecondaryServer;
            networkAdapter.Model = wmiNetworkAdapter.Description;


            networkAdapter.IPEnabled = wmiNetworkAdapter.IPEnabled;
            networkAdapter.IPAddresses = wmiNetworkAdapter.IPAddress;
            networkAdapter.DnsServers = wmiNetworkAdapter.DNSServerSearchOrder;
            networkAdapter.Gateways = wmiNetworkAdapter.DefaultIPGateway;
            networkAdapter.IPSubnets = wmiNetworkAdapter.IPSubnet;

            computer.NetworkAdapters.Add(networkAdapter);
        }

        #endregion

    }
}
