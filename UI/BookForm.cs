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
using System.Windows.Forms;

namespace UI
{
    public partial class BookForm : Form
    {
        BookManager _bookManager = new BookManager(new EfBookDal());
        public BookForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToHomeFromBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            cbFilterBooks.Text = "Select column which you want to search by";
        }

        private void LoadBooks()
        {
            dgwBooks.DataSource = _bookManager.GetAll();
            dgwBooks.ClearSelection();
        }

        public void ClearInputs()
        {
            tbxName.Clear();
            tbxAuthor.Clear();
            tbxPrice.Clear();
            tbxQuantity.Clear();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxAuthor.Text == "" || dtpPublishDate.Value == null || tbxPrice.Text == "" || tbxQuantity.Text == "")
                MessageBox.Show("Please fill out inputs");
            else
            {
                _bookManager.Add(new Book
                {
                    Name = tbxName.Text,
                    Author = tbxAuthor.Text,
                    PublishDate = dtpPublishDate.Value,
                    Price = Convert.ToDecimal(tbxPrice.Text),
                    Quantity = Convert.ToInt32(tbxQuantity.Text)
                });
                ClearInputs();
                LoadBooks();
                MessageBox.Show("Added Successfully");
            }
        }

        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            tbxAuthor.Text = dgwBooks.CurrentRow.Cells[2].Value.ToString();
            dtpPublishDate.Value = Convert.ToDateTime(dgwBooks.CurrentRow.Cells[3].Value);
            tbxPrice.Text = dgwBooks.CurrentRow.Cells[4].Value.ToString();
            tbxQuantity.Text = dgwBooks.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxAuthor.Text == "" || dtpPublishDate.Value == null || tbxPrice.Text == "" || tbxQuantity.Text == "")
                MessageBox.Show("Please select row which you want to update then update them");
            else
            {
                _bookManager.Update(new Book
                {
                    Id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value),
                    Name = tbxName.Text,
                    Author = tbxAuthor.Text,
                    PublishDate = dtpPublishDate.Value,
                    Price = Convert.ToDecimal(tbxPrice.Text),
                    Quantity = Convert.ToInt32(tbxQuantity.Text)
                });
                ClearInputs();
                LoadBooks();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxAuthor.Text == "" || dtpPublishDate.Value == null || tbxPrice.Text == "" || tbxQuantity.Text == "")
                MessageBox.Show("Please select row which you want to delete then delete it");
            else
            {
                _bookManager.Delete(new Book
                {
                    Id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value),
                });
                ClearInputs();
                LoadBooks();
                MessageBox.Show("Deleted Successfully");
            }
        }

        private void tbxSearchBooks_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterBooks.Text == "Search by Name")
            {
                dgwBooks.DataSource = _bookManager.GetAll()
                    .Where(x => x.Name.StartsWith(tbxSearchBooks.Text)).ToList();
                dgwBooks.ClearSelection();
            }
            else if (cbFilterBooks.Text == "Search by Author")
            {
                dgwBooks.DataSource = _bookManager.GetAll()
                    .Where(x => x.Author.StartsWith(tbxSearchBooks.Text)).ToList();
                dgwBooks.ClearSelection();
            }
        }
    }
}
