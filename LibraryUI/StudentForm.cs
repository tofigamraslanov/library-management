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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI
{
    public partial class StudentForm : Form
    {
        StudentManager _studentManager = new StudentManager(new EfStudentDal());
        public StudentForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        //private void StudentForm_Load(object sender, EventArgs e)
        //{
        //    //dgwStudents.DataSource = _studentManager.GetAll();
        //}

        //private void btnAddStudent_Click(object sender, EventArgs e)
        //{
        //    _studentManager.Add(new Student()
        //    {
        //        Name = tbxStudentName.Text,
        //        Department = tbxStudentDepartment.Text,
        //        Course = int.Parse(tbxStudentCourse.Text),
        //        Phone = tbxStudentPhone.Text
        //    });
        //}
    }
}
