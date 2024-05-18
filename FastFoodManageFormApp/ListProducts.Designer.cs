namespace FastFoodFormApp
{
    partial class ListProductsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProductsFrm));
            panel1 = new Panel();
            label1 = new Label();
            LogoPb = new PictureBox();
            panel2 = new Panel();
            BackHomeLb = new Label();
            label12 = new Label();
            BackHomePb = new PictureBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            label15 = new Label();
            SearchTb = new TextBox();
            pictureBox1 = new PictureBox();
            ListProductDgv = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ProductIDTb = new TextBox();
            ProductNameTb = new TextBox();
            QuantityTx = new TextBox();
            PriceTb = new TextBox();
            CategoryCb = new ComboBox();
            EnabledCb = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            imgPb = new PictureBox();
            ImgBtn = new Button();
            UpdateBtn = new Button();
            SearchIdPb = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListProductDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchIdPb).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoPb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 63);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 40);
            label1.TabIndex = 1;
            label1.Text = "FAST FOOD RESTAURANT";
            // 
            // LogoPb
            // 
            LogoPb.BackColor = Color.FromArgb(255, 255, 192);
            LogoPb.Cursor = Cursors.Hand;
            LogoPb.Image = (Image)resources.GetObject("LogoPb.Image");
            LogoPb.Location = new Point(0, 0);
            LogoPb.Name = "LogoPb";
            LogoPb.Size = new Size(122, 63);
            LogoPb.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPb.TabIndex = 0;
            LogoPb.TabStop = false;
            LogoPb.Click += LogoPb_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(BackHomeLb);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(BackHomePb);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(18, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(989, 48);
            panel2.TabIndex = 7;
            // 
            // BackHomeLb
            // 
            BackHomeLb.AutoSize = true;
            BackHomeLb.Cursor = Cursors.Hand;
            BackHomeLb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackHomeLb.Location = new Point(784, 13);
            BackHomeLb.Name = "BackHomeLb";
            BackHomeLb.Size = new Size(139, 25);
            BackHomeLb.TabIndex = 10;
            BackHomeLb.Text = "Back To Home";
            BackHomeLb.Click += BackHomeLb_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(73, 13);
            label12.Name = "label12";
            label12.Size = new Size(169, 25);
            label12.TabIndex = 10;
            label12.Text = "Manager Product";
            // 
            // BackHomePb
            // 
            BackHomePb.BackColor = Color.Yellow;
            BackHomePb.Cursor = Cursors.Hand;
            BackHomePb.Image = (Image)resources.GetObject("BackHomePb.Image");
            BackHomePb.Location = new Point(929, 0);
            BackHomePb.Name = "BackHomePb";
            BackHomePb.Size = new Size(57, 48);
            BackHomePb.SizeMode = PictureBoxSizeMode.StretchImage;
            BackHomePb.TabIndex = 5;
            BackHomePb.TabStop = false;
            BackHomePb.Click += BackHomePb_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Yellow;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 128);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 417);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 255, 128);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1001, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 417);
            panel5.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(375, 122);
            label15.Name = "label15";
            label15.Size = new Size(94, 31);
            label15.TabIndex = 18;
            label15.Text = "Search";
            // 
            // SearchTb
            // 
            SearchTb.Location = new Point(465, 117);
            SearchTb.Multiline = true;
            SearchTb.Name = "SearchTb";
            SearchTb.Size = new Size(458, 36);
            SearchTb.TabIndex = 19;
            SearchTb.TextChanged += SearchTb_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(929, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // ListProductDgv
            // 
            ListProductDgv.BackgroundColor = Color.OldLace;
            ListProductDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListProductDgv.Location = new Point(375, 159);
            ListProductDgv.Name = "ListProductDgv";
            ListProductDgv.RowTemplate.Height = 25;
            ListProductDgv.Size = new Size(605, 261);
            ListProductDgv.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(60, 200);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 24;
            label3.Text = "ProductID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(60, 241);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 24;
            label2.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(60, 282);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 24;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(60, 320);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 24;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(60, 356);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 24;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(60, 394);
            label7.Name = "label7";
            label7.Size = new Size(57, 17);
            label7.TabIndex = 24;
            label7.Text = "Enabled";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(60, 161);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 24;
            label8.Text = "Image";
            // 
            // ProductIDTb
            // 
            ProductIDTb.Location = new Point(169, 199);
            ProductIDTb.Name = "ProductIDTb";
            ProductIDTb.Size = new Size(126, 23);
            ProductIDTb.TabIndex = 25;
            // 
            // ProductNameTb
            // 
            ProductNameTb.Location = new Point(169, 240);
            ProductNameTb.Name = "ProductNameTb";
            ProductNameTb.Size = new Size(157, 23);
            ProductNameTb.TabIndex = 25;
            // 
            // QuantityTx
            // 
            QuantityTx.Location = new Point(169, 320);
            QuantityTx.Name = "QuantityTx";
            QuantityTx.Size = new Size(157, 23);
            QuantityTx.TabIndex = 25;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(169, 355);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(157, 23);
            PriceTb.TabIndex = 25;
            // 
            // CategoryCb
            // 
            CategoryCb.Cursor = Cursors.Hand;
            CategoryCb.FormattingEnabled = true;
            CategoryCb.Location = new Point(169, 281);
            CategoryCb.Name = "CategoryCb";
            CategoryCb.Size = new Size(157, 23);
            CategoryCb.TabIndex = 26;
            // 
            // EnabledCb
            // 
            EnabledCb.Cursor = Cursors.Hand;
            EnabledCb.FormattingEnabled = true;
            EnabledCb.Location = new Point(169, 393);
            EnabledCb.Name = "EnabledCb";
            EnabledCb.Size = new Size(157, 23);
            EnabledCb.TabIndex = 26;
            // 
            // imgPb
            // 
            imgPb.Image = (Image)resources.GetObject("imgPb.Image");
            imgPb.Location = new Point(253, 115);
            imgPb.Name = "imgPb";
            imgPb.Size = new Size(73, 67);
            imgPb.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPb.TabIndex = 0;
            imgPb.TabStop = false;
            // 
            // ImgBtn
            // 
            ImgBtn.BackColor = Color.White;
            ImgBtn.Cursor = Cursors.Hand;
            ImgBtn.Location = new Point(169, 159);
            ImgBtn.Name = "ImgBtn";
            ImgBtn.Size = new Size(75, 23);
            ImgBtn.TabIndex = 27;
            ImgBtn.Text = "Browse";
            ImgBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Red;
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.Yellow;
            UpdateBtn.Location = new Point(194, 428);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(101, 40);
            UpdateBtn.TabIndex = 28;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // SearchIdPb
            // 
            SearchIdPb.Cursor = Cursors.Hand;
            SearchIdPb.Image = (Image)resources.GetObject("SearchIdPb.Image");
            SearchIdPb.Location = new Point(301, 200);
            SearchIdPb.Name = "SearchIdPb";
            SearchIdPb.Size = new Size(31, 24);
            SearchIdPb.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchIdPb.TabIndex = 22;
            SearchIdPb.TabStop = false;
            SearchIdPb.Click += SearchIdPb_Click;
            // 
            // ListProductsFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1019, 480);
            Controls.Add(UpdateBtn);
            Controls.Add(ImgBtn);
            Controls.Add(imgPb);
            Controls.Add(EnabledCb);
            Controls.Add(CategoryCb);
            Controls.Add(QuantityTx);
            Controls.Add(PriceTb);
            Controls.Add(ProductNameTb);
            Controls.Add(ProductIDTb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(ListProductDgv);
            Controls.Add(SearchIdPb);
            Controls.Add(pictureBox1);
            Controls.Add(SearchTb);
            Controls.Add(label15);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "ListProductsFrm";
            Text = "ListProducts";
            Load += ListProductsFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListProductDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchIdPb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox LogoPb;
        private Panel panel2;
        private Label BackHomeLb;
        private Label label12;
        private PictureBox BackHomePb;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel5;
        private Label label15;
        private TextBox SearchTb;
        private PictureBox pictureBox1;
        private DataGridView ListProductDgv;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox ProductIDTb;
        private TextBox ProductNameTb;
        private TextBox QuantityTx;
        private TextBox PriceTb;
        private ComboBox CategoryCb;
        private ComboBox EnabledCb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox3;
        private Button ImgBtn;
        private Button UpdateBtn;
        private PictureBox pictureBox4;
        private PictureBox SearchIdPb;
        private PictureBox imgPb;
    }
}