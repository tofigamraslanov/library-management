using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class IssueBookForm : Form
    {
        readonly IssueBookManager _issueBookManager =
            new IssueBookManager(new EfIssueBookDal(), new BookManager(new EfBookDal()));

        readonly BookManager _bookManager = new BookManager(new EfBookDal());
        readonly StudentManager _studentManager = new StudentManager(new EfStudentDal());

        public IssueBookForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToHomeFromIssueBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            LoadIssueBooks();
            FillStudents();
            FillBooks();
            cbFilterIssueBooks.Text = @"Select column which you want to search by";
        }

        private void LoadIssueBooks()
        {
            dgwIssueBooks.DataSource = _issueBookManager.GetIssueBookDetails();
            dgwIssueBooks.ClearSelection();
        }

        private void FillStudents()
        {
            var students = _studentManager.GetAll();
            foreach (var student in students)
            {
                cbStudentNameIB.Items.Add(student.Name);
            }
        }

        private void FillBooks()
        {
            var books = _bookManager.GetAll().Where(b => b.Quantity > 0);
            foreach (var book in books)
            {
                cbBookNameIB.Items.Add(book.Name);
            }
        }

        private void ClearInputs()
        {
            cbStudentNameIB.Text = "";
            cbBookNameIB.Text = "";
        }

        private void dgwIssueBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwIssueBooks.CurrentRow != null)
            {
                cbStudentNameIB.Text = dgwIssueBooks.CurrentRow.Cells[1].Value.ToString();
                cbBookNameIB.Text = dgwIssueBooks.CurrentRow.Cells[2].Value.ToString();
                dtpIssueDate.Value = Convert.ToDateTime(dgwIssueBooks.CurrentRow.Cells[3].Value);
            }
        }

        private void btnAddIssueBook_Click(object sender, EventArgs e)
        {
            if (dtpIssueDate != null && (cbStudentNameIB.Text == "" || cbBookNameIB.Text == ""))
            {
                MessageBox.Show(@"Please fill out inputs");
            }
            else
            {
                var studentId = _studentManager.GetAll().Where(c => c.Name == cbStudentNameIB.Text).FirstOrDefault().Id;
                var bookId = _bookManager.GetAll().Where(c => c.Name == cbBookNameIB.Text).FirstOrDefault().Id;
                if (dtpIssueDate != null)
                    _issueBookManager.Add(new IssueBook
                    {
                        StudentId = studentId,
                        BookId = bookId,
                        IssueDate = dtpIssueDate.Value
                    });

                ClearInputs();
                cbBookNameIB.Items.Clear();
                LoadIssueBooks();
                FillBooks();
                MessageBox.Show(@"Book Successfully Issued!");
            }
        }

        private void btnUpdateIssueBook_Click(object sender, EventArgs e)
        {
            if (dtpIssueDate?.Value == null && (cbStudentNameIB.Text == "" || cbBookNameIB.Text == ""))
                MessageBox.Show(@"Please select a row which you want to update then update them");
            else
            {
                var studentId = _studentManager.GetAll().Where(c => c.Name == cbStudentNameIB.Text).FirstOrDefault().Id;
                var bookId = _bookManager.GetAll().Where(c => c.Name == cbBookNameIB.Text).FirstOrDefault().Id;
                if (dgwIssueBooks.CurrentRow != null)
                    _issueBookManager.Update(new IssueBook
                    {
                        Id = Convert.ToInt32(dgwIssueBooks.CurrentRow.Cells[0].Value),
                        StudentId = studentId,
                        BookId = bookId,
                        IssueDate = Convert.ToDateTime(dtpIssueDate?.Value)
                    });
                ClearInputs();
                cbBookNameIB.Items.Clear();
                LoadIssueBooks();
                FillBooks();
                MessageBox.Show(@"IssueBook Successfully Updated!");
            }
        }

        private void btnDeleteIssueBook_Click(object sender, EventArgs e)
        {
            if (cbStudentNameIB.Text == "" || cbBookNameIB.Text == "" || dtpIssueDate?.Value == null)
                MessageBox.Show(@"Please select a row which you want to delete then delete it");
            else
            {
                var studentId = _studentManager.GetAll().Where(c => c.Name == cbStudentNameIB.Text).FirstOrDefault().Id;
                var bookId = _bookManager.GetAll().Where(c => c.Name == cbBookNameIB.Text).FirstOrDefault().Id;
                if (dgwIssueBooks.CurrentRow != null)
                    _issueBookManager.Delete(new IssueBook
                    {
                        Id = Convert.ToInt32(dgwIssueBooks.CurrentRow.Cells[0].Value),
                        BookId = bookId,
                        StudentId = studentId
                    });
                ClearInputs();
                cbBookNameIB.Items.Clear();
                LoadIssueBooks();
                FillBooks();
                MessageBox.Show(@"Book Successfully Returned!");
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearchIssueBooks.Text;
            if (string.IsNullOrEmpty(key))
            {
                LoadIssueBooks();
            }
            else
            {
                if (cbFilterIssueBooks.Text == @"Search by Student Name")
                {
                    dgwIssueBooks.DataSource = _issueBookManager.GetByStudentName(key);
                    dgwIssueBooks.ClearSelection();
                }
                else if (cbFilterIssueBooks.Text == @"Search by Book Name")
                {
                    dgwIssueBooks.DataSource = _issueBookManager.GetByBookName(key);
                    dgwIssueBooks.ClearSelection();
                }
            }
        }
    }
}
