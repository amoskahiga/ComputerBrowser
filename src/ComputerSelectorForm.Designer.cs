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
    partial class ComputerSelectorForm
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
            this.domianLabel = new System.Windows.Forms.Label();
            this.domainNameTextBox = new System.Windows.Forms.TextBox();
            this.listComputersButton = new System.Windows.Forms.Button();
            this.computerTreeView = new System.Windows.Forms.TreeView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domianLabel
            // 
            this.domianLabel.AutoSize = true;
            this.domianLabel.Location = new System.Drawing.Point(12, 17);
            this.domianLabel.Name = "domianLabel";
            this.domianLabel.Size = new System.Drawing.Size(46, 13);
            this.domianLabel.TabIndex = 0;
            this.domianLabel.Text = "Domain:";
            // 
            // domainNameTextBox
            // 
            this.domainNameTextBox.Location = new System.Drawing.Point(64, 14);
            this.domainNameTextBox.Name = "domainNameTextBox";
            this.domainNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.domainNameTextBox.TabIndex = 1;
            // 
            // listComputersButton
            // 
            this.listComputersButton.Location = new System.Drawing.Point(208, 12);
            this.listComputersButton.Name = "listComputersButton";
            this.listComputersButton.Size = new System.Drawing.Size(91, 23);
            this.listComputersButton.TabIndex = 2;
            this.listComputersButton.Text = "List Computers";
            this.listComputersButton.UseVisualStyleBackColor = true;
            this.listComputersButton.Click += new System.EventHandler(this.listComputersButton_Click);
            // 
            // computerTreeView
            // 
            this.computerTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.computerTreeView.CheckBoxes = true;
            this.computerTreeView.Location = new System.Drawing.Point(15, 40);
            this.computerTreeView.Name = "computerTreeView";
            this.computerTreeView.Size = new System.Drawing.Size(284, 221);
            this.computerTreeView.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(224, 267);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Location = new System.Drawing.Point(143, 267);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ComputerSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(311, 296);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.computerTreeView);
            this.Controls.Add(this.listComputersButton);
            this.Controls.Add(this.domainNameTextBox);
            this.Controls.Add(this.domianLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(319, 323);
            this.Name = "ComputerSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Computer(s)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label domianLabel;
        private System.Windows.Forms.TextBox domainNameTextBox;
        private System.Windows.Forms.Button listComputersButton;
        private System.Windows.Forms.TreeView computerTreeView;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}