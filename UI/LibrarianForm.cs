using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LibrarianForm : Form
    {
        readonly LibrarianManager _booksManager = new LibrarianManager(new EfLibrarianDal());
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
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            LoadLibrarians();
            cbFilterLibrarians.Text = @"Select column which you want to search by";
        }

        private void LoadLibrarians()
        {
            dgwLibrarians.DataSource = _booksManager.GetAll();
            dgwLibrarians.ClearSelection();
        }

        private void ClearInputs()
        {
            tbxName.Clear();
            tbxPassword.Clear();
            tbxPhone.Clear();
        }

        private void dgwLibrarians_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwLibrarians.CurrentRow != null)
            {
                tbxName.Text = dgwLibrarians.CurrentRow.Cells[1].Value.ToString();
                tbxPassword.Text = dgwLibrarians.CurrentRow.Cells[2].Value.ToString();
                tbxPhone.Text = dgwLibrarians.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxPassword.Text == "" || tbxPhone.Text == "")
            {
                MessageBox.Show(@"Please fill out inputs");
            }
            else
            {
                _booksManager.Add(new Librarian
                {
                    Name = tbxName.Text,
                    Phone = tbxPhone.Text,
                    Password = tbxPassword.Text
                });
                ClearInputs();
                LoadLibrarians();
                MessageBox.Show(@"Librarian Successfully Added!");
            }
        }

        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxPassword.Text == "" || tbxPhone.Text == "")
                MessageBox.Show(@"Please select a row which you want to update then update them");
            else
            {
                if (dgwLibrarians.CurrentRow != null)
                    _booksManager.Update(new Librarian
                    {
                        Id = Convert.ToInt32(dgwLibrarians.CurrentRow.Cells[0].Value),
                        Name = tbxName.Text,
                        Password = tbxPassword.Text,
                        Phone = tbxPhone.Text
                    });
                ClearInputs();
                LoadLibrarians();
                MessageBox.Show(@"Librarian Successfully Updated!");
            }
        }

        private void btnDeleteLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxPassword.Text == "" || tbxPhone.Text == "")
                MessageBox.Show(@"Please select a row which you want to delete then delete it");
            else
            {
                _booksManager.Delete(new Librarian
                {
                    Id = Convert.ToInt32(dgwLibrarians.CurrentRow?.Cells[0].Value)
                });
                ClearInputs();
                LoadLibrarians();
                MessageBox.Show(@"Librarian Successfully Deleted!");
            }
        }

        private void tbxSearchLibrarians_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearchLibrarians.Text;
            if (string.IsNullOrEmpty(key))
                LoadLibrarians();
            else
            {
                if (cbFilterLibrarians.Text == @"Search by Name")
                {
                    dgwLibrarians.DataSource = _booksManager.GetByName(key);
                    dgwLibrarians.ClearSelection();
                }
            }
        }

        private void dgwLibrarians_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
                e.Value = new string('*', e.Value.ToString().Length);
        }
    }
}
