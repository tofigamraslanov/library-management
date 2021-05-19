using System;
using System.Windows.Forms;

namespace UI
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int _startPoint;

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _startPoint += 1;
            progressBar.Value = _startPoint;
            lblPercentage.Text = _startPoint + @" %";
            if (progressBar.Value != 100) return;
            progressBar.Value = 0;
            timer1.Stop();
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
