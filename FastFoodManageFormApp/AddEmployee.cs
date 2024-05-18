using FastFoodManageFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodFormApp
{
    public partial class AddEmployee : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public AddEmployee()
        {
            InitializeComponent();
        }
        List<Employee> employees = new();
        private void Employee_Load(object sender, EventArgs e)
        {
            GenderCb.SelectedIndex = 0;
            PositionCb.SelectedIndex = 1;
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

        private void LogoPb_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            this.Hide();
            homeFrm.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string acccountName = AccountTb.Text;
            string password = PassTb.Text;
            string firstName = FNameTb.Text;
            string lastName = LNameTb.Text;
            string phoneNumber = PhoneNumTb.Text;
            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Invalid Phone Number!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneNumTb.Focus();
                return;
            }
            if (CheckAccount(acccountName))
            {
                MessageBox.Show("Account already exists!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                AccountTb.Focus();
                return;
            }
                decimal salary = 0;
            if (IsValidMoney(SalaryTb.Text))
            {
                salary = Convert.ToDecimal(SalaryTb.Text);
            }
            else
            {
                MessageBox.Show("Invalid Salary Input!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                SalaryTb.Focus();
                return;
            }
            string address = AddressTb.Text;
            bool gender = true;
            if (GenderCb.Text.Equals("Female"))
            {
                gender = false;
            }
            int role = 2;
            if (PositionCb.Text.Equals("Manager"))
            {
                role = 1;
            }
            DateTime DOB = DOBTimePicker.Value;
            Employee employee = new()
            {
                AccountName = acccountName,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                BirthDate = DOB,
                HireDate = DateTime.Now,
                PhoneNumber = phoneNumber,
                Address = address,
                Salary = salary,
                Role = role,
            };
            employees.Add(employee);
            AddEmployeeDgv.DataSource = employees.Select(x => new
            {
                x.AccountName,
                x.Password,
                x.FirstName,
                x.LastName,
                x.Gender,
                HireDate = x.HireDate?.ToString("dd/MM/yyyy"),
                x.PhoneNumber,
                x.Address,
                x.Salary,
                BirthDate = x.BirthDate?.ToString("dd/MM/yyyy"),
                x.Role
            }).ToList();
        }

        public static bool IsValidPhoneNumber(string input)
        {
            string pattern = @"^(\+|0|84)?[1-9][0-9-]{8,14}$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsValidMoney(string input)
        {
            return decimal.TryParse(input, out _);
        }

        private void AddAllBtn_Click(object sender, EventArgs e)
        {
            if (employees.Count > 0)
            {
                dbContext.Employees.AddRange(employees);
                if (dbContext.SaveChanges() > 0)
                {
                    MessageBox.Show($"Insert {employees.Count} employees successfull!");
                }
            }
        }

        private bool CheckAccount(string accountName)
        {
            var employee = dbContext.Employees.FirstOrDefault(u => u.AccountName == accountName);
            return employee != null;
        }
    }
}
