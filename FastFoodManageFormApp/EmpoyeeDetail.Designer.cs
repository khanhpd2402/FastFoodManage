namespace FastFoodFormApp
{
    partial class EmpoyeeDetailFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpoyeeDetailFrm));
            panel1 = new Panel();
            label1 = new Label();
            LogoPb = new PictureBox();
            panel2 = new Panel();
            BackManageLb = new Label();
            label12 = new Label();
            BackManagePb = new PictureBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel3 = new Panel();
            PrintBtn = new Button();
            AccountLb = new Label();
            FNameLb = new Label();
            PhoneNumLb = new Label();
            EmpIDLb = new Label();
            AddressLb = new Label();
            GenderLb = new Label();
            DOBLb = new Label();
            LNameLb = new Label();
            SalaryLb = new Label();
            PositionLb = new Label();
            HireDateLb = new Label();
            printPreviewDialogEmp = new PrintPreviewDialog();
            printDocumentEmp = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackManagePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel2.Controls.Add(BackManageLb);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(BackManagePb);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(18, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 48);
            panel2.TabIndex = 8;
            // 
            // BackManageLb
            // 
            BackManageLb.AutoSize = true;
            BackManageLb.Cursor = Cursors.Hand;
            BackManageLb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackManageLb.Location = new Point(403, 13);
            BackManageLb.Name = "BackManageLb";
            BackManageLb.Size = new Size(248, 25);
            BackManageLb.TabIndex = 10;
            BackManageLb.Text = "Back To Manage Employee";
            BackManageLb.Click += BackManageLb_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(88, 13);
            label12.Name = "label12";
            label12.Size = new Size(149, 25);
            label12.TabIndex = 10;
            label12.Text = "Empoyee Detail";
            // 
            // BackManagePb
            // 
            BackManagePb.BackColor = Color.Yellow;
            BackManagePb.Cursor = Cursors.Hand;
            BackManagePb.Image = (Image)resources.GetObject("BackManagePb.Image");
            BackManagePb.Location = new Point(657, 0);
            BackManagePb.Name = "BackManagePb";
            BackManagePb.Size = new Size(61, 48);
            BackManagePb.SizeMode = PictureBoxSizeMode.StretchImage;
            BackManagePb.TabIndex = 5;
            BackManagePb.TabStop = false;
            BackManagePb.Click += BackManagePb_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Yellow;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 48);
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
            panel4.Size = new Size(18, 430);
            panel4.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 255, 128);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(733, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 430);
            panel5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(106, 178);
            label4.Name = "label4";
            label4.Size = new Size(102, 17);
            label4.TabIndex = 16;
            label4.Text = "Account Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(106, 217);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 17;
            label6.Text = "Firsr Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(106, 304);
            label7.Name = "label7";
            label7.Size = new Size(106, 17);
            label7.TabIndex = 18;
            label7.Text = "Phone Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(435, 217);
            label5.Name = "label5";
            label5.Size = new Size(77, 17);
            label5.TabIndex = 20;
            label5.Text = "Last Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(106, 141);
            label8.Name = "label8";
            label8.Size = new Size(86, 17);
            label8.TabIndex = 21;
            label8.Text = "EmployeeID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(435, 263);
            label9.Name = "label9";
            label9.Size = new Size(50, 17);
            label9.TabIndex = 22;
            label9.Text = "Salary:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(106, 392);
            label10.Name = "label10";
            label10.Size = new Size(61, 17);
            label10.TabIndex = 23;
            label10.Text = "Address:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(106, 263);
            label11.Name = "label11";
            label11.Size = new Size(57, 17);
            label11.TabIndex = 24;
            label11.Text = "Gender:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(435, 304);
            label13.Name = "label13";
            label13.Size = new Size(63, 17);
            label13.TabIndex = 25;
            label13.Text = "Position:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(106, 353);
            label14.Name = "label14";
            label14.Size = new Size(94, 17);
            label14.TabIndex = 26;
            label14.Text = "Date Of Birth:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(435, 353);
            label15.Name = "label15";
            label15.Size = new Size(71, 17);
            label15.TabIndex = 27;
            label15.Text = "Hire Date:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(106, 428);
            panel3.Name = "panel3";
            panel3.Size = new Size(563, 10);
            panel3.TabIndex = 28;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.Red;
            PrintBtn.Cursor = Cursors.Hand;
            PrintBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PrintBtn.ForeColor = Color.Yellow;
            PrintBtn.Location = new Point(559, 444);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(110, 40);
            PrintBtn.TabIndex = 29;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = false;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // AccountLb
            // 
            AccountLb.AutoSize = true;
            AccountLb.BackColor = SystemColors.Control;
            AccountLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AccountLb.ForeColor = Color.FromArgb(0, 0, 192);
            AccountLb.Location = new Point(218, 178);
            AccountLb.Name = "AccountLb";
            AccountLb.Size = new Size(102, 17);
            AccountLb.TabIndex = 16;
            AccountLb.Text = "Account Name:";
            // 
            // FNameLb
            // 
            FNameLb.AutoSize = true;
            FNameLb.BackColor = SystemColors.Control;
            FNameLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FNameLb.ForeColor = Color.FromArgb(0, 0, 192);
            FNameLb.Location = new Point(218, 217);
            FNameLb.Name = "FNameLb";
            FNameLb.Size = new Size(79, 17);
            FNameLb.TabIndex = 17;
            FNameLb.Text = "Firsr Name:";
            // 
            // PhoneNumLb
            // 
            PhoneNumLb.AutoSize = true;
            PhoneNumLb.BackColor = SystemColors.Control;
            PhoneNumLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumLb.ForeColor = Color.FromArgb(0, 0, 192);
            PhoneNumLb.Location = new Point(218, 304);
            PhoneNumLb.Name = "PhoneNumLb";
            PhoneNumLb.Size = new Size(106, 17);
            PhoneNumLb.TabIndex = 18;
            PhoneNumLb.Text = "Phone Number:";
            // 
            // EmpIDLb
            // 
            EmpIDLb.AutoSize = true;
            EmpIDLb.BackColor = SystemColors.Control;
            EmpIDLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            EmpIDLb.ForeColor = Color.FromArgb(0, 0, 192);
            EmpIDLb.Location = new Point(218, 141);
            EmpIDLb.Name = "EmpIDLb";
            EmpIDLb.Size = new Size(86, 17);
            EmpIDLb.TabIndex = 21;
            EmpIDLb.Text = "EmployeeID:";
            // 
            // AddressLb
            // 
            AddressLb.AutoSize = true;
            AddressLb.BackColor = SystemColors.Control;
            AddressLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddressLb.ForeColor = Color.FromArgb(0, 0, 192);
            AddressLb.Location = new Point(218, 392);
            AddressLb.Name = "AddressLb";
            AddressLb.Size = new Size(61, 17);
            AddressLb.TabIndex = 23;
            AddressLb.Text = "Address:";
            // 
            // GenderLb
            // 
            GenderLb.AutoSize = true;
            GenderLb.BackColor = SystemColors.Control;
            GenderLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GenderLb.ForeColor = Color.FromArgb(0, 0, 192);
            GenderLb.Location = new Point(218, 263);
            GenderLb.Name = "GenderLb";
            GenderLb.Size = new Size(57, 17);
            GenderLb.TabIndex = 24;
            GenderLb.Text = "Gender:";
            // 
            // DOBLb
            // 
            DOBLb.AutoSize = true;
            DOBLb.BackColor = SystemColors.Control;
            DOBLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DOBLb.ForeColor = Color.FromArgb(0, 0, 192);
            DOBLb.Location = new Point(218, 353);
            DOBLb.Name = "DOBLb";
            DOBLb.Size = new Size(94, 17);
            DOBLb.TabIndex = 26;
            DOBLb.Text = "Date Of Birth:";
            // 
            // LNameLb
            // 
            LNameLb.AutoSize = true;
            LNameLb.BackColor = SystemColors.Control;
            LNameLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LNameLb.ForeColor = Color.FromArgb(0, 0, 192);
            LNameLb.Location = new Point(518, 217);
            LNameLb.Name = "LNameLb";
            LNameLb.Size = new Size(77, 17);
            LNameLb.TabIndex = 20;
            LNameLb.Text = "Last Name:";
            // 
            // SalaryLb
            // 
            SalaryLb.AutoSize = true;
            SalaryLb.BackColor = SystemColors.Control;
            SalaryLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SalaryLb.ForeColor = Color.FromArgb(0, 0, 192);
            SalaryLb.Location = new Point(518, 263);
            SalaryLb.Name = "SalaryLb";
            SalaryLb.Size = new Size(50, 17);
            SalaryLb.TabIndex = 22;
            SalaryLb.Text = "Salary:";
            // 
            // PositionLb
            // 
            PositionLb.AutoSize = true;
            PositionLb.BackColor = SystemColors.Control;
            PositionLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PositionLb.ForeColor = Color.FromArgb(0, 0, 192);
            PositionLb.Location = new Point(518, 304);
            PositionLb.Name = "PositionLb";
            PositionLb.Size = new Size(63, 17);
            PositionLb.TabIndex = 25;
            PositionLb.Text = "Position:";
            // 
            // HireDateLb
            // 
            HireDateLb.AutoSize = true;
            HireDateLb.BackColor = SystemColors.Control;
            HireDateLb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HireDateLb.ForeColor = Color.FromArgb(0, 0, 192);
            HireDateLb.Location = new Point(518, 353);
            HireDateLb.Name = "HireDateLb";
            HireDateLb.Size = new Size(71, 17);
            HireDateLb.TabIndex = 27;
            HireDateLb.Text = "Hire Date:";
            // 
            // printPreviewDialogEmp
            // 
            printPreviewDialogEmp.AutoScrollMargin = new Size(0, 0);
            printPreviewDialogEmp.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialogEmp.ClientSize = new Size(400, 300);
            printPreviewDialogEmp.Document = printDocumentEmp;
            printPreviewDialogEmp.Enabled = true;
            printPreviewDialogEmp.Icon = (Icon)resources.GetObject("printPreviewDialogEmp.Icon");
            printPreviewDialogEmp.Name = "printPreviewDialogEmp";
            printPreviewDialogEmp.Visible = false;
            // 
            // printDocumentEmp
            // 
            printDocumentEmp.PrintPage += printDocumentEmp_PrintPage;
            // 
            // EmpoyeeDetailFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(751, 493);
            Controls.Add(PrintBtn);
            Controls.Add(panel3);
            Controls.Add(HireDateLb);
            Controls.Add(label15);
            Controls.Add(DOBLb);
            Controls.Add(label14);
            Controls.Add(PositionLb);
            Controls.Add(label13);
            Controls.Add(GenderLb);
            Controls.Add(label11);
            Controls.Add(AddressLb);
            Controls.Add(label10);
            Controls.Add(SalaryLb);
            Controls.Add(label9);
            Controls.Add(EmpIDLb);
            Controls.Add(LNameLb);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(PhoneNumLb);
            Controls.Add(FNameLb);
            Controls.Add(label7);
            Controls.Add(AccountLb);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "EmpoyeeDetailFrm";
            Text = "Empoyee Detail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackManagePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox LogoPb;
        private Panel panel2;
        private Label BackManageLb;
        private Label label12;
        private PictureBox BackManagePb;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel3;
        private Button PrintBtn;
        private Label AccountLb;
        private Label FNameLb;
        private Label PhoneNumLb;
        private Label EmpIDLb;
        private Label AddressLb;
        private Label GenderLb;
        private Label DOBLb;
        private Label LNameLb;
        private Label SalaryLb;
        private Label PositionLb;
        private Label HireDateLb;
        private PrintPreviewDialog printPreviewDialogEmp;
        private System.Drawing.Printing.PrintDocument printDocumentEmp;
    }
}