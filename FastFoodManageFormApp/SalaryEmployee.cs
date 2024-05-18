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
    public partial class SalaryEmployeeFrm : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public SalaryEmployeeFrm()
        {
            InitializeComponent();
        }

        private void BackHomePb_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            this.Hide();
            homeFrm.Show();
        }

        private void LogoPb_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            this.Hide();
            homeFrm.Show();
        }

        private void BackHomeLb_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            this.Hide();
            homeFrm.Show();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(EmployeeIdTb.Text);
            int workedDays = Convert.ToInt32(DaysWorkedTb.Text);
            Employee? employee = dbContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeID);
            if (employee != null)
            {
                EmpIDLb.Text = employee.EmployeeId.ToString();
                AccountLb.Text = employee.AccountName;
                FNameLb.Text = employee.FirstName;
                LNameLb.Text = employee.LastName;
                if (employee.Role == 1)
                {
                    PositionLb.Text = "Manager";
                }
                else if (employee.Role == 2)
                {
                    PositionLb.Text = "Saler";
                }
                SalaryLb.Text = employee.Salary.ToString();
                DaysWorkedLb.Text = workedDays.ToString();
                decimal total = (decimal)employee.Salary * workedDays;
                TotalLb.Text = total.ToString();

                EmpIDLb.Visible = true;
                AccountLb.Visible = true;
                FNameLb.Visible = true;
                LNameLb.Visible = true;
                PositionLb.Visible = true;
                SalaryLb.Visible = true;
                DaysWorkedLb.Visible = true;
                TotalLb.Visible = true;
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialogSalary.ShowDialog() == DialogResult.OK)
            {
                printDocumentSalary.Print();
            }
        }

        private void printPreviewDialogSalary_Load(object sender, EventArgs e)
        {
        }

        private void printDocumentSalary_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==========Salary Employee==========", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("EmployeeID: " + EmpIDLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Account Name: " + AccountLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 160));
            e.Graphics.DrawString("First Name: " + FNameLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Last Name: " + LNameLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 280));
            e.Graphics.DrawString("Position: " + PositionLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 340));
            e.Graphics.DrawString("Daily Salary: " + SalaryLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 400));
            e.Graphics.DrawString("Days Worked: " + DaysWorkedLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 460));
            e.Graphics.DrawString("Total Money: " + TotalLb.Text, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(10, 520));
        }
    }
}
