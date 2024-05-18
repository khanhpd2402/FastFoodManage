namespace FastFoodFormApp
{
    partial class ListOrdersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOrdersFrm));
            panel2 = new Panel();
            BackHomeLb = new Label();
            label12 = new Label();
            BackHomePb = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            LogoPb = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            EmpIDTbTb = new TextBox();
            label3 = new Label();
            SDateTimePicker = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            EDateTimePicker = new DateTimePicker();
            CategoriesCb = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            ListOrdersDgv = new DataGridView();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListOrdersDgv).BeginInit();
            SuspendLayout();
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
            panel2.TabIndex = 18;
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
            label12.Size = new Size(107, 25);
            label12.TabIndex = 10;
            label12.Text = "List Orders";
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
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoPb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 63);
            panel1.TabIndex = 19;
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
            panel4.Size = new Size(18, 392);
            panel4.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.BackColor = Color.FromArgb(255, 255, 128);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1001, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 392);
            panel5.TabIndex = 21;
            // 
            // EmpIDTbTb
            // 
            EmpIDTbTb.Location = new Point(128, 156);
            EmpIDTbTb.Name = "EmpIDTbTb";
            EmpIDTbTb.Size = new Size(206, 23);
            EmpIDTbTb.TabIndex = 23;
            EmpIDTbTb.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(40, 157);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 22;
            label3.Text = "EmployeeID";
            // 
            // SDateTimePicker
            // 
            SDateTimePicker.Location = new Point(128, 211);
            SDateTimePicker.Name = "SDateTimePicker";
            SDateTimePicker.Size = new Size(206, 23);
            SDateTimePicker.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(40, 215);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 22;
            label2.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(40, 272);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 22;
            label4.Text = "End Date";
            // 
            // EDateTimePicker
            // 
            EDateTimePicker.Location = new Point(128, 268);
            EDateTimePicker.Name = "EDateTimePicker";
            EDateTimePicker.Size = new Size(206, 23);
            EDateTimePicker.TabIndex = 24;
            // 
            // CategoriesCb
            // 
            CategoriesCb.FormattingEnabled = true;
            CategoriesCb.Location = new Point(128, 323);
            CategoriesCb.Name = "CategoriesCb";
            CategoriesCb.Size = new Size(206, 23);
            CategoriesCb.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(40, 324);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 34;
            label5.Text = "Category";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(179, 406);
            button2.Name = "button2";
            button2.Size = new Size(74, 40);
            button2.TabIndex = 38;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ListOrdersDgv
            // 
            ListOrdersDgv.BackgroundColor = Color.OldLace;
            ListOrdersDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListOrdersDgv.Location = new Point(353, 139);
            ListOrdersDgv.Name = "ListOrdersDgv";
            ListOrdersDgv.RowTemplate.Height = 25;
            ListOrdersDgv.Size = new Size(630, 261);
            ListOrdersDgv.TabIndex = 36;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(847, 406);
            button1.Name = "button1";
            button1.Size = new Size(136, 40);
            button1.TabIndex = 38;
            button1.Text = "View Detail";
            button1.UseVisualStyleBackColor = false;
            // 
            // ListOrdersFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1019, 455);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(ListOrdersDgv);
            Controls.Add(CategoriesCb);
            Controls.Add(label5);
            Controls.Add(EDateTimePicker);
            Controls.Add(SDateTimePicker);
            Controls.Add(label4);
            Controls.Add(EmpIDTbTb);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "ListOrdersFrm";
            Text = "ListOrders";
            Load += ListOrdersFrm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackHomePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListOrdersDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label BackHomeLb;
        private Label label12;
        private PictureBox BackHomePb;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private PictureBox LogoPb;
        private Panel panel4;
        private Panel panel5;
        private TextBox EmpIDTbTb;
        private Label label3;
        private DateTimePicker SDateTimePicker;
        private Label label2;
        private Label label4;
        private DateTimePicker EDateTimePicker;
        private ComboBox CategoriesCb;
        private Label label5;
        private Button button2;
        private DataGridView ListOrdersDgv;
        private Button button1;
    }
}