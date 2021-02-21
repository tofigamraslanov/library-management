using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int startPoint = 0;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    startPoint += 1;
        //    myProgress.Value = startPoint;
        //    if (myProgress.Value == 100)
        //    {
        //        myProgress.Value = 0;
        //        timer1.Stop(); ;
        //        LoginForm loginForm = new LoginForm();
        //        loginForm.Show();
        //        this.Hide();
        //    }
        //}

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
