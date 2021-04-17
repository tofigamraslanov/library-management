using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class BookForm : Form
    {
        readonly BookManager _bookManager = new BookManager(new EfBookDal());
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
            cbFilterBooks.Text = @"Select column which you want to search by";
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

        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwBooks.CurrentRow != null)
            {
                tbxName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
                tbxAuthor.Text = dgwBooks.CurrentRow.Cells[2].Value.ToString();
                dtpPublishDate.Value = Convert.ToDateTime(dgwBooks.CurrentRow.Cells[3].Value);
                tbxPrice.Text = dgwBooks.CurrentRow.Cells[4].Value.ToString();
                tbxQuantity.Text = dgwBooks.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if ((tbxName.Text == "" || tbxAuthor.Text == "" || tbxPrice.Text == "" || tbxQuantity.Text == "" || dtpPublishDate?.Value == null))
                MessageBox.Show(@"Please fill out inputs");
            else
            {
                if (dtpPublishDate != null)
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
                MessageBox.Show(@"Book Successfully Added!");
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if ((tbxName.Text == "" || tbxAuthor.Text == "" || tbxPrice.Text == "" || tbxQuantity.Text == "" || dtpPublishDate?.Value == null))
                MessageBox.Show(@"Please select a row which you want to update then update them");
            else
            {
                if (dtpPublishDate != null)
                {
                    _bookManager.Update(new Book
                    {
                        Id = Convert.ToInt32(dgwBooks.CurrentRow?.Cells[0].Value),
                        Name = tbxName.Text,
                        Author = tbxAuthor.Text,
                        PublishDate = dtpPublishDate.Value,
                        Price = Convert.ToDecimal(tbxPrice.Text),
                        Quantity = Convert.ToInt32(tbxQuantity.Text)
                    });
                }
                ClearInputs();
                LoadBooks();
                MessageBox.Show(@"Book Successfully Updated!");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxAuthor.Text == "" || tbxPrice.Text == "" || tbxQuantity.Text == "" || dtpPublishDate?.Value == null)
                MessageBox.Show(@"Please select a row which you want to delete then delete it");
            else
            {
                if (dgwBooks.CurrentRow != null)
                    _bookManager.Delete(new Book
                    {
                        Id = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value),
                    });
                ClearInputs();
                LoadBooks();
                MessageBox.Show(@"Book Successfully Deleted!");
            }
        }


        private void tbxSearchBooks_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearchBooks.Text;
            if (string.IsNullOrEmpty(key))
                LoadBooks();
            else
            {

                if (cbFilterBooks.Text == @"Search by Name")
                {
                    dgwBooks.DataSource = _bookManager.GetByName(key);
                    dgwBooks.ClearSelection();
                }
                else if (cbFilterBooks.Text == @"Search by Author")
                {
                    dgwBooks.DataSource = _bookManager.GetByAuthor(key);
                    dgwBooks.ClearSelection();
                }
            }
        }
    }
}
