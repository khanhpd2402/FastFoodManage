namespace FastFoodFormApp
{
    partial class AddProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductFrm));
            panel1 = new Panel();
            label1 = new Label();
            LogoPb = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            BackHomeLb = new Label();
            label12 = new Label();
            BackHomePb = new PictureBox();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            AddProductDgv = new DataGridView();
            ImgPb = new PictureBox();
            label8 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ImgBtn = new Button();
            ProductNameTb = new TextBox();
            QuantityTb = new TextBox();
            PriceTb = new TextBox();
            CategoryCb = new ComboBox();
            EnableCb = new ComboBox();
            AddBtn = new Button();
            AddAllBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddProductDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgPb).BeginInit();
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 128);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 417);
            panel4.TabIndex = 16;
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
            panel2.TabIndex = 17;
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
            label12.Location = new Point(76, 13);
            label12.Name = "label12";
            label12.Size = new Size(126, 25);
            label12.TabIndex = 10;
            label12.Text = "Add Product";
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
            pictureBox2.Size = new Size(70, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 255, 128);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1001, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 417);
            panel5.TabIndex = 18;
            // 
            // AddProductDgv
            // 
            AddProductDgv.BackgroundColor = Color.OldLace;
            AddProductDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddProductDgv.Location = new Point(347, 170);
            AddProductDgv.Name = "AddProductDgv";
            AddProductDgv.RowTemplate.Height = 25;
            AddProductDgv.Size = new Size(631, 243);
            AddProductDgv.TabIndex = 19;
            // 
            // ImgPb
            // 
            ImgPb.Image = (Image)resources.GetObject("ImgPb.Image");
            ImgPb.Location = new Point(240, 136);
            ImgPb.Name = "ImgPb";
            ImgPb.Size = new Size(73, 67);
            ImgPb.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgPb.TabIndex = 21;
            ImgPb.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(42, 182);
            label8.Name = "label8";
            label8.Size = new Size(46, 17);
            label8.TabIndex = 25;
            label8.Text = "Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(42, 222);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 26;
            label2.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(42, 264);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 27;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(42, 306);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 28;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(42, 351);
            label6.Name = "label6";
            label6.Size = new Size(38, 17);
            label6.TabIndex = 29;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(43, 391);
            label7.Name = "label7";
            label7.Size = new Size(57, 17);
            label7.TabIndex = 30;
            label7.Text = "Enabled";
            // 
            // ImgBtn
            // 
            ImgBtn.BackColor = Color.White;
            ImgBtn.Cursor = Cursors.Hand;
            ImgBtn.Location = new Point(156, 180);
            ImgBtn.Name = "ImgBtn";
            ImgBtn.Size = new Size(75, 23);
            ImgBtn.TabIndex = 31;
            ImgBtn.Text = "Browse";
            ImgBtn.UseVisualStyleBackColor = false;
            ImgBtn.Click += ImgBtn_Click;
            // 
            // ProductNameTb
            // 
            ProductNameTb.Location = new Point(156, 221);
            ProductNameTb.Name = "ProductNameTb";
            ProductNameTb.Size = new Size(157, 23);
            ProductNameTb.TabIndex = 32;
            // 
            // QuantityTb
            // 
            QuantityTb.Location = new Point(156, 305);
            QuantityTb.Name = "QuantityTb";
            QuantityTb.Size = new Size(157, 23);
            QuantityTb.TabIndex = 32;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(156, 350);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(157, 23);
            PriceTb.TabIndex = 32;
            // 
            // CategoryCb
            // 
            CategoryCb.Cursor = Cursors.Hand;
            CategoryCb.FormattingEnabled = true;
            CategoryCb.Location = new Point(156, 263);
            CategoryCb.Name = "CategoryCb";
            CategoryCb.Size = new Size(157, 23);
            CategoryCb.TabIndex = 33;
            // 
            // EnableCb
            // 
            EnableCb.Cursor = Cursors.Hand;
            EnableCb.FormattingEnabled = true;
            EnableCb.Items.AddRange(new object[] { "True", "False" });
            EnableCb.Location = new Point(156, 390);
            EnableCb.Name = "EnableCb";
            EnableCb.Size = new Size(157, 23);
            EnableCb.TabIndex = 33;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Red;
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.Yellow;
            AddBtn.Location = new Point(187, 428);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(86, 40);
            AddBtn.TabIndex = 34;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // AddAllBtn
            // 
            AddAllBtn.BackColor = Color.Red;
            AddAllBtn.Cursor = Cursors.Hand;
            AddAllBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddAllBtn.ForeColor = Color.Yellow;
            AddAllBtn.Location = new Point(780, 428);
            AddAllBtn.Name = "AddAllBtn";
            AddAllBtn.Size = new Size(198, 40);
            AddAllBtn.TabIndex = 35;
            AddAllBtn.Text = "Add All To List";
            AddAllBtn.UseVisualStyleBackColor = false;
            AddAllBtn.Click += AddAllBtn_Click;
            // 
            // AddProductFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1019, 480);
            Controls.Add(AddAllBtn);
            Controls.Add(AddBtn);
            Controls.Add(EnableCb);
            Controls.Add(CategoryCb);
            Controls.Add(PriceTb);
            Controls.Add(QuantityTb);
            Controls.Add(ProductNameTb);
            Controls.Add(ImgBtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(ImgPb);
            Controls.Add(AddProductDgv);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "AddProductFrm";
            Text = " ";
            Load += AddProductFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddProductDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgPb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox LogoPb;
        private Panel panel4;
        private Panel panel2;
        private Label BackHomeLb;
        private Label label12;
        private PictureBox BackHomePb;
        private PictureBox pictureBox2;
        private Panel panel5;
        private DataGridView AddProductDgv;
        private PictureBox ImgPb;
        private Label label8;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button ImgBtn;
        private TextBox ProductNameTb;
        private TextBox QuantityTb;
        private TextBox PriceTb;
        private ComboBox CategoryCb;
        private ComboBox EnableCb;
        private Button AddBtn;
        private Button AddAllBtn;
    }
}