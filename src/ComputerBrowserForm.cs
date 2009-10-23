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
using System.Configuration;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using ComputerBrowser.ComputerSystem;
using System.ComponentModel;

namespace ComputerBrowser
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class ComputerBrowserForm : Form
    {
        private int computerCount = 0;
        private Button browseButton;
        private List<Computer> computerList;    // List of succesfully queried computers

        /// <summary>
        /// Constructor
        /// </summary>
        public ComputerBrowserForm()
        {
            //
            // Required for Windows Form Designer support
            //		
            InitializeComponent();

            computerList = new List<Computer>();
            computerTreeView.Sorted = true;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new ComputerBrowserForm());
        }

        /// <summary>
        /// Gets the properties of all the computers in the list.  It starts an asynchronous
        /// background thread to query and display the results.
        /// </summary>
        /// <param name="computerNames"></param>
        private void GetComputers(List<string> computerNames)
        {
            foreach (string computerName in computerNames)
            {
                ++this.computerCount;
                BackgroundWorker queryComputerWorker = new BackgroundWorker();
                queryComputerWorker.DoWork += new DoWorkEventHandler(queryComputerWorker_DoWork);
                queryComputerWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(queryComputerWorker_RunWorkerCompleted);
                queryComputerWorker.RunWorkerAsync(computerName);
            }
        }

        /// <summary>
        /// Queries the specified computer for its properties using the WMI interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Contains the name of the computer name to query (Argument)</param>
        protected void queryComputerWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string computerName = e.Argument as string;
            ComputerSystem.Computer Computer = ComputerFacade.GetComputer(computerName);
            e.Result = Computer;
        }

        /// <summary>
        /// Updates the UI with the results of the computer query.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Contains the computer object containing the results of the resulting query (Argument)</param>
        protected void queryComputerWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                TreeNode ComputerNode = new TreeNode();
                ComputerNode.Nodes.Add(e.Error.Message);
                ComputerNode.ForeColor = Color.Red;
                computerTreeView.Nodes.Add(ComputerNode);
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
                // Finally, handle the case where the operation succeeded.
                Computer computer = e.Result as Computer;
                ComputerView.AddComputerToView(computerTreeView, computer);
                computerList.Add(computer);
            }

            // Update status bar and renable button
            --computerCount;
            if (this.computerCount == 0)
            {
                getPropertiesButton.Enabled = true;
                clearViewButton.Enabled = true;
                statusBar.Text = "Ready";
            }
        }


        #region Event handlers for form controls

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getPropertiesButton_Click(object sender, EventArgs e)
        {
            if (computerNamesTextBox.Text.Contains("Enter Computer Name"))
            {
                computerNamesTextBox.Focus();
                computerNamesTextBox.SelectAll();
            }
            else
            {
                List<string> computerNames = new List<string>();

                foreach (string computerName in computerNamesTextBox.Text.Split(','))
                {
                    if (computerName.Trim().Length > 0)
                    {
                        computerNames.Add(computerName.Trim());
                    }
                }

                //Disable action buttons until action completed
                getPropertiesButton.Enabled = false;
                clearViewButton.Enabled = false;

                statusBar.Text = "Please wait...";

                // Query and display the computer(s) properties
                GetComputers(computerNames);
            }
        }

        private void clearViewButton_Click(object sender, EventArgs e)
        {
            computerTreeView.Nodes.Clear();
            computerList.Clear();
        }

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
            ComputerPropertyOptions options = new ComputerPropertyOptions();
            options.ShowDialog();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            List<string> computerNames = new List<string>();


            // Get any user specified computer names if the user has entered any
            if (!computerNamesTextBox.Text.Contains("Enter Computer Name"))
            {
                foreach (string computerName in computerNamesTextBox.Text.Split(','))
                {
                    if (computerName.Trim().Length > 0)
                    {
                        computerNames.Add(computerName.Trim());
                    }
                }
            }

            ComputerSelectorForm computerSelectorForm = new ComputerSelectorForm(computerNames);
            computerSelectorForm.ShowDialog();

            // Set any user specified computer names if the user has selected
            computerNamesTextBox.Text = ""; // Clear the current names
            foreach (string computerName in computerNames)
            {
                computerNamesTextBox.Text += computerName + ", ";
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutBox = new AboutForm();
            aboutBox.ShowDialog();
        }

        #endregion

        
    }
}
