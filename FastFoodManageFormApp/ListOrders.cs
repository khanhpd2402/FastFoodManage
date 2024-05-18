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
    public partial class ListOrdersFrm : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public ListOrdersFrm()
        {
            InitializeComponent();
        }

        private void LogoPb_Click(object sender, EventArgs e)
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

        private void BackHomeLb_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            this.Hide();
            homeFrm.Show();
        }

        private void ListOrdersFrm_Load(object sender, EventArgs e)
        {
            ListOrdersDgv.DataSource = dbContext.Orders.ToList();
            CategoriesCb.DataSource = dbContext.Categories.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
