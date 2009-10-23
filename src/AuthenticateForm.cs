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
	/// Summary description for AuthenticateAs.
	/// </summary>
	public class AuthenticateForm : System.Windows.Forms.Form {
		private System.Windows.Forms.Label UserNameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Button Submit;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private String Username;
		private String Password;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AuthenticateForm() {
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
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
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
		private void InitializeComponent() {
			this.UserNameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.Submit = new System.Windows.Forms.Button();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// UserNameLabel
			// 
			this.UserNameLabel.Location = new System.Drawing.Point(22, 8);
			this.UserNameLabel.Name = "UserNameLabel";
			this.UserNameLabel.Size = new System.Drawing.Size(84, 24);
			this.UserNameLabel.TabIndex = 0;
			this.UserNameLabel.Text = "UserName";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.Location = new System.Drawing.Point(22, 48);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(84, 24);
			this.PasswordLabel.TabIndex = 1;
			this.PasswordLabel.Text = "Password";
			// 
			// Submit
			// 
			this.Submit.Location = new System.Drawing.Point(26, 85);
			this.Submit.Name = "Submit";
			this.Submit.Size = new System.Drawing.Size(80, 24);
			this.Submit.TabIndex = 2;
			this.Submit.Text = "Submit";
			this.Submit.Click += new System.EventHandler(this.Submit_Click);
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Location = new System.Drawing.Point(130, 8);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(112, 20);
			this.UsernameTextBox.TabIndex = 3;
			this.UsernameTextBox.Text = "";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(130, 48);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(112, 20);
			this.PasswordTextBox.TabIndex = 4;
			this.PasswordTextBox.Text = "";
			// 
			// AuthenticateForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 117);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.Submit);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UserNameLabel);
			this.Name = "AuthenticateForm";
			this.Text = "AuthenticateAs";
			this.ResumeLayout(false);

		}
		#endregion

		private void Submit_Click(object sender, System.EventArgs e) {
			Username = UsernameTextBox.Text;
			Password = PasswordTextBox.Text;
			this.Close();
		}

		public String getUsername(){
			return this.Username;
		}

		public String getPassword(){
			return this.Password;
		}
	}
}
