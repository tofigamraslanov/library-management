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
    public partial class StudentForm : Form
    {
        StudentManager _studentManager = new StudentManager(new EfStudentDal());
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
            cbFilterStudents.Text = "Select column which you want to search by";
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

        private void btnAddLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxDepartment.Text == "" || tbxCourse.Text == "" || tbxPhone.Text == "")
            {
                MessageBox.Show("Please fill out text box!");
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
                MessageBox.Show("Student added succesfuly");
            }
        }

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwStudents.CurrentRow.Cells[1].Value.ToString();
            tbxDepartment.Text = dgwStudents.CurrentRow.Cells[2].Value.ToString();
            tbxCourse.Text = dgwStudents.CurrentRow.Cells[3].Value.ToString();
            tbxPhone.Text = dgwStudents.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdateLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxDepartment.Text == "" || tbxCourse.Text == "" || tbxPhone.Text == "")
                MessageBox.Show("Please select row which you want to update then update them");
            else
            {
                _studentManager.Update(new Student
                {
                    Id = Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value),
                    Name = tbxName.Text,
                    Department = tbxDepartment.Text,
                    Course = Convert.ToInt32(tbxCourse.Text),
                    Phone = tbxPhone.Text
                });
                ClearInputs();
                LoadStudents();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btnDeleteLibrarian_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxDepartment.Text == "" || tbxCourse.Text == "" || tbxPhone.Text == "")
                MessageBox.Show("Please select row which you want to delete then delete it");
            else
            {
                _studentManager.Delete(new Student
                {
                    Id = Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value)
                });
                ClearInputs();
                LoadStudents();
                MessageBox.Show("Deleted Successfully");
            }
        }

        private void tbxSearchStudents_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterStudents.Text == "Search by Name")
            {
                dgwStudents.DataSource = _studentManager.GetAll()
                    .Where(x => x.Name.StartsWith(tbxSearchStudents.Text)).ToList();
                dgwStudents.ClearSelection();
            }
            else if (cbFilterStudents.Text == "Search by Department")
            {
                dgwStudents.DataSource = _studentManager.GetAll()
                    .Where(x => x.Department.StartsWith(tbxSearchStudents.Text)).ToList();
                dgwStudents.ClearSelection();
            }
            else if (cbFilterStudents.Text == "Search by Course")
            {
                dgwStudents.DataSource = _studentManager.GetAll()
                    .Where(x => x.Course.ToString() == tbxSearchStudents.Text).ToList();
                dgwStudents.ClearSelection();
            }
        }
    }
}
