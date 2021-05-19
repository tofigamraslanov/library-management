using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ReturnBookForm : Form
    {
        readonly IssueBookManager _issueBookManager =
           new IssueBookManager(new EfIssueBookDal(), new BookManager(new EfBookDal()));
        readonly ReturnBookManager _returnBookManager = new ReturnBookManager(
            new EfReturnBookDal(),
            new IssueBookManager(new EfIssueBookDal(),
                new BookManager(new EfBookDal())));
        readonly BookManager _bookManager = new BookManager(new EfBookDal());
        readonly StudentManager _studentManager = new StudentManager(new EfStudentDal());
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInputs()
        {
            cbStudentNameRB.Text = "";
            cbBookNameRB.Text = "";
            tbxFine.Text = "";
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            LoadIssueBooks();
            LoadReturnBooks();
        }

        private void LoadIssueBooks()
        {
            dgwIssueBooksRB.DataSource = _issueBookManager.GetIssueBookDetails();
            dgwIssueBooksRB.ClearSelection();
        }

        private void LoadReturnBooks()
        {
            dgwReturnBooks.DataSource = _returnBookManager.GetReturnBookDetails();
            dgwReturnBooks.ClearSelection();
        }


        private void dgwIssueBooksRB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwIssueBooksRB.CurrentRow != null)
            {
                cbStudentNameRB.Text = dgwIssueBooksRB.CurrentRow.Cells[1].Value.ToString();
                cbBookNameRB.Text = dgwIssueBooksRB.CurrentRow.Cells[2].Value.ToString();
                dtpIssueDateRB.Value = Convert.ToDateTime(dgwIssueBooksRB.CurrentRow.Cells[3].Value);
            }
        }

        private void dgwReturnBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwReturnBooks.CurrentRow != null)
            {
                cbStudentNameRB.Text = dgwReturnBooks.CurrentRow.Cells[1].Value.ToString();
                cbBookNameRB.Text = dgwReturnBooks.CurrentRow.Cells[2].Value.ToString();
                dtpIssueDateRB.Value = Convert.ToDateTime(dgwReturnBooks.CurrentRow.Cells[3].Value);
                dtpReturnDateRB.Value = Convert.ToDateTime(dgwReturnBooks.CurrentRow.Cells[4].Value);
                tbxFine.Text = dgwReturnBooks.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnBackToHomeFromIssueBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnReturnIssueBook_Click(object sender, EventArgs e)
        {
            var studentId = _studentManager.GetAll().Find(c => c.Name == cbStudentNameRB.Text).Id;
            var bookId = _bookManager.GetAll().Find(c => c.Name == cbBookNameRB.Text).Id;
            if (cbStudentNameRB.Text == "" || cbBookNameRB.Text == "" || dtpIssueDateRB?.Value == null)
                MessageBox.Show(@"Please select a row which you want to delete then delete it");
            else
            {
                _issueBookManager.Delete(new IssueBook()
                {
                    Id = Convert.ToInt32(dgwIssueBooksRB.CurrentRow?.Cells[0].Value),
                    BookId = bookId,
                    StudentId = studentId
                });
                _returnBookManager.Add(new ReturnBook
                {
                    StudentId = studentId,
                    BookId = bookId,
                    IssueDate = dtpIssueDateRB.Value,
                    ReturnDate = dtpReturnDateRB.Value,
                    Fine = int.Parse(tbxFine.Text)
                });

                ClearInputs();
                LoadIssueBooks();
                LoadReturnBooks();
                MessageBox.Show(@"Book Successfully Returned!");
            }
        }

        private void btnUpdateReturnBook_Click(object sender, EventArgs e)
        {
            var studentId = _studentManager.GetAll().Find(c => c.Name == cbStudentNameRB.Text).Id;
            var bookId = _bookManager.GetAll().Find(c => c.Name == cbBookNameRB.Text).Id;
            if (cbStudentNameRB.Text == "" || cbBookNameRB.Text == "" || dtpIssueDateRB?.Value == null)
                MessageBox.Show(@"Please select a row which you want to delete then delete it");
            else
            {
                _returnBookManager.Update(new ReturnBook
                {
                    Id = Convert.ToInt32(dgwReturnBooks.CurrentRow?.Cells[0].Value),
                    StudentId = studentId,
                    BookId = bookId,
                    IssueDate = dtpIssueDateRB.Value,
                    ReturnDate = dtpReturnDateRB.Value,
                    Fine = int.Parse(tbxFine.Text)
                });

                ClearInputs();
                LoadIssueBooks();
                LoadReturnBooks();
                MessageBox.Show(@"Book Successfully Updated!");
            }
        }

        private void btnCalculateFine_Click(object sender, EventArgs e)
        {
            var difference = dtpReturnDateRB.Value.Date - dtpIssueDateRB.Value.Date;
            var days = difference.Days;
            var fine = 0;
            if (days < 7)
            {
                fine = 0;
                tbxFine.Text = @"0";
            }
            else
            {
                fine = days - 7;
                tbxFine.Text = (fine * 10).ToString();
            }
        }

        private void tbxSearchIssueBooks_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearchIssueBooks.Text;
            if (string.IsNullOrEmpty(key))
            {
                LoadIssueBooks();
                LoadReturnBooks();
            }
            else
            {
                if (cbFilterIssueBooks.Text == @"Search by Student Name in Book Issued")
                {
                    dgwIssueBooksRB.DataSource = _issueBookManager.GetByStudentName(key);
                    dgwIssueBooksRB.ClearSelection();
                }
                else if (cbFilterIssueBooks.Text == @"Search by Book Name in Book Issued")
                {
                    dgwIssueBooksRB.DataSource = _issueBookManager.GetByBookName(key);
                    dgwIssueBooksRB.ClearSelection();
                }
                else if (cbFilterIssueBooks.Text == @"Search by Student Name in Book Returned")
                {
                    dgwReturnBooks.DataSource = _returnBookManager.GetByStudentName(key);
                    dgwReturnBooks.ClearSelection();
                }
                else if (cbFilterIssueBooks.Text == @"Search by Book Name in Book Returned")
                {
                    dgwReturnBooks.DataSource = _returnBookManager.GetByBookName(key);
                    dgwReturnBooks.ClearSelection();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
