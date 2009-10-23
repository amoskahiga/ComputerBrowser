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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComputerBrowser
{
    public partial class ComputerSelectorForm : Form
    {
        List<string> computerNames;

        public ComputerSelectorForm(List<string> computerNames)
        {
            this.computerNames = computerNames;

            InitializeComponent();

            // Add each entered computer name to the TreeView
            foreach (string computerName in computerNames)
            {
                TreeNode node = new TreeNode(computerName);
                node.Checked = true;
                computerTreeView.Nodes.Add(node);
            }
        }

        private void queryDomainWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string domainName = e.Argument as string;
            System.DirectoryServices.DirectoryEntry directoryEntry = new System.DirectoryServices.DirectoryEntry();
            directoryEntry.Path = "WinNT://" + domainName;

            List<string> domainComputerNames = new List<string>();

            foreach (System.DirectoryServices.DirectoryEntry child in directoryEntry.Children)
            {
                switch (child.SchemaClassName)
                {
                    case "Computer":
                        domainComputerNames.Add(child.Name);
                        break;
                }
            }

            e.Result = domainComputerNames;
        }

        private void queryDomainWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show("An error occured while querying the domain.  " +
                      "Please verify that the Domain name specified is valid.", "Domain Query Failed",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);

                domainNameTextBox.Focus();
                domainNameTextBox.SelectAll();
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                TreeNode ComputerNode = new TreeNode();
                ComputerNode.Nodes.Add("Operation canceled");
                ComputerNode.ForeColor = Color.Red;
                computerTreeView.Nodes.Add(ComputerNode);
            }
            else
            {
                List<string> domainComputerNames = e.Result as List<string>;

                // Add each computer name to the TreeView
                foreach (string computerName in domainComputerNames)
                {
                    TreeNode node = new TreeNode(computerName);
                    computerTreeView.Nodes.Add(node);
                }
            }

            listComputersButton.Enabled = true;
        }

        private void listComputersButton_Click(object sender, EventArgs e)
        {
            listComputersButton.Enabled = false;

            // Get the list of computers in the domain asynchronously
            BackgroundWorker queryDomainWorker = new BackgroundWorker();
            queryDomainWorker.DoWork += new DoWorkEventHandler(queryDomainWorker_DoWork);
            queryDomainWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(queryDomainWorker_RunWorkerCompleted);
            queryDomainWorker.RunWorkerAsync(domainNameTextBox.Text.Trim());
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            // Add any checked tree nodes to the list
            computerNames.Clear();
            foreach (TreeNode node in computerTreeView.Nodes)
            {
                if (node.Checked)
                {
                    computerNames.Add(node.Text);
                }
            }
            Close();
        }
    }
}
