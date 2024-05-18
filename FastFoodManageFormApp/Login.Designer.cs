namespace FastFoodFormApp
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ExitLog = new Label();
            label1 = new Label();
            AccTb = new TextBox();
            AccLb = new Label();
            PassLb = new Label();
            PassTb = new TextBox();
            LoginBtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 255, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-46, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(ExitLog);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(206, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 58);
            panel1.TabIndex = 1;
            // 
            // ExitLog
            // 
            ExitLog.AutoSize = true;
            ExitLog.BackColor = Color.DarkRed;
            ExitLog.Cursor = Cursors.Hand;
            ExitLog.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ExitLog.ForeColor = Color.Yellow;
            ExitLog.Location = new Point(393, 0);
            ExitLog.Name = "ExitLog";
            ExitLog.Size = new Size(27, 30);
            ExitLog.TabIndex = 8;
            ExitLog.Text = "X";
            ExitLog.Click += ExitLog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(60, 15);
            label1.Name = "label1";
            label1.Size = new Size(268, 30);
            label1.TabIndex = 2;
            label1.Text = "FAST FOOD RESTAURANT";
            // 
            // AccTb
            // 
            AccTb.Location = new Point(376, 124);
            AccTb.Name = "AccTb";
            AccTb.Size = new Size(181, 23);
            AccTb.TabIndex = 2;
            // 
            // AccLb
            // 
            AccLb.AutoSize = true;
            AccLb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AccLb.ForeColor = Color.Red;
            AccLb.Location = new Point(238, 126);
            AccLb.Name = "AccLb";
            AccLb.Size = new Size(123, 21);
            AccLb.TabIndex = 3;
            AccLb.Text = "Account Name";
            // 
            // PassLb
            // 
            PassLb.AutoSize = true;
            PassLb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassLb.ForeColor = Color.Red;
            PassLb.Location = new Point(238, 168);
            PassLb.Name = "PassLb";
            PassLb.Size = new Size(82, 21);
            PassLb.TabIndex = 4;
            PassLb.Text = "Password";
            // 
            // PassTb
            // 
            PassTb.Location = new Point(376, 166);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(181, 23);
            PassTb.TabIndex = 5;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Red;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.Yellow;
            LoginBtn.Location = new Point(458, 209);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(99, 40);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(414, 67);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 7;
            label2.Text = "LOGIN";
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(625, 280);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(PassTb);
            Controls.Add(PassLb);
            Controls.Add(AccLb);
            Controls.Add(AccTb);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox AccTb;
        private Label AccLb;
        private Label PassLb;
        private TextBox PassTb;
        private Button LoginBtn;
        private Label label2;
        private Label ExitLog;
    }
}