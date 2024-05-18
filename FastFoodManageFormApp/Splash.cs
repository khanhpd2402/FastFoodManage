using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodFormApp
{
    public partial class SplashFrm : Form
    {
        public SplashFrm()
        {
            InitializeComponent();

        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            StartProgressBar.Value = startPoint;
            if (StartProgressBar.Value == 100)
            {
                StartProgressBar.Value = 0;
                timer1.Stop();
                LoginFrm login = new LoginFrm();
                this.Hide();
                login.Show();
            }
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void StartProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
