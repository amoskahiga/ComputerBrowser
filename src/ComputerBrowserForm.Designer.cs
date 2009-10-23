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

namespace ComputerBrowser
{
    partial class ComputerBrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.getPropertiesButton = new System.Windows.Forms.Button();
            this.computerNamesTextBox = new System.Windows.Forms.TextBox();
            this.clearViewButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.optionsMenuItem = new System.Windows.Forms.MenuItem();
            this.authenticateAsMenuItem = new System.Windows.Forms.MenuItem();
            this.propertiesMenuItem = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.computerNamesLabel = new System.Windows.Forms.Label();
            this.computerTreeView = new System.Windows.Forms.TreeView();
            this.browseButton = new System.Windows.Forms.Button();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // getPropertiesButton
            // 
            this.getPropertiesButton.Location = new System.Drawing.Point(115, 38);
            this.getPropertiesButton.Name = "getPropertiesButton";
            this.getPropertiesButton.Size = new System.Drawing.Size(90, 23);
            this.getPropertiesButton.TabIndex = 3;
            this.getPropertiesButton.Text = "Get Properties";
            this.getPropertiesButton.Click += new System.EventHandler(this.getPropertiesButton_Click);
            // 
            // computerNamesTextBox
            // 
            this.computerNamesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.computerNamesTextBox.Location = new System.Drawing.Point(115, 12);
            this.computerNamesTextBox.Name = "computerNamesTextBox";
            this.computerNamesTextBox.Size = new System.Drawing.Size(225, 20);
            this.computerNamesTextBox.TabIndex = 1;
            this.computerNamesTextBox.Text = "Enter Computer Names (comma separated)";
            // 
            // clearViewButton
            // 
            this.clearViewButton.Location = new System.Drawing.Point(211, 38);
            this.clearViewButton.Name = "clearViewButton";
            this.clearViewButton.Size = new System.Drawing.Size(90, 23);
            this.clearViewButton.TabIndex = 4;
            this.clearViewButton.Text = "Clear View";
            this.clearViewButton.Click += new System.EventHandler(this.clearViewButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.optionsMenuItem,
            this.helpMenuItem});
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.saveAsMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Enabled = false;
            this.saveAsMenuItem.Index = 0;
            this.saveAsMenuItem.Text = "Save As...";
            this.saveAsMenuItem.Visible = false;
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 1;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Index = 1;
            this.optionsMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.authenticateAsMenuItem,
            this.propertiesMenuItem});
            this.optionsMenuItem.Text = "Options";
            this.optionsMenuItem.Visible = false;
            // 
            // authenticateAsMenuItem
            // 
            this.authenticateAsMenuItem.Enabled = false;
            this.authenticateAsMenuItem.Index = 0;
            this.authenticateAsMenuItem.Text = "Authenticate As...";
            // 
            // propertiesMenuItem
            // 
            this.propertiesMenuItem.Enabled = false;
            this.propertiesMenuItem.Index = 1;
            this.propertiesMenuItem.Text = "Properties...";
            this.propertiesMenuItem.Visible = false;
            this.propertiesMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 410);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(433, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "Ready";
            // 
            // computerNamesLabel
            // 
            this.computerNamesLabel.AutoSize = true;
            this.computerNamesLabel.Location = new System.Drawing.Point(12, 15);
            this.computerNamesLabel.Name = "computerNamesLabel";
            this.computerNamesLabel.Size = new System.Drawing.Size(97, 13);
            this.computerNamesLabel.TabIndex = 6;
            this.computerNamesLabel.Text = "Computer Name(s):";
            // 
            // computerTreeView
            // 
            this.computerTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.computerTreeView.Location = new System.Drawing.Point(12, 67);
            this.computerTreeView.Name = "computerTreeView";
            this.computerTreeView.Size = new System.Drawing.Size(328, 317);
            this.computerTreeView.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(346, 10);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 2;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 0;
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // ComputerBrowserForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(433, 432);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.computerTreeView);
            this.Controls.Add(this.computerNamesLabel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.clearViewButton);
            this.Controls.Add(this.computerNamesTextBox);
            this.Controls.Add(this.getPropertiesButton);
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(441, 459);
            this.Name = "ComputerBrowserForm";
            this.Text = "ComputerBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getPropertiesButton;
        private System.Windows.Forms.TextBox computerNamesTextBox;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem optionsMenuItem;
        private System.Windows.Forms.MenuItem saveAsMenuItem;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.Button clearViewButton;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuItem propertiesMenuItem;
        private System.Windows.Forms.MenuItem authenticateAsMenuItem;
        private System.Windows.Forms.Label computerNamesLabel;
        private System.Windows.Forms.TreeView computerTreeView;
        private System.Windows.Forms.MenuItem helpMenuItem;
        private System.Windows.Forms.MenuItem aboutMenuItem;
    }
}