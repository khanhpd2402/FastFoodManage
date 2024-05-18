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
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void LogoutPb_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure you want to log out?", "Notification",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                LoginFrm login = new LoginFrm();
                this.Close();
                login.Show();
            }
        }

        private void LogoutLb_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure you want to log out?", "Notification",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                LoginFrm login = new LoginFrm();
                this.Hide();
                login.Show();
            }
        }

        private void ManageEmpPb_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            this.Hide();
            employeeManager.Show();
        }

        private void AddEmPb_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            this.Hide();
            addEmployee.Show();
        }

        private void SalaryPb_Click(object sender, EventArgs e)
        {
            SalaryEmployeeFrm salaryEmployeeFrm = new SalaryEmployeeFrm();
            this.Hide();
            salaryEmployeeFrm.Show();
        }

        private void ManageProductPb_Click(object sender, EventArgs e)
        {
            ListProductsFrm listProductsFrm = new ListProductsFrm();
            this.Hide();
            listProductsFrm.Show();
        }

        private void AddProductPb_Click(object sender, EventArgs e)
        {
            AddProductFrm addProductFrm = new AddProductFrm();
            this.Hide();
            addProductFrm.Show();
        }

        private void ListCategoriesPb_Click(object sender, EventArgs e)
        {
            ListCategoryFrm listCategories = new ListCategoryFrm();
            this.Hide();
            listCategories.Show();
        }

        private void AddCategoryPb_Click(object sender, EventArgs e)
        {
            AddCategoryFrm addCategoryFrm = new AddCategoryFrm();
            this.Hide(); addCategoryFrm.Show();
        }

        private void ListOrdersPb_Click(object sender, EventArgs e)
        {
            ListOrdersFrm listOrdersFrm = new ListOrdersFrm();
            this.Hide(); listOrdersFrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddProductFrm addProductFrm = new AddProductFrm();
            this.Hide();
            addProductFrm.Show();
        }
    }
}
