namespace TaskManagement
{
    partial class Forget_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forget_Password));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnNewPass = new Button();
            btnBackLogin = new Button();
            label5 = new Label();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2889676;
            pictureBox1.Location = new Point(234, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(180, 182);
            label1.Name = "label1";
            label1.Size = new Size(249, 38);
            label1.TabIndex = 1;
            label1.Text = "Forgot Password ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 240);
            label2.Name = "label2";
            label2.Size = new Size(514, 56);
            label2.TabIndex = 4;
            label2.Text = "Change your password in three steps. This will help you to\r\n sercue your password!\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 309);
            label3.Name = "label3";
            label3.Size = new Size(401, 75);
            label3.TabIndex = 5;
            label3.Text = "1. Enter your email and username below\r\n2. Our system will send you an OTP to your email\r\n3. Enter the OTP on the next page\r\n";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.Location = new Point(171, 429);
            txtEmail.MaxLength = 300;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 27);
            txtEmail.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 431);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // btnNewPass
            // 
            btnNewPass.BackColor = SystemColors.ButtonHighlight;
            btnNewPass.Location = new Point(171, 536);
            btnNewPass.Name = "btnNewPass";
            btnNewPass.Size = new Size(124, 43);
            btnNewPass.TabIndex = 13;
            btnNewPass.Text = "New password";
            btnNewPass.UseVisualStyleBackColor = false;
            btnNewPass.Click += btnNewPass_Click;
            // 
            // btnBackLogin
            // 
            btnBackLogin.BackColor = SystemColors.ButtonHighlight;
            btnBackLogin.Location = new Point(370, 536);
            btnBackLogin.Name = "btnBackLogin";
            btnBackLogin.Size = new Size(124, 43);
            btnBackLogin.TabIndex = 9;
            btnBackLogin.Text = "Back to Login";
            btnBackLogin.UseVisualStyleBackColor = false;
            btnBackLogin.Click += btnBackLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 483);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 10;
            label5.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(171, 481);
            txtUsername.MaxLength = 300;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(323, 27);
            txtUsername.TabIndex = 12;
            // 
            // Forget_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 211, 234);
            ClientSize = new Size(608, 591);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(btnBackLogin);
            Controls.Add(btnNewPass);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Forget_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget_Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Button btnNewPass;
        private Button btnBackLogin;
        private Label label5;
        private TextBox txtUsername;
    }
}