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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ComputerBrowser
{
	/// <summary>
	/// Summary description for ComputerPropertyOptions.
	/// </summary>
	public class ComputerPropertyOptions : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox ComputerSystemGroupBox;
		private System.Windows.Forms.CheckBox DomainCheckBox;
		private System.Windows.Forms.CheckBox ManufacturerCheckBox;
		private System.Windows.Forms.CheckBox ModelCheckBox;
		private System.Windows.Forms.CheckBox TotalMemoryCheckBox;
		private System.Windows.Forms.GroupBox DiskGroupBox;
		private System.Windows.Forms.CheckBox DescriptionCheckBox;
		private System.Windows.Forms.CheckBox SizeCheckBox;
		private System.Windows.Forms.CheckBox FileSystemCheckBox;
		private System.Windows.Forms.CheckBox TypeCheckBox;
		private System.Windows.Forms.GroupBox NetworkConfigurationGroupBox;
		private System.Windows.Forms.CheckBox DatabasePathCheckBox;
		private System.Windows.Forms.CheckBox DHCPleaseExpiresCheckBox;
		private System.Windows.Forms.CheckBox DHCPenabledCheckBox;
		private System.Windows.Forms.CheckBox DHCPleaseObtainedCheckBox;
		private System.Windows.Forms.CheckBox DHCPserverCheckBox;
		private System.Windows.Forms.CheckBox DNSdomainCheckBox;
		private System.Windows.Forms.CheckBox DNShostNameCheckBox;
		private System.Windows.Forms.CheckBox DNSserverCheckBox;
		private System.Windows.Forms.CheckBox GatewayCheckBox;
		private System.Windows.Forms.CheckBox IPaddressCheckBox;
		private System.Windows.Forms.CheckBox IPenabledCheckBox;
		private System.Windows.Forms.CheckBox IPsubnetCheckBox;
		private System.Windows.Forms.CheckBox MACaddressCheckBox;
		private System.Windows.Forms.CheckBox WINShostLookupFileCheckBox;
		private System.Windows.Forms.CheckBox WINSlmhostLookupEnabledCheckBox;
		private System.Windows.Forms.CheckBox WINSprimaryServerCheckBox;
		private System.Windows.Forms.CheckBox WINSsecondaryServerCheckBox;
		private System.Windows.Forms.GroupBox OperatingSystemGroupBox;
		private System.Windows.Forms.CheckBox FreePhysicalMemoryCheckBox;
		private System.Windows.Forms.CheckBox FreeVirtualMemoryCheckBox;
		private System.Windows.Forms.CheckBox InstallDateCheckBox;
		private System.Windows.Forms.CheckBox LastBootTimeCheckBox;
		private System.Windows.Forms.CheckBox LocalDateTimeCheckBox;
		private System.Windows.Forms.CheckBox NameCheckBox;
		private System.Windows.Forms.CheckBox OSserialNumberCheckBox;
		private System.Windows.Forms.CheckBox ServicePacksCheckBox;
		private System.Windows.Forms.CheckBox VersionCheckBox;
		private System.Windows.Forms.CheckBox WindowsDirectoryCheckBox;
		private System.Windows.Forms.GroupBox SharesGroupBox;
		private System.Windows.Forms.GroupBox PrintersGroupBox;
		private System.Windows.Forms.GroupBox ProcessorsGroupBox;
		private System.Windows.Forms.GroupBox RunningProcessesGroupBox;
		private System.Windows.Forms.CheckBox DatatypeCheckBox;
		private System.Windows.Forms.CheckBox ResolutionCheckBox;
		private System.Windows.Forms.CheckBox ServerNameCheckBox;
		private System.Windows.Forms.CheckBox ShareNameCheckBox;
		private System.Windows.Forms.CheckBox StateCheckBox;
		private System.Windows.Forms.CheckBox StatusCheckBox;
		private System.Windows.Forms.CheckBox L2CacheSizeCheckBox;
		private System.Windows.Forms.CheckBox MaxClockSpeedCheckBox;
		private System.Windows.Forms.CheckBox UpgradeTypeCheckBox;
		private System.Windows.Forms.CheckBox ProcessorCheckBox;
		private System.Windows.Forms.CheckBox ProcessorVersionCheckBox;
		private System.Windows.Forms.CheckBox SharesDescriptionCheckBox;
		private System.Windows.Forms.CheckBox PathCheckBox;
		private System.Windows.Forms.CheckBox ShareStatusCheckBox;
		private System.Windows.Forms.CheckBox ShareTypeCheckBox;
		private System.Windows.Forms.CheckBox ProcessNameCheckBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ComputerPropertyOptions()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ComputerSystemGroupBox = new System.Windows.Forms.GroupBox();
			this.DomainCheckBox = new System.Windows.Forms.CheckBox();
			this.ManufacturerCheckBox = new System.Windows.Forms.CheckBox();
			this.ModelCheckBox = new System.Windows.Forms.CheckBox();
			this.TotalMemoryCheckBox = new System.Windows.Forms.CheckBox();
			this.DiskGroupBox = new System.Windows.Forms.GroupBox();
			this.DescriptionCheckBox = new System.Windows.Forms.CheckBox();
			this.SizeCheckBox = new System.Windows.Forms.CheckBox();
			this.FileSystemCheckBox = new System.Windows.Forms.CheckBox();
			this.TypeCheckBox = new System.Windows.Forms.CheckBox();
			this.NetworkConfigurationGroupBox = new System.Windows.Forms.GroupBox();
			this.DatabasePathCheckBox = new System.Windows.Forms.CheckBox();
			this.DHCPleaseExpiresCheckBox = new System.Windows.Forms.CheckBox();
			this.DHCPenabledCheckBox = new System.Windows.Forms.CheckBox();
			this.DHCPleaseObtainedCheckBox = new System.Windows.Forms.CheckBox();
			this.DHCPserverCheckBox = new System.Windows.Forms.CheckBox();
			this.DNSdomainCheckBox = new System.Windows.Forms.CheckBox();
			this.DNShostNameCheckBox = new System.Windows.Forms.CheckBox();
			this.DNSserverCheckBox = new System.Windows.Forms.CheckBox();
			this.GatewayCheckBox = new System.Windows.Forms.CheckBox();
			this.IPaddressCheckBox = new System.Windows.Forms.CheckBox();
			this.IPenabledCheckBox = new System.Windows.Forms.CheckBox();
			this.IPsubnetCheckBox = new System.Windows.Forms.CheckBox();
			this.MACaddressCheckBox = new System.Windows.Forms.CheckBox();
			this.WINShostLookupFileCheckBox = new System.Windows.Forms.CheckBox();
			this.WINSlmhostLookupEnabledCheckBox = new System.Windows.Forms.CheckBox();
			this.WINSprimaryServerCheckBox = new System.Windows.Forms.CheckBox();
			this.WINSsecondaryServerCheckBox = new System.Windows.Forms.CheckBox();
			this.OperatingSystemGroupBox = new System.Windows.Forms.GroupBox();
			this.FreePhysicalMemoryCheckBox = new System.Windows.Forms.CheckBox();
			this.FreeVirtualMemoryCheckBox = new System.Windows.Forms.CheckBox();
			this.InstallDateCheckBox = new System.Windows.Forms.CheckBox();
			this.LastBootTimeCheckBox = new System.Windows.Forms.CheckBox();
			this.LocalDateTimeCheckBox = new System.Windows.Forms.CheckBox();
			this.NameCheckBox = new System.Windows.Forms.CheckBox();
			this.OSserialNumberCheckBox = new System.Windows.Forms.CheckBox();
			this.ServicePacksCheckBox = new System.Windows.Forms.CheckBox();
			this.VersionCheckBox = new System.Windows.Forms.CheckBox();
			this.WindowsDirectoryCheckBox = new System.Windows.Forms.CheckBox();
			this.SharesGroupBox = new System.Windows.Forms.GroupBox();
			this.PrintersGroupBox = new System.Windows.Forms.GroupBox();
			this.ProcessorsGroupBox = new System.Windows.Forms.GroupBox();
			this.RunningProcessesGroupBox = new System.Windows.Forms.GroupBox();
			this.DatatypeCheckBox = new System.Windows.Forms.CheckBox();
			this.ResolutionCheckBox = new System.Windows.Forms.CheckBox();
			this.ServerNameCheckBox = new System.Windows.Forms.CheckBox();
			this.ShareNameCheckBox = new System.Windows.Forms.CheckBox();
			this.StateCheckBox = new System.Windows.Forms.CheckBox();
			this.StatusCheckBox = new System.Windows.Forms.CheckBox();
			this.L2CacheSizeCheckBox = new System.Windows.Forms.CheckBox();
			this.MaxClockSpeedCheckBox = new System.Windows.Forms.CheckBox();
			this.UpgradeTypeCheckBox = new System.Windows.Forms.CheckBox();
			this.ProcessorCheckBox = new System.Windows.Forms.CheckBox();
			this.ProcessorVersionCheckBox = new System.Windows.Forms.CheckBox();
			this.SharesDescriptionCheckBox = new System.Windows.Forms.CheckBox();
			this.PathCheckBox = new System.Windows.Forms.CheckBox();
			this.ShareStatusCheckBox = new System.Windows.Forms.CheckBox();
			this.ShareTypeCheckBox = new System.Windows.Forms.CheckBox();
			this.ProcessNameCheckBox = new System.Windows.Forms.CheckBox();
			this.ComputerSystemGroupBox.SuspendLayout();
			this.DiskGroupBox.SuspendLayout();
			this.NetworkConfigurationGroupBox.SuspendLayout();
			this.OperatingSystemGroupBox.SuspendLayout();
			this.SharesGroupBox.SuspendLayout();
			this.PrintersGroupBox.SuspendLayout();
			this.ProcessorsGroupBox.SuspendLayout();
			this.RunningProcessesGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// ComputerSystemGroupBox
			// 
			this.ComputerSystemGroupBox.Controls.Add(this.TotalMemoryCheckBox);
			this.ComputerSystemGroupBox.Controls.Add(this.ModelCheckBox);
			this.ComputerSystemGroupBox.Controls.Add(this.ManufacturerCheckBox);
			this.ComputerSystemGroupBox.Controls.Add(this.DomainCheckBox);
			this.ComputerSystemGroupBox.Location = new System.Drawing.Point(8, 280);
			this.ComputerSystemGroupBox.Name = "ComputerSystemGroupBox";
			this.ComputerSystemGroupBox.Size = new System.Drawing.Size(160, 128);
			this.ComputerSystemGroupBox.TabIndex = 0;
			this.ComputerSystemGroupBox.TabStop = false;
			this.ComputerSystemGroupBox.Text = "Computer System";
			// 
			// DomainCheckBox
			// 
			this.DomainCheckBox.Location = new System.Drawing.Point(8, 24);
			this.DomainCheckBox.Name = "DomainCheckBox";
			this.DomainCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DomainCheckBox.TabIndex = 0;
			this.DomainCheckBox.Text = "Domain";
			// 
			// ManufacturerCheckBox
			// 
			this.ManufacturerCheckBox.Location = new System.Drawing.Point(8, 48);
			this.ManufacturerCheckBox.Name = "ManufacturerCheckBox";
			this.ManufacturerCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ManufacturerCheckBox.TabIndex = 1;
			this.ManufacturerCheckBox.Text = "Manufacturer";
			// 
			// ModelCheckBox
			// 
			this.ModelCheckBox.Location = new System.Drawing.Point(8, 72);
			this.ModelCheckBox.Name = "ModelCheckBox";
			this.ModelCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ModelCheckBox.TabIndex = 2;
			this.ModelCheckBox.Text = "Model";
			// 
			// TotalMemoryCheckBox
			// 
			this.TotalMemoryCheckBox.Location = new System.Drawing.Point(8, 96);
			this.TotalMemoryCheckBox.Name = "TotalMemoryCheckBox";
			this.TotalMemoryCheckBox.Size = new System.Drawing.Size(96, 16);
			this.TotalMemoryCheckBox.TabIndex = 3;
			this.TotalMemoryCheckBox.Text = "Total Memory";
			// 
			// DiskGroupBox
			// 
			this.DiskGroupBox.Controls.Add(this.TypeCheckBox);
			this.DiskGroupBox.Controls.Add(this.FileSystemCheckBox);
			this.DiskGroupBox.Controls.Add(this.SizeCheckBox);
			this.DiskGroupBox.Controls.Add(this.DescriptionCheckBox);
			this.DiskGroupBox.Location = new System.Drawing.Point(184, 280);
			this.DiskGroupBox.Name = "DiskGroupBox";
			this.DiskGroupBox.Size = new System.Drawing.Size(160, 128);
			this.DiskGroupBox.TabIndex = 1;
			this.DiskGroupBox.TabStop = false;
			this.DiskGroupBox.Text = "Disks";
			// 
			// DescriptionCheckBox
			// 
			this.DescriptionCheckBox.Location = new System.Drawing.Point(8, 24);
			this.DescriptionCheckBox.Name = "DescriptionCheckBox";
			this.DescriptionCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DescriptionCheckBox.TabIndex = 0;
			this.DescriptionCheckBox.Text = "Description";
			// 
			// SizeCheckBox
			// 
			this.SizeCheckBox.Location = new System.Drawing.Point(8, 72);
			this.SizeCheckBox.Name = "SizeCheckBox";
			this.SizeCheckBox.Size = new System.Drawing.Size(104, 16);
			this.SizeCheckBox.TabIndex = 1;
			this.SizeCheckBox.Text = "Size";
			// 
			// FileSystemCheckBox
			// 
			this.FileSystemCheckBox.Location = new System.Drawing.Point(8, 48);
			this.FileSystemCheckBox.Name = "FileSystemCheckBox";
			this.FileSystemCheckBox.Size = new System.Drawing.Size(104, 16);
			this.FileSystemCheckBox.TabIndex = 2;
			this.FileSystemCheckBox.Text = "File System";
			// 
			// TypeCheckBox
			// 
			this.TypeCheckBox.Location = new System.Drawing.Point(8, 96);
			this.TypeCheckBox.Name = "TypeCheckBox";
			this.TypeCheckBox.Size = new System.Drawing.Size(104, 16);
			this.TypeCheckBox.TabIndex = 3;
			this.TypeCheckBox.Text = "Type";
			// 
			// NetworkConfigurationGroupBox
			// 
			this.NetworkConfigurationGroupBox.Controls.Add(this.WINSsecondaryServerCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.WINSprimaryServerCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.WINSlmhostLookupEnabledCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.WINShostLookupFileCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.MACaddressCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.IPsubnetCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.IPenabledCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.IPaddressCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.GatewayCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.DNSserverCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.DNShostNameCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.DNSdomainCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.DHCPserverCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.DHCPleaseObtainedCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.DHCPenabledCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.DHCPleaseExpiresCheckBox);
			this.NetworkConfigurationGroupBox.Controls.Add(this.DatabasePathCheckBox);
			this.NetworkConfigurationGroupBox.Location = new System.Drawing.Point(184, 8);
			this.NetworkConfigurationGroupBox.Name = "NetworkConfigurationGroupBox";
			this.NetworkConfigurationGroupBox.Size = new System.Drawing.Size(336, 264);
			this.NetworkConfigurationGroupBox.TabIndex = 2;
			this.NetworkConfigurationGroupBox.TabStop = false;
			this.NetworkConfigurationGroupBox.Text = "Network Configuration";
			// 
			// DatabasePathCheckBox
			// 
			this.DatabasePathCheckBox.Location = new System.Drawing.Point(8, 24);
			this.DatabasePathCheckBox.Name = "DatabasePathCheckBox";
			this.DatabasePathCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DatabasePathCheckBox.TabIndex = 0;
			this.DatabasePathCheckBox.Text = "Database Path";
			// 
			// DHCPleaseExpiresCheckBox
			// 
			this.DHCPleaseExpiresCheckBox.Location = new System.Drawing.Point(8, 72);
			this.DHCPleaseExpiresCheckBox.Name = "DHCPleaseExpiresCheckBox";
			this.DHCPleaseExpiresCheckBox.Size = new System.Drawing.Size(136, 16);
			this.DHCPleaseExpiresCheckBox.TabIndex = 1;
			this.DHCPleaseExpiresCheckBox.Text = "DHCP Lease Expires";
			// 
			// DHCPenabledCheckBox
			// 
			this.DHCPenabledCheckBox.Location = new System.Drawing.Point(8, 48);
			this.DHCPenabledCheckBox.Name = "DHCPenabledCheckBox";
			this.DHCPenabledCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DHCPenabledCheckBox.TabIndex = 2;
			this.DHCPenabledCheckBox.Text = "DHCP Enabled";
			// 
			// DHCPleaseObtainedCheckBox
			// 
			this.DHCPleaseObtainedCheckBox.Location = new System.Drawing.Point(8, 96);
			this.DHCPleaseObtainedCheckBox.Name = "DHCPleaseObtainedCheckBox";
			this.DHCPleaseObtainedCheckBox.Size = new System.Drawing.Size(144, 16);
			this.DHCPleaseObtainedCheckBox.TabIndex = 3;
			this.DHCPleaseObtainedCheckBox.Text = "DHCP Lease Obtained";
			// 
			// DHCPserverCheckBox
			// 
			this.DHCPserverCheckBox.Location = new System.Drawing.Point(8, 120);
			this.DHCPserverCheckBox.Name = "DHCPserverCheckBox";
			this.DHCPserverCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DHCPserverCheckBox.TabIndex = 4;
			this.DHCPserverCheckBox.Text = "DHCP Server";
			// 
			// DNSdomainCheckBox
			// 
			this.DNSdomainCheckBox.Location = new System.Drawing.Point(8, 144);
			this.DNSdomainCheckBox.Name = "DNSdomainCheckBox";
			this.DNSdomainCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DNSdomainCheckBox.TabIndex = 5;
			this.DNSdomainCheckBox.Text = "DNS Domain";
			// 
			// DNShostNameCheckBox
			// 
			this.DNShostNameCheckBox.Location = new System.Drawing.Point(8, 168);
			this.DNShostNameCheckBox.Name = "DNShostNameCheckBox";
			this.DNShostNameCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DNShostNameCheckBox.TabIndex = 6;
			this.DNShostNameCheckBox.Text = "DNS Host Name";
			// 
			// DNSserverCheckBox
			// 
			this.DNSserverCheckBox.Location = new System.Drawing.Point(8, 192);
			this.DNSserverCheckBox.Name = "DNSserverCheckBox";
			this.DNSserverCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DNSserverCheckBox.TabIndex = 7;
			this.DNSserverCheckBox.Text = "DNS Server";
			// 
			// GatewayCheckBox
			// 
			this.GatewayCheckBox.Location = new System.Drawing.Point(8, 216);
			this.GatewayCheckBox.Name = "GatewayCheckBox";
			this.GatewayCheckBox.Size = new System.Drawing.Size(104, 16);
			this.GatewayCheckBox.TabIndex = 8;
			this.GatewayCheckBox.Text = "Gateway";
			// 
			// IPaddressCheckBox
			// 
			this.IPaddressCheckBox.Location = new System.Drawing.Point(144, 24);
			this.IPaddressCheckBox.Name = "IPaddressCheckBox";
			this.IPaddressCheckBox.Size = new System.Drawing.Size(104, 16);
			this.IPaddressCheckBox.TabIndex = 9;
			this.IPaddressCheckBox.Text = "IP Address";
			// 
			// IPenabledCheckBox
			// 
			this.IPenabledCheckBox.Location = new System.Drawing.Point(144, 48);
			this.IPenabledCheckBox.Name = "IPenabledCheckBox";
			this.IPenabledCheckBox.Size = new System.Drawing.Size(104, 16);
			this.IPenabledCheckBox.TabIndex = 10;
			this.IPenabledCheckBox.Text = "IP Enabled";
			// 
			// IPsubnetCheckBox
			// 
			this.IPsubnetCheckBox.Location = new System.Drawing.Point(144, 72);
			this.IPsubnetCheckBox.Name = "IPsubnetCheckBox";
			this.IPsubnetCheckBox.Size = new System.Drawing.Size(104, 16);
			this.IPsubnetCheckBox.TabIndex = 11;
			this.IPsubnetCheckBox.Text = "IP Subnet";
			// 
			// MACaddressCheckBox
			// 
			this.MACaddressCheckBox.Location = new System.Drawing.Point(144, 96);
			this.MACaddressCheckBox.Name = "MACaddressCheckBox";
			this.MACaddressCheckBox.Size = new System.Drawing.Size(104, 16);
			this.MACaddressCheckBox.TabIndex = 12;
			this.MACaddressCheckBox.Text = "MAC Address";
			// 
			// WINShostLookupFileCheckBox
			// 
			this.WINShostLookupFileCheckBox.Location = new System.Drawing.Point(144, 120);
			this.WINShostLookupFileCheckBox.Name = "WINShostLookupFileCheckBox";
			this.WINShostLookupFileCheckBox.Size = new System.Drawing.Size(144, 16);
			this.WINShostLookupFileCheckBox.TabIndex = 13;
			this.WINShostLookupFileCheckBox.Text = "WINS Host Lookup File";
			// 
			// WINSlmhostLookupEnabledCheckBox
			// 
			this.WINSlmhostLookupEnabledCheckBox.Location = new System.Drawing.Point(144, 144);
			this.WINSlmhostLookupEnabledCheckBox.Name = "WINSlmhostLookupEnabledCheckBox";
			this.WINSlmhostLookupEnabledCheckBox.Size = new System.Drawing.Size(184, 16);
			this.WINSlmhostLookupEnabledCheckBox.TabIndex = 14;
			this.WINSlmhostLookupEnabledCheckBox.Text = "WINS LMHost Lookup Enabled";
			// 
			// WINSprimaryServerCheckBox
			// 
			this.WINSprimaryServerCheckBox.Location = new System.Drawing.Point(144, 168);
			this.WINSprimaryServerCheckBox.Name = "WINSprimaryServerCheckBox";
			this.WINSprimaryServerCheckBox.Size = new System.Drawing.Size(144, 16);
			this.WINSprimaryServerCheckBox.TabIndex = 15;
			this.WINSprimaryServerCheckBox.Text = "WINS Primary Server";
			// 
			// WINSsecondaryServerCheckBox
			// 
			this.WINSsecondaryServerCheckBox.Location = new System.Drawing.Point(144, 192);
			this.WINSsecondaryServerCheckBox.Name = "WINSsecondaryServerCheckBox";
			this.WINSsecondaryServerCheckBox.Size = new System.Drawing.Size(152, 16);
			this.WINSsecondaryServerCheckBox.TabIndex = 16;
			this.WINSsecondaryServerCheckBox.Text = "WINS Secondary Server";
			// 
			// OperatingSystemGroupBox
			// 
			this.OperatingSystemGroupBox.Controls.Add(this.WindowsDirectoryCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.VersionCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.ServicePacksCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.OSserialNumberCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.NameCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.LocalDateTimeCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.LastBootTimeCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.InstallDateCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.FreeVirtualMemoryCheckBox);
			this.OperatingSystemGroupBox.Controls.Add(this.FreePhysicalMemoryCheckBox);
			this.OperatingSystemGroupBox.Location = new System.Drawing.Point(8, 8);
			this.OperatingSystemGroupBox.Name = "OperatingSystemGroupBox";
			this.OperatingSystemGroupBox.Size = new System.Drawing.Size(160, 264);
			this.OperatingSystemGroupBox.TabIndex = 3;
			this.OperatingSystemGroupBox.TabStop = false;
			this.OperatingSystemGroupBox.Text = "Operating System";
			// 
			// FreePhysicalMemoryCheckBox
			// 
			this.FreePhysicalMemoryCheckBox.Location = new System.Drawing.Point(8, 24);
			this.FreePhysicalMemoryCheckBox.Name = "FreePhysicalMemoryCheckBox";
			this.FreePhysicalMemoryCheckBox.Size = new System.Drawing.Size(136, 16);
			this.FreePhysicalMemoryCheckBox.TabIndex = 0;
			this.FreePhysicalMemoryCheckBox.Text = "Free Physical Memory";
			// 
			// FreeVirtualMemoryCheckBox
			// 
			this.FreeVirtualMemoryCheckBox.Location = new System.Drawing.Point(8, 48);
			this.FreeVirtualMemoryCheckBox.Name = "FreeVirtualMemoryCheckBox";
			this.FreeVirtualMemoryCheckBox.Size = new System.Drawing.Size(128, 16);
			this.FreeVirtualMemoryCheckBox.TabIndex = 1;
			this.FreeVirtualMemoryCheckBox.Text = "Free Virtual Memory";
			// 
			// InstallDateCheckBox
			// 
			this.InstallDateCheckBox.Location = new System.Drawing.Point(8, 72);
			this.InstallDateCheckBox.Name = "InstallDateCheckBox";
			this.InstallDateCheckBox.Size = new System.Drawing.Size(104, 16);
			this.InstallDateCheckBox.TabIndex = 2;
			this.InstallDateCheckBox.Text = "Install Date";
			// 
			// LastBootTimeCheckBox
			// 
			this.LastBootTimeCheckBox.Location = new System.Drawing.Point(8, 96);
			this.LastBootTimeCheckBox.Name = "LastBootTimeCheckBox";
			this.LastBootTimeCheckBox.Size = new System.Drawing.Size(104, 16);
			this.LastBootTimeCheckBox.TabIndex = 3;
			this.LastBootTimeCheckBox.Text = "Last Boot Time";
			// 
			// LocalDateTimeCheckBox
			// 
			this.LocalDateTimeCheckBox.Location = new System.Drawing.Point(8, 120);
			this.LocalDateTimeCheckBox.Name = "LocalDateTimeCheckBox";
			this.LocalDateTimeCheckBox.Size = new System.Drawing.Size(112, 16);
			this.LocalDateTimeCheckBox.TabIndex = 4;
			this.LocalDateTimeCheckBox.Text = "Local Date & Time";
			// 
			// NameCheckBox
			// 
			this.NameCheckBox.Location = new System.Drawing.Point(8, 144);
			this.NameCheckBox.Name = "NameCheckBox";
			this.NameCheckBox.Size = new System.Drawing.Size(104, 16);
			this.NameCheckBox.TabIndex = 5;
			this.NameCheckBox.Text = "Name";
			// 
			// OSserialNumberCheckBox
			// 
			this.OSserialNumberCheckBox.Location = new System.Drawing.Point(8, 168);
			this.OSserialNumberCheckBox.Name = "OSserialNumberCheckBox";
			this.OSserialNumberCheckBox.Size = new System.Drawing.Size(120, 16);
			this.OSserialNumberCheckBox.TabIndex = 6;
			this.OSserialNumberCheckBox.Text = "OS Serial Number";
			// 
			// ServicePacksCheckBox
			// 
			this.ServicePacksCheckBox.Location = new System.Drawing.Point(8, 192);
			this.ServicePacksCheckBox.Name = "ServicePacksCheckBox";
			this.ServicePacksCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ServicePacksCheckBox.TabIndex = 7;
			this.ServicePacksCheckBox.Text = "Service Packs";
			// 
			// VersionCheckBox
			// 
			this.VersionCheckBox.Location = new System.Drawing.Point(8, 216);
			this.VersionCheckBox.Name = "VersionCheckBox";
			this.VersionCheckBox.Size = new System.Drawing.Size(104, 16);
			this.VersionCheckBox.TabIndex = 8;
			this.VersionCheckBox.Text = "Version";
			// 
			// WindowsDirectoryCheckBox
			// 
			this.WindowsDirectoryCheckBox.Location = new System.Drawing.Point(8, 240);
			this.WindowsDirectoryCheckBox.Name = "WindowsDirectoryCheckBox";
			this.WindowsDirectoryCheckBox.Size = new System.Drawing.Size(120, 16);
			this.WindowsDirectoryCheckBox.TabIndex = 9;
			this.WindowsDirectoryCheckBox.Text = "Windows Directory";
			// 
			// SharesGroupBox
			// 
			this.SharesGroupBox.Controls.Add(this.SharesDescriptionCheckBox);
			this.SharesGroupBox.Controls.Add(this.PathCheckBox);
			this.SharesGroupBox.Controls.Add(this.ShareTypeCheckBox);
			this.SharesGroupBox.Controls.Add(this.ShareStatusCheckBox);
			this.SharesGroupBox.Location = new System.Drawing.Point(360, 280);
			this.SharesGroupBox.Name = "SharesGroupBox";
			this.SharesGroupBox.Size = new System.Drawing.Size(160, 128);
			this.SharesGroupBox.TabIndex = 4;
			this.SharesGroupBox.TabStop = false;
			this.SharesGroupBox.Text = "Shares";
			// 
			// PrintersGroupBox
			// 
			this.PrintersGroupBox.Controls.Add(this.StatusCheckBox);
			this.PrintersGroupBox.Controls.Add(this.StateCheckBox);
			this.PrintersGroupBox.Controls.Add(this.ShareNameCheckBox);
			this.PrintersGroupBox.Controls.Add(this.ServerNameCheckBox);
			this.PrintersGroupBox.Controls.Add(this.ResolutionCheckBox);
			this.PrintersGroupBox.Controls.Add(this.DatatypeCheckBox);
			this.PrintersGroupBox.Location = new System.Drawing.Point(8, 416);
			this.PrintersGroupBox.Name = "PrintersGroupBox";
			this.PrintersGroupBox.Size = new System.Drawing.Size(160, 168);
			this.PrintersGroupBox.TabIndex = 5;
			this.PrintersGroupBox.TabStop = false;
			this.PrintersGroupBox.Text = "Printers";
			// 
			// ProcessorsGroupBox
			// 
			this.ProcessorsGroupBox.Controls.Add(this.ProcessorVersionCheckBox);
			this.ProcessorsGroupBox.Controls.Add(this.ProcessorCheckBox);
			this.ProcessorsGroupBox.Controls.Add(this.UpgradeTypeCheckBox);
			this.ProcessorsGroupBox.Controls.Add(this.MaxClockSpeedCheckBox);
			this.ProcessorsGroupBox.Controls.Add(this.L2CacheSizeCheckBox);
			this.ProcessorsGroupBox.Location = new System.Drawing.Point(184, 416);
			this.ProcessorsGroupBox.Name = "ProcessorsGroupBox";
			this.ProcessorsGroupBox.Size = new System.Drawing.Size(160, 168);
			this.ProcessorsGroupBox.TabIndex = 6;
			this.ProcessorsGroupBox.TabStop = false;
			this.ProcessorsGroupBox.Text = "Processors";
			// 
			// RunningProcessesGroupBox
			// 
			this.RunningProcessesGroupBox.Controls.Add(this.ProcessNameCheckBox);
			this.RunningProcessesGroupBox.Location = new System.Drawing.Point(360, 416);
			this.RunningProcessesGroupBox.Name = "RunningProcessesGroupBox";
			this.RunningProcessesGroupBox.Size = new System.Drawing.Size(160, 168);
			this.RunningProcessesGroupBox.TabIndex = 7;
			this.RunningProcessesGroupBox.TabStop = false;
			this.RunningProcessesGroupBox.Text = "Running Processes";
			// 
			// DatatypeCheckBox
			// 
			this.DatatypeCheckBox.Location = new System.Drawing.Point(8, 24);
			this.DatatypeCheckBox.Name = "DatatypeCheckBox";
			this.DatatypeCheckBox.Size = new System.Drawing.Size(104, 16);
			this.DatatypeCheckBox.TabIndex = 0;
			this.DatatypeCheckBox.Text = "Datatype";
			// 
			// ResolutionCheckBox
			// 
			this.ResolutionCheckBox.Location = new System.Drawing.Point(8, 48);
			this.ResolutionCheckBox.Name = "ResolutionCheckBox";
			this.ResolutionCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ResolutionCheckBox.TabIndex = 1;
			this.ResolutionCheckBox.Text = "Resolution";
			// 
			// ServerNameCheckBox
			// 
			this.ServerNameCheckBox.Location = new System.Drawing.Point(8, 72);
			this.ServerNameCheckBox.Name = "ServerNameCheckBox";
			this.ServerNameCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ServerNameCheckBox.TabIndex = 2;
			this.ServerNameCheckBox.Text = "Server Name";
			// 
			// ShareNameCheckBox
			// 
			this.ShareNameCheckBox.Location = new System.Drawing.Point(8, 96);
			this.ShareNameCheckBox.Name = "ShareNameCheckBox";
			this.ShareNameCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ShareNameCheckBox.TabIndex = 3;
			this.ShareNameCheckBox.Text = "Share Name";
			// 
			// StateCheckBox
			// 
			this.StateCheckBox.Location = new System.Drawing.Point(8, 120);
			this.StateCheckBox.Name = "StateCheckBox";
			this.StateCheckBox.Size = new System.Drawing.Size(104, 16);
			this.StateCheckBox.TabIndex = 4;
			this.StateCheckBox.Text = "State";
			// 
			// StatusCheckBox
			// 
			this.StatusCheckBox.Location = new System.Drawing.Point(8, 144);
			this.StatusCheckBox.Name = "StatusCheckBox";
			this.StatusCheckBox.Size = new System.Drawing.Size(104, 16);
			this.StatusCheckBox.TabIndex = 5;
			this.StatusCheckBox.Text = "Status";
			// 
			// L2CacheSizeCheckBox
			// 
			this.L2CacheSizeCheckBox.Location = new System.Drawing.Point(8, 24);
			this.L2CacheSizeCheckBox.Name = "L2CacheSizeCheckBox";
			this.L2CacheSizeCheckBox.Size = new System.Drawing.Size(104, 16);
			this.L2CacheSizeCheckBox.TabIndex = 0;
			this.L2CacheSizeCheckBox.Text = "L2 Cache Size";
			// 
			// MaxClockSpeedCheckBox
			// 
			this.MaxClockSpeedCheckBox.Location = new System.Drawing.Point(8, 48);
			this.MaxClockSpeedCheckBox.Name = "MaxClockSpeedCheckBox";
			this.MaxClockSpeedCheckBox.Size = new System.Drawing.Size(104, 16);
			this.MaxClockSpeedCheckBox.TabIndex = 1;
			this.MaxClockSpeedCheckBox.Text = "Max Clock Speed";
			// 
			// UpgradeTypeCheckBox
			// 
			this.UpgradeTypeCheckBox.Location = new System.Drawing.Point(8, 96);
			this.UpgradeTypeCheckBox.Name = "UpgradeTypeCheckBox";
			this.UpgradeTypeCheckBox.Size = new System.Drawing.Size(104, 16);
			this.UpgradeTypeCheckBox.TabIndex = 2;
			this.UpgradeTypeCheckBox.Text = "Upgrade Type";
			// 
			// ProcessorCheckBox
			// 
			this.ProcessorCheckBox.Location = new System.Drawing.Point(8, 72);
			this.ProcessorCheckBox.Name = "ProcessorCheckBox";
			this.ProcessorCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ProcessorCheckBox.TabIndex = 3;
			this.ProcessorCheckBox.Text = "Processor";
			// 
			// ProcessorVersionCheckBox
			// 
			this.ProcessorVersionCheckBox.Location = new System.Drawing.Point(8, 120);
			this.ProcessorVersionCheckBox.Name = "ProcessorVersionCheckBox";
			this.ProcessorVersionCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ProcessorVersionCheckBox.TabIndex = 4;
			this.ProcessorVersionCheckBox.Text = "Version";
			// 
			// SharesDescriptionCheckBox
			// 
			this.SharesDescriptionCheckBox.Location = new System.Drawing.Point(8, 24);
			this.SharesDescriptionCheckBox.Name = "SharesDescriptionCheckBox";
			this.SharesDescriptionCheckBox.Size = new System.Drawing.Size(104, 16);
			this.SharesDescriptionCheckBox.TabIndex = 0;
			this.SharesDescriptionCheckBox.Text = "Description";
			// 
			// PathCheckBox
			// 
			this.PathCheckBox.Location = new System.Drawing.Point(8, 48);
			this.PathCheckBox.Name = "PathCheckBox";
			this.PathCheckBox.Size = new System.Drawing.Size(104, 16);
			this.PathCheckBox.TabIndex = 1;
			this.PathCheckBox.Text = "Path";
			// 
			// ShareStatusCheckBox
			// 
			this.ShareStatusCheckBox.Location = new System.Drawing.Point(8, 72);
			this.ShareStatusCheckBox.Name = "ShareStatusCheckBox";
			this.ShareStatusCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ShareStatusCheckBox.TabIndex = 2;
			this.ShareStatusCheckBox.Text = "Status";
			// 
			// ShareTypeCheckBox
			// 
			this.ShareTypeCheckBox.Location = new System.Drawing.Point(8, 96);
			this.ShareTypeCheckBox.Name = "ShareTypeCheckBox";
			this.ShareTypeCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ShareTypeCheckBox.TabIndex = 3;
			this.ShareTypeCheckBox.Text = "Type";
			// 
			// ProcessNameCheckBox
			// 
			this.ProcessNameCheckBox.Location = new System.Drawing.Point(8, 24);
			this.ProcessNameCheckBox.Name = "ProcessNameCheckBox";
			this.ProcessNameCheckBox.Size = new System.Drawing.Size(104, 16);
			this.ProcessNameCheckBox.TabIndex = 0;
			this.ProcessNameCheckBox.Text = "Name";
			// 
			// ComputerPropertyOptions
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 597);
			this.Controls.Add(this.RunningProcessesGroupBox);
			this.Controls.Add(this.ProcessorsGroupBox);
			this.Controls.Add(this.PrintersGroupBox);
			this.Controls.Add(this.SharesGroupBox);
			this.Controls.Add(this.OperatingSystemGroupBox);
			this.Controls.Add(this.NetworkConfigurationGroupBox);
			this.Controls.Add(this.DiskGroupBox);
			this.Controls.Add(this.ComputerSystemGroupBox);
			this.Name = "ComputerPropertyOptions";
			this.Text = "ComputerPropertyOptions";
			this.ComputerSystemGroupBox.ResumeLayout(false);
			this.DiskGroupBox.ResumeLayout(false);
			this.NetworkConfigurationGroupBox.ResumeLayout(false);
			this.OperatingSystemGroupBox.ResumeLayout(false);
			this.SharesGroupBox.ResumeLayout(false);
			this.PrintersGroupBox.ResumeLayout(false);
			this.ProcessorsGroupBox.ResumeLayout(false);
			this.RunningProcessesGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
