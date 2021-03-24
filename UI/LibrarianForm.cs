using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class LibrarianForm : Form
    {
        LibrarianManager _librarianManager = new LibrarianManager(new EfLibrarianDal());
        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToHomeFromLibrarians_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            LoadLibrarians();
        }

        private void LoadLibrarians()
        {
            dgwLibrarians.DataSource = _librarianManager.GetAll();
            dgwLibrarians.ClearSelection();
        }

        private void ClearInputs()
        {
            tbxName.Clear();
            tbxPassword.Clear();
            tbxPhone.Clear();
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxPassword.Text == "" || tbxPhone.Text == "")
            {
                MessageBox.Show("Please fill out text box");
            }
            else
            {
                _librarianManager.Add(new Librarian
                {
                    Name = tbxName.Text,
                    Phone = tbxPhone.Text,
                    Password = tbxPassword.Text
                });
                ClearInputs();
                LoadLibrarians();
                MessageBox.Show("Librarian added Successfully");
            }
        }

        private void dgwLibrarians_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwLibrarians.CurrentRow.Cells[1].Value.ToString();
            tbxPassword.Text = dgwLibrarians.CurrentRow.Cells[2].Value.ToString();
            tbxPhone.Text = dgwLibrarians.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxPassword.Text == "" || tbxPhone.Text == "")
                MessageBox.Show("Please select row which you want to update then update them");
            else
            {
                _librarianManager.Update(new Librarian
                {
                    Id = Convert.ToInt32(dgwLibrarians.CurrentRow.Cells[0].Value),
                    Name = tbxName.Text,
                    Password = tbxPassword.Text,
                    Phone = tbxPhone.Text
                });
                ClearInputs();
                LoadLibrarians();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btnDeleteLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxPassword.Text == "" || tbxPhone.Text == "")
                MessageBox.Show("Please select row which you want to delete then delete it");
            else
            {
                _librarianManager.Delete(new Librarian
                {
                    Id = Convert.ToInt32(dgwLibrarians.CurrentRow.Cells[0].Value)
                });
                ClearInputs();
                LoadLibrarians();
                MessageBox.Show("Deleted Successfully");
            }
        }
    }
}
