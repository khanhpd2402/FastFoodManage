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
        public partial class EmployeeManager : Form
        {
            private readonly FastFoodRestaurantContext dbContext = new();
            public EmployeeManager()
            {
                InitializeComponent();
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

            private void BackHomePb_Click(object sender, EventArgs e)
            {
                HomeFrm homeFrm = new HomeFrm();
                this.Hide();
                homeFrm.Show();
            }

            private void EmployeeManager_Load(object sender, EventArgs e)
            {
                ListEmployeeDgv.DataSource = dbContext.Employees
        .Select(e => new
        {
            e.EmployeeId,
            e.AccountName,
            e.Password,
            e.LastName,
            e.FirstName,
            e.Gender,
            e.BirthDate,
            e.HireDate,
            e.PhoneNumber,
            e.Address,
            e.Salary,
            e.Role
        })
        .ToList();

            }

            private void SearchTb_TextChanged(object sender, EventArgs e)
            {
                string key = SearchTb.Text.Trim();

                var query = from emp in dbContext.Employees
                            where emp.EmployeeId.ToString().Contains(key) || // Tìm kiếm theo Id (kiểm tra xem chuỗi nhập vào có chứa trong Id không)
                                  emp.AccountName.ToString().Contains(key) ||
                                  emp.FirstName.Contains(key) ||    // Tìm kiếm theo FirstName (kiểm tra xem chuỗi nhập vào có chứa trong FirstName không)
                                  emp.LastName.Contains(key)        // Tìm kiếm theo LastName (kiểm tra xem chuỗi nhập vào có chứa trong LastName không)
                            select emp;
                ListEmployeeDgv.DataSource = query.ToList();
            }


            private Employee GetAnEmployee(int employeeId)
            {
                var employee = dbContext.Employees.FirstOrDefault(u => u.EmployeeId == employeeId);
                return employee;
            }


            private void ListEmployeeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (ListEmployeeDgv.SelectedRows.Count > 0)
            {
                EmpIdTx.Text = ListEmployeeDgv.SelectedRows[0].Cells[0].Value.ToString();
                    AccountTb.Text = ListEmployeeDgv.SelectedRows[0].Cells[1].Value.ToString();
                    PassTb.Text = ListEmployeeDgv.SelectedRows[0].Cells[2].Value.ToString();
                    LNameTb.Text = ListEmployeeDgv.SelectedRows[0].Cells[3].Value.ToString();
                    FNameTb.Text = ListEmployeeDgv.SelectedRows[0].Cells[4].Value.ToString();
                    GenderCb.Text = ListEmployeeDgv.SelectedRows[0].Cells[5].Value.ToString();
                    DOBTimePicker.Text = ListEmployeeDgv.SelectedRows[0].Cells[6].Value.ToString();
                    HireDateTimePicker.Text = ListEmployeeDgv.SelectedRows[0].Cells[7].Value.ToString();
                    PhoneNumTb.Text = ListEmployeeDgv.SelectedRows[0].Cells[8].Value.ToString();
                    AddressTb.Text = ListEmployeeDgv.SelectedRows[0].Cells[9].Value.ToString();
                    SalaryTb.Text = ListEmployeeDgv.SelectedRows[0].Cells[10].Value.ToString();
                    PositionCb.Text = ListEmployeeDgv.SelectedRows[0].Cells[11].Value.ToString();
               }
            }
        }
    }
