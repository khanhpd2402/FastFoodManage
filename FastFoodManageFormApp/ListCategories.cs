using FastFoodManageFormApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodFormApp
{
    public partial class ListCategoryFrm : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public ListCategoryFrm()
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

        private void ListCategories_Load(object sender, EventArgs e)
        {
            ListCategoriesDgv.DataSource = dbContext.Categories.ToList();
        }

        private void SearchIdPb_Click(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(CategoryIDTb.Text);
            Category category = GetAnCategory(categoryID);
            CategoryTb.Text = category.CategoryName.ToString();
            EnableCb.Text = category.Enabled.ToString();
        }
        private Category GetAnCategory(int categoryID)
        {
            var category = dbContext.Categories.FirstOrDefault(u => u.CategoryId == categoryID);
            return category;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(CategoryIDTb.Text);
            string categoryName = CategoryTb.Text;
            bool enabled = true;
            if (EnableCb.Text.Equals("False"))
            {
                enabled = false;
            }
            Category category = new Category() { 
                CategoryId = categoryID,
                CategoryName = categoryName,
                Enabled = enabled
            };
            UpdateCategory(categoryID, (existingCategory) =>
            {
                existingCategory.CategoryId = category.CategoryId;
                existingCategory.CategoryName= category.CategoryName;
                existingCategory.Enabled = category.Enabled;
            });

            MessageBox.Show("Categorys updated successfully.");
            ListCategoriesDgv.DataSource = dbContext.Products.ToList();

        }
        public void UpdateCategory(int categoryID, Action<Category> updateAction)
        {

            var existingCategory = dbContext.Categories.FirstOrDefault(p => p.CategoryId == categoryID);
            if (existingCategory != null)
            {
                updateAction(existingCategory);
                dbContext.SaveChanges();
            }

        }
    }
}
