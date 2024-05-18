namespace FastFoodFormApp
{
    partial class AddCategoryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryFrm));
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
            AddCategoriesDgv = new DataGridView();
            label4 = new Label();
            label2 = new Label();
            CategoryNameTb = new TextBox();
            EnabledCb = new ComboBox();
            AddBtn = new Button();
            AddAllBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCategoriesDgv).BeginInit();
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
            panel1.TabIndex = 4;
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
            label12.Location = new Point(82, 13);
            label12.Name = "label12";
            label12.Size = new Size(136, 25);
            label12.TabIndex = 10;
            label12.Text = "Add Category";
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
            pictureBox2.Size = new Size(76, 48);
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
            panel4.Size = new Size(18, 387);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 255, 128);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1001, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 387);
            panel5.TabIndex = 18;
            // 
            // AddCategoriesDgv
            // 
            AddCategoriesDgv.BackgroundColor = Color.OldLace;
            AddCategoriesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddCategoriesDgv.Location = new Point(311, 135);
            AddCategoriesDgv.Name = "AddCategoriesDgv";
            AddCategoriesDgv.RowTemplate.Height = 25;
            AddCategoriesDgv.Size = new Size(666, 261);
            AddCategoriesDgv.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(37, 189);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 20;
            label4.Text = "Category Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(37, 233);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 20;
            label2.Text = "Enabled";
            // 
            // CategoryNameTb
            // 
            CategoryNameTb.Location = new Point(147, 188);
            CategoryNameTb.Name = "CategoryNameTb";
            CategoryNameTb.Size = new Size(126, 23);
            CategoryNameTb.TabIndex = 22;
            // 
            // EnabledCb
            // 
            EnabledCb.Cursor = Cursors.Hand;
            EnabledCb.FormattingEnabled = true;
            EnabledCb.Items.AddRange(new object[] { "True", "False" });
            EnabledCb.Location = new Point(147, 232);
            EnabledCb.Name = "EnabledCb";
            EnabledCb.Size = new Size(126, 23);
            EnabledCb.TabIndex = 23;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Red;
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.Yellow;
            AddBtn.Location = new Point(164, 398);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(86, 40);
            AddBtn.TabIndex = 35;
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
            AddAllBtn.Location = new Point(779, 402);
            AddAllBtn.Name = "AddAllBtn";
            AddAllBtn.Size = new Size(198, 40);
            AddAllBtn.TabIndex = 36;
            AddAllBtn.Text = "Add All To List";
            AddAllBtn.UseVisualStyleBackColor = false;
            AddAllBtn.Click += AddAllBtn_Click;
            // 
            // AddCategoryFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1019, 450);
            Controls.Add(AddAllBtn);
            Controls.Add(AddBtn);
            Controls.Add(EnabledCb);
            Controls.Add(CategoryNameTb);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(AddCategoriesDgv);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "AddCategoryFrm";
            Text = "Add Category";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddCategoriesDgv).EndInit();
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
        private DataGridView AddCategoriesDgv;
        private Label label4;
        private Label label2;
        private TextBox CategoryNameTb;
        private ComboBox EnabledCb;
        private Button AddBtn;
        private Button AddAllBtn;
    }
}