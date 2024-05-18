namespace FastFoodFormApp
{
    partial class ListCategoryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCategoryFrm));
            panel1 = new Panel();
            label1 = new Label();
            LogoPb = new PictureBox();
            panel2 = new Panel();
            BackHomeLb = new Label();
            label12 = new Label();
            BackHomePb = new PictureBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            CategoryIDTb = new TextBox();
            ListCategoriesDgv = new DataGridView();
            label5 = new Label();
            CategoryTb = new ComboBox();
            label2 = new Label();
            EnableCb = new ComboBox();
            UpdateBtn = new Button();
            SearchIdPb = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListCategoriesDgv).BeginInit();
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
            panel1.TabIndex = 20;
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
            panel2.TabIndex = 21;
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
            label12.Size = new Size(141, 25);
            label12.TabIndex = 10;
            label12.Text = "List Categories";
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 128);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 392);
            panel4.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 128);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1001, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 392);
            panel3.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(24, 175);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 24;
            label3.Text = "CategoryID";
            // 
            // CategoryIDTb
            // 
            CategoryIDTb.Location = new Point(112, 174);
            CategoryIDTb.Name = "CategoryIDTb";
            CategoryIDTb.Size = new Size(167, 23);
            CategoryIDTb.TabIndex = 25;
            CategoryIDTb.TextAlign = HorizontalAlignment.Center;
            // 
            // ListCategoriesDgv
            // 
            ListCategoriesDgv.BackgroundColor = Color.OldLace;
            ListCategoriesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListCategoriesDgv.Location = new Point(341, 137);
            ListCategoriesDgv.Name = "ListCategoriesDgv";
            ListCategoriesDgv.RowTemplate.Height = 25;
            ListCategoriesDgv.Size = new Size(654, 265);
            ListCategoriesDgv.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(24, 226);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 38;
            label5.Text = "Category";
            // 
            // CategoryTb
            // 
            CategoryTb.FormattingEnabled = true;
            CategoryTb.Location = new Point(112, 225);
            CategoryTb.Name = "CategoryTb";
            CategoryTb.Size = new Size(206, 23);
            CategoryTb.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(24, 285);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 38;
            label2.Text = "Enabled";
            // 
            // EnableCb
            // 
            EnableCb.FormattingEnabled = true;
            EnableCb.Location = new Point(112, 284);
            EnableCb.Name = "EnableCb";
            EnableCb.Size = new Size(206, 23);
            EnableCb.TabIndex = 39;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Red;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.Yellow;
            UpdateBtn.Location = new Point(161, 403);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(74, 40);
            UpdateBtn.TabIndex = 40;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // SearchIdPb
            // 
            SearchIdPb.Cursor = Cursors.Hand;
            SearchIdPb.Image = (Image)resources.GetObject("SearchIdPb.Image");
            SearchIdPb.Location = new Point(287, 174);
            SearchIdPb.Name = "SearchIdPb";
            SearchIdPb.Size = new Size(31, 24);
            SearchIdPb.SizeMode = PictureBoxSizeMode.StretchImage;
            SearchIdPb.TabIndex = 41;
            SearchIdPb.TabStop = false;
            SearchIdPb.Click += SearchIdPb_Click;
            // 
            // ListCategoryFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1019, 455);
            Controls.Add(SearchIdPb);
            Controls.Add(UpdateBtn);
            Controls.Add(EnableCb);
            Controls.Add(CategoryTb);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(ListCategoriesDgv);
            Controls.Add(CategoryIDTb);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "ListCategoryFrm";
            Text = "List Categories";
            Load += ListCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListCategoriesDgv).EndInit();
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
        private Panel panel3;
        private Label label3;
        private TextBox CategoryIDTb;
        private DataGridView ListCategoriesDgv;
        private Label label5;
        private ComboBox CategoryTb;
        private Label label2;
        private ComboBox EnableCb;
        private Button UpdateBtn;
        private PictureBox SearchIdPb;
    }
}