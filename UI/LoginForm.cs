using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            tbxUsername.Clear();
            tbxPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var result = _booksManager.GetAll().FirstOrDefault(l => l.Name == tbxUsername.Text && l.Password == tbxPassword.Text);
            if (tbxUsername.Text == "" || tbxPassword.Text == "")
                MessageBox.Show("Please fill out username and password");
            else if (tbxUsername.Text == "Admin" && tbxPassword.Text == "12345")
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Username or password were incorret");
        }
    }
}
