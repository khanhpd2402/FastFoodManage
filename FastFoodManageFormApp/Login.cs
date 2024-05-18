using FastFoodManageFormApp.Models;
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
    public partial class LoginFrm : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void ExitLog_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure you want to exit?", "Notification",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string accountName = AccTb.Text;
            string password = PassTb.Text;
            if (CheckLogin(accountName, password))
            {
                HomeFrm homeFrm = new HomeFrm();
                this.Close();
                homeFrm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect accountName or password!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Question);
                PassTb.Clear();
                AccTb.Focus();
            }
        }
        private bool CheckLogin(string accountName, string password)
        {
            var employee = dbContext.Employees.FirstOrDefault(u => u.AccountName == accountName && u.Password == password);
            return employee != null;
        }
    }
}
