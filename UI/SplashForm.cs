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

        int _startPoint = 0;

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _startPoint += 1;
            progressBar.Value = _startPoint;
            persentage.Text = _startPoint + " %";
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
