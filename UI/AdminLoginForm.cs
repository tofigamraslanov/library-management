using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
                MessageBox.Show(@"Please fill out password");
            else if (tbxPassword.Text == @"Admin")
            {
                this.Hide();
                var librarianForm = new LibrarianForm();
                librarianForm.Show();
            }
        }

        private void cbxShowOrHideAdmin_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = !cbxShowOrHideAdmin.Checked;
        }
    }
}
