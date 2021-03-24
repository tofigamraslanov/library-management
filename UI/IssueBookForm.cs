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
    public partial class IssueBookForm : Form
    {
        IssueBookManager _issueBookManager = new IssueBookManager(new EfIssueBookDal(), new BookManager(new EfBookDal()));
        BookManager _bookManager = new BookManager(new EfBookDal());
        StudentManager _studentManager = new StudentManager(new EfStudentDal());

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
        }

        private void LoadIssueBooks()
        {
            dgwIssueBooks.DataSource = _issueBookManager.GetAll();
            dgwIssueBooks.ClearSelection();
        }

        private void FillStudents()
        {
            var ids = _studentManager.GetAll();
            foreach (var id in ids)
            {
                cbStudentId.Items.Add(id.Id);
            }
        }

        private void FillBooks()
        {
            var books = _bookManager.GetAll().Where(b => b.Quantity > 0);
            foreach (var book in books)
            {
                cbBookId.Items.Add(book.Id);
            }
        }

        private void ClearInputs()
        {
            cbStudentId.Text = "";
            cbBookId.Text = "";
        }

        private void btnAddIssueBook_Click(object sender, EventArgs e)
        {
            if (cbStudentId.Text == "" || cbBookId.Text == "" || dtpIssueDate.Value == null)
            {
                MessageBox.Show("Please fill out fields");
            }
            else
            {
                _issueBookManager.Add(new IssueBook
                {
                    StudentId = Convert.ToInt32(cbStudentId.Text),
                    BookId = Convert.ToInt32(cbBookId.Text),
                    IssueDate = dtpIssueDate.Value
                });

                LoadIssueBooks();
                ClearInputs();
                FillBooks();
                MessageBox.Show("Added Successfully");
            }
        }

        private void dgwIssueBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbStudentId.Text = dgwIssueBooks.CurrentRow.Cells[1].Value.ToString();
            cbBookId.Text = dgwIssueBooks.CurrentRow.Cells[2].Value.ToString();
            dtpIssueDate.Value = Convert.ToDateTime(dgwIssueBooks.CurrentRow.Cells[3].Value);
        }

        private void btnUpdateIssueBook_Click(object sender, EventArgs e)
        {
            if (cbStudentId.Text == "" || cbBookId.Text == "" || dtpIssueDate.Value == null)
                MessageBox.Show("Please select row which you want to update then update them");
            else
            {
                _issueBookManager.Update(new IssueBook
                {
                    Id = Convert.ToInt32(dgwIssueBooks.CurrentRow.Cells[0].Value),
                    StudentId = Convert.ToInt32(cbStudentId.Text),
                    BookId = Convert.ToInt32(cbBookId.Text),
                    IssueDate = Convert.ToDateTime(dtpIssueDate.Value)
                });
                ClearInputs();
                LoadIssueBooks();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btnDeleteIssueBook_Click(object sender, EventArgs e)
        {
            if (cbStudentId.Text == "" || cbBookId.Text == "" || dtpIssueDate.Value == null)
                MessageBox.Show("Please select row which you want to delete then delete it");
            else
            {
                _issueBookManager.Delete(new IssueBook
                {
                    Id = Convert.ToInt32(dgwIssueBooks.CurrentRow.Cells[0].Value),
                    BookId = Convert.ToInt32(dgwIssueBooks.CurrentRow.Cells[2].Value)
                });
                ClearInputs();
                LoadIssueBooks();
                FillBooks();
                MessageBox.Show("Deleted Successfully");
            }
        }
    }
}
