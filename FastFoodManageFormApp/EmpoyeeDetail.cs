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
    public partial class EmpoyeeDetailFrm : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public EmpoyeeDetailFrm()
        {
            InitializeComponent();
        }

        private void LogoPb_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            this.Hide();
            homeFrm.Show();
        }

        private void BackManageLb_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            this.Hide();
            employeeManager.Show();
        }

        private void BackManagePb_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            this.Hide();
            employeeManager.Show();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialogEmp.ShowDialog() == DialogResult.OK)
            {
                printDocumentEmp.Print();
            }
        }

        private void printDocumentEmp_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==========Individual Employee==========", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("EmployeeID: " + EmpIDLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Account Name: " + AccountLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 160));
            e.Graphics.DrawString("First Name: " + FNameLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Last Name: " + LNameLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 280));
            e.Graphics.DrawString("Gender: " + GenderLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 280));
            e.Graphics.DrawString("Salary: " + SalaryLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 400));
            e.Graphics.DrawString("Phone Number: " + PhoneNumLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 280));
            e.Graphics.DrawString("Position: " + PositionLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 340));
            e.Graphics.DrawString("Date Of Birth: " + DOBLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 340));
            e.Graphics.DrawString("Hire Date: " + HireDateLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 340));
            e.Graphics.DrawString("Address: " + AddressLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 340));
        }
    }
}
