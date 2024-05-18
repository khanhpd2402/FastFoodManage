using FastFoodManageFormApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
    public partial class AddCategoryFrm : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public AddCategoryFrm()
        {
            InitializeComponent();
        }
        List<Category> categories = new();
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

        private void LogoPb_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            this.Hide();
            homeFrm.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryNameTb.Text;
            bool enabled = true;
            if (EnabledCb.Text.Equals("Fales"))
            {
                enabled = false;
            }
            Category category = new()
            {
                CategoryName = categoryName,
                Enabled = enabled
            };
            categories.Add(category);
            AddCategoriesDgv.DataSource = categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName,
                x.Enabled
            }).ToList();
        }

        private void AddAllBtn_Click(object sender, EventArgs e)
        {
            if (categories.Count > 0)
            {
                dbContext.Categories.AddRange(categories);
                if (dbContext.SaveChanges() > 0)
                {
                    MessageBox.Show($"Insert {categories.Count} employees successfull!");
                }
            }
        }
    }
}
