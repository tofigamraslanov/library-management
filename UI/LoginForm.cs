using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        readonly LibrarianManager _librarianManager = new LibrarianManager(new EfLibrarianDal());
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = _librarianManager.GetAll().FirstOrDefault(l => l.Name == tbxUsername.Text && l.Password == tbxPassword.Text);
            if (tbxUsername.Text == "" || tbxPassword.Text == "")
                MessageBox.Show(@"Please fill out username and password");
            else if (result != null && tbxUsername.Text == result.Name && tbxPassword.Text == result.Password)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show(@"Username or password were incorrect");
        }

        private void cbxShowOrHide_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = !cbxShowOrHide.Checked;
        }

        private void lblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
        }
    }
}
