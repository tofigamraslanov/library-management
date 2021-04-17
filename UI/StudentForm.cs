using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class StudentForm : Form
    {
        readonly StudentManager _studentManager = new StudentManager(new EfStudentDal());
        public StudentForm()
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

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            cbFilterStudents.Text = @"Select column which you want to search by";
        }

        private void LoadStudents()
        {
            dgwStudents.DataSource = _studentManager.GetAll();
            dgwStudents.ClearSelection();
        }

        private void ClearInputs()
        {
            tbxName.Clear();
            tbxDepartment.Clear();
            tbxCourse.Clear();
            tbxPhone.Clear();
        }

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwStudents.CurrentRow != null)
            {
                tbxName.Text = dgwStudents.CurrentRow.Cells[1].Value.ToString();
                tbxDepartment.Text = dgwStudents.CurrentRow.Cells[2].Value.ToString();
                tbxCourse.Text = dgwStudents.CurrentRow.Cells[3].Value.ToString();
                tbxPhone.Text = dgwStudents.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxDepartment.Text == "" || tbxCourse.Text == "" || tbxPhone.Text == "")
            {
                MessageBox.Show(@"Please fill out inputs!");
            }
            else
            {
                _studentManager.Add(new Student
                {
                    Name = tbxName.Text,
                    Department = tbxDepartment.Text,
                    Course = int.Parse(tbxCourse.Text),
                    Phone = tbxPhone.Text
                });
                ClearInputs();
                LoadStudents();
                MessageBox.Show(@"Student Successfully Added!");
            }
        }

        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxDepartment.Text == "" || tbxCourse.Text == "" || tbxPhone.Text == "")
                MessageBox.Show(@"Please select a row which you want to update then update them");
            else
            {
                _studentManager.Update(new Student
                {
                    Id = Convert.ToInt32(dgwStudents.CurrentRow?.Cells[0].Value),
                    Name = tbxName.Text,
                    Department = tbxDepartment.Text,
                    Course = Convert.ToInt32(tbxCourse.Text),
                    Phone = tbxPhone.Text
                });
                ClearInputs();
                LoadStudents();
                MessageBox.Show(@"Student Successfully Updated!");
            }
        }

        private void btnDeleteLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxDepartment.Text == "" || tbxCourse.Text == "" || tbxPhone.Text == "")
                MessageBox.Show(@"Please select a row which you want to delete then delete it");
            else
            {
                _studentManager.Delete(new Student
                {
                    Id = Convert.ToInt32(dgwStudents.CurrentRow?.Cells[0].Value)
                });
                ClearInputs();
                LoadStudents();
                MessageBox.Show(@"Student Successfully Deleted!");
            }
        }

        private void tbxSearchStudents_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearchStudents.Text;
            if (string.IsNullOrEmpty(key))
            {
                LoadStudents();
            }
            else
            {
                if (cbFilterStudents.Text == @"Search by Name")
                {
                    dgwStudents.DataSource = _studentManager.GetByName(key);
                    dgwStudents.ClearSelection();
                }
                else if (cbFilterStudents.Text == @"Search by Department")
                {
                    dgwStudents.DataSource = _studentManager.GetByDepartment(key);
                    dgwStudents.ClearSelection();
                }
                else if (cbFilterStudents.Text == @"Search by Course")
                {
                    dgwStudents.DataSource = _studentManager.GetByCourse(int.Parse(key));
                    dgwStudents.ClearSelection();
                }
            }
        }
    }
}
