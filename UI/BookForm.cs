using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void LoadBooks()
        {
            dgwBooks.DataSource = _bookManager.GetAll();
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

        private void btnDeleteBook_Click(object sender, EventArgs e)
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
}
