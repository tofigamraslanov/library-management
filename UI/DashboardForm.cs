using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class DashboardForm : Form
    {
        private readonly StudentManager _studentManager = new StudentManager(new EfStudentDal());
        private readonly LibrarianManager _librarianManager = new LibrarianManager(new EfLibrarianDal());
        private readonly BookManager _bookManager = new BookManager(new EfBookDal());
        private readonly IssueBookManager _issueBookManager = new IssueBookManager(new EfIssueBookDal(), new BookManager(new EfBookDal()));

        private readonly ReturnBookManager _returnBookManager = new ReturnBookManager(new EfReturnBookDal(),
            new IssueBookManager(new EfIssueBookDal(), new BookManager(new EfBookDal())));

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblStudentsCount.Text = _studentManager.GetAll().Count.ToString();
            lblLibrariansCount.Text = _librarianManager.GetAll().Count.ToString();
            lblBooksCount.Text = _bookManager.GetAll().Count.ToString();
            lblIssuedBooksCount.Text = _issueBookManager.GetAll().Count.ToString();
            lblReturnBooksCount.Text = _returnBookManager.GetAll().Count.ToString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
