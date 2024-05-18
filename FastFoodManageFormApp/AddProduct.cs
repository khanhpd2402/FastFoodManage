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
    public partial class AddProductFrm : Form
    {
        private readonly FastFoodRestaurantContext dbContext = new();
        public AddProductFrm()
        {
            InitializeComponent();
        }
        List<Product> products = new();
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

        private void AddProductFrm_Load(object sender, EventArgs e)
        {
            CategoryCb.DataSource = dbContext.Categories.ToList();
        }

        private void ImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Picture file (.png,.jpg)|*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ImgPb.Image = Image.FromFile(open.FileName);
                ImgPb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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

        public Image Base64ToImage(byte[] data)
        {
            MemoryStream memoryStream = new MemoryStream(data, 0, data.Length);
            memoryStream.Write(data, 0, data.Length);
            Image image = Image.FromStream(memoryStream, true);
            return image;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            byte[] img = ImageToBae64(ImgPb.Image, ImgPb.Image.RawFormat);
            string productName = ProductNameTb.Text;
            Category category = (Category)CategoryCb.SelectedValue;
            string quantity = "";
            if (IsValidInt(QuantityTb.Text))
            {
                quantity = QuantityTb.Text;
            }
            else
            {
                MessageBox.Show("Invalid Quantity Input!", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTb.Focus();
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
            if (EnableCb.Text.Equals("Fales"))
            {
                enabled = false;
            }
            Product product = new()
            {
                ProductName = productName,
                Category = category,
                Quantity = quantity,
                Price = price,
                Enabled = enabled,
                Image = img,
            };
            products.Add(product);
            AddProductDgv.DataSource = products.Select(x => new
            {
                x.ProductName,
                x.Category,
                x.Quantity,
                x.Price,
                x.Enabled,
                x.Image
            }).ToList();
        }

        public static bool IsValidMoney(string input)
        {
            return decimal.TryParse(input, out _);
        }
        public static bool IsValidInt(string input)
        {
            return int.TryParse(input, out _);
        }

        private void AddAllBtn_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                dbContext.Products.AddRange(products);
                if (dbContext.SaveChanges() > 0)
                {
                    MessageBox.Show($"Insert {products.Count} product(s) successfull!");
                }
            }
        }
    }
}
