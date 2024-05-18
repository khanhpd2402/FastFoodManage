namespace FastFoodFormApp
{
    partial class OrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetail));
            panel1 = new Panel();
            label1 = new Label();
            LogoPb = new PictureBox();
            panel2 = new Panel();
            BackListLb = new Label();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            BackListPb = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            AddEmployeeDgv = new DataGridView();
            label15 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackListPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddEmployeeDgv).BeginInit();
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
            panel1.Size = new Size(751, 63);
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
            panel2.Controls.Add(BackListLb);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(BackListPb);
            panel2.Location = new Point(12, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 48);
            panel2.TabIndex = 21;
            // 
            // BackListLb
            // 
            BackListLb.AutoSize = true;
            BackListLb.Cursor = Cursors.Hand;
            BackListLb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackListLb.Location = new Point(477, 13);
            BackListLb.Name = "BackListLb";
            BackListLb.Size = new Size(180, 25);
            BackListLb.TabIndex = 10;
            BackListLb.Text = "Back To List Orders";
            BackListLb.Click += BackListLb_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(88, 13);
            label12.Name = "label12";
            label12.Size = new Size(120, 25);
            label12.TabIndex = 10;
            label12.Text = "Order Detail";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Yellow;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // BackListPb
            // 
            BackListPb.BackColor = Color.Yellow;
            BackListPb.Cursor = Cursors.Hand;
            BackListPb.Image = (Image)resources.GetObject("BackListPb.Image");
            BackListPb.Location = new Point(663, 0);
            BackListPb.Name = "BackListPb";
            BackListPb.Size = new Size(61, 48);
            BackListPb.SizeMode = PictureBoxSizeMode.StretchImage;
            BackListPb.TabIndex = 5;
            BackListPb.TabStop = false;
            BackListPb.Click += BackListPb_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(55, 433);
            panel3.Name = "panel3";
            panel3.Size = new Size(645, 10);
            panel3.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 128);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 430);
            panel4.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 255, 128);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(733, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 430);
            panel5.TabIndex = 31;
            // 
            // AddEmployeeDgv
            // 
            AddEmployeeDgv.BackgroundColor = Color.OldLace;
            AddEmployeeDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddEmployeeDgv.Location = new Point(89, 161);
            AddEmployeeDgv.Name = "AddEmployeeDgv";
            AddEmployeeDgv.RowTemplate.Height = 25;
            AddEmployeeDgv.Size = new Size(580, 266);
            AddEmployeeDgv.TabIndex = 32;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(327, 127);
            label15.Name = "label15";
            label15.Size = new Size(56, 31);
            label15.TabIndex = 33;
            label15.Text = "Bill";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(559, 449);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 34;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = false;
            // 
            // OrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(751, 493);
            Controls.Add(button1);
            Controls.Add(label15);
            Controls.Add(AddEmployeeDgv);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "OrderDetail";
            Text = "OrderDetail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackListPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddEmployeeDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox LogoPb;
        private Panel panel2;
        private Label BackListLb;
        private Label label12;
        private PictureBox BackListPb;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridView AddEmployeeDgv;
        private Label label15;
        private Button button1;
    }
}