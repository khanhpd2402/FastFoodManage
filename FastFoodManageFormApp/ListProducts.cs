using FastFoodManageFormApp.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class ListProductsFrm : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public ListProductsFrm()
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

        private void ListProductsFrm_Load(object sender, EventArgs e)
        {
            ListProductDgv.DataSource = dbContext.Products.ToList();
            CategoryCb.DataSource = dbContext.Categories.ToList();
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            string key = SearchTb.Text.Trim();

            var query = from pro in dbContext.Products
                        where pro.ProductName.ToString().Contains(key)
                        select pro;
            ListProductDgv.DataSource = query.ToList();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            byte[] img = ImageToBae64(imgPb.Image, imgPb.Image.RawFormat);
            int productId = Convert.ToInt32(ProductIDTb.Text);
            string productName = ProductNameTb.Text;
            Category category = (Category)CategoryCb.SelectedValue;
            string quantity = "";
            if (IsValidInt(QuantityTx.Text))
            {
                quantity = QuantityTx.Text;
            }
            else
            {
                MessageBox.Show("Invalid Quantity Input!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTx.Focus();
                return;
            }
            decimal price = 0;
            if (IsValidMoney(PriceTb.Text))
            {
                price = Convert.ToDecimal(PriceTb.Text);
            }
            else
            {
                MessageBox.Show("Invalid Price Input!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceTb.Focus();
                return;
            }
            bool enabled = true;
            if (EnabledCb.Text.Equals("False"))
            {
                enabled = false;
            }

            // Tạo đối tượng sản phẩm mới với các giá trị đã cập nhật
            Product product = new Product
            {
                ProductId = productId,
                ProductName = productName,
                CategoryId = category.CategoryId,
                Quantity = quantity,
                Price = price,
                Enabled = enabled,
                Image = img,
            };

            // Gọi hàm UpdateProduct để cập nhật thông tin sản phẩm trong cơ sở dữ liệu
                UpdateProduct(productId, (existingProduct) =>
                {
                    existingProduct.ProductName = product.ProductName;
                    existingProduct.CategoryId = product.CategoryId;
                    existingProduct.Quantity = product.Quantity;
                    existingProduct.Price = product.Price;
                    existingProduct.Enabled = product.Enabled;
                    existingProduct.Image = product.Image;
                });

                MessageBox.Show("Product updated successfully.");
                ListProductDgv.DataSource = dbContext.Products.ToList();
        }
        public void UpdateProduct(int productId, Action<Product> updateAction)
        {
            
                var existingProduct = dbContext.Products.FirstOrDefault(p => p.ProductId == productId);
                if (existingProduct != null)
                {
                    updateAction(existingProduct);
                    dbContext.SaveChanges();
                }
            
        }
        private void SearchIdPb_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIDTb.Text);
            Product product = GetAnProduct(productId);
            ProductNameTb.Text = product.ProductName.ToString();
            CategoryCb.Text = product.Category.ToString();
            QuantityTx.Text = product.Quantity.ToString();
            PriceTb.Text = product.Price.ToString();
            EnabledCb.Text = product.Enabled.ToString();
            if(product.Image != null)
            {
                imgPb.Image = Base64ToImage(product.Image);
                imgPb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
        public static bool IsValidMoney(string input)
        {
            return decimal.TryParse(input, out _);
        }
        public static bool IsValidInt(string input)
        {
            return int.TryParse(input, out _);
        }
        public Image Base64ToImage(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream(data, 0, data.Length);
            memoryStream.Write(data, 0, data.Length);
            Image image = Image.FromStream(memoryStream, true);
            return image;
        }
        public byte[] ImageToBae64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //convert img to byte
                image.Save(ms, format);
                byte[] imgBytes = ms.ToArray();
                return imgBytes;
            }
        }
        private Product GetAnProduct(int productId)
        {
            var product = dbContext.Products.FirstOrDefault(u => u.ProductId == productId);
            return product;
        }
    }
}
