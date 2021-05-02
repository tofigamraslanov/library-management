using System;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStudents_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookForm bookForm = new BookForm();
            bookForm.Show();
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }
    }
}
