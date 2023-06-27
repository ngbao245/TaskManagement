namespace TaskManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            pnl = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            e = new Panel();
            checkboxShowPass = new CheckBox();
            forgetpass = new Label();
            btnRegis1 = new LinkLabel();
            txtUserName = new TextBox();
            panel3 = new Panel();
            txtPassword = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnLogin = new RJButton();
            btnCloseLogin = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pnlPassword = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            e.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseLogin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 469);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnl);
            panel2.Controls.Add(e);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(747, 469);
            panel2.TabIndex = 2;
            // 
            // pnl
            // 
            pnl.BackColor = Color.FromArgb(247, 188, 205);
            pnl.Controls.Add(label7);
            pnl.Controls.Add(pictureBox1);
            pnl.Dock = DockStyle.Left;
            pnl.ForeColor = Color.White;
            pnl.Location = new Point(0, 0);
            pnl.Margin = new Padding(0);
            pnl.Name = "pnl";
            pnl.Size = new Size(370, 469);
            pnl.TabIndex = 3;
            // 
            // label7
            // 
            label7.Location = new Point(45, 286);
            label7.Name = "label7";
            label7.Size = new Size(270, 50);
            label7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.z4441320674002_9658adeb31fac49aab0c99be5a77549a;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // e
            // 
            e.BackColor = Color.FromArgb(179, 211, 234);
            e.Controls.Add(checkboxShowPass);
            e.Controls.Add(forgetpass);
            e.Controls.Add(btnRegis1);
            e.Controls.Add(txtUserName);
            e.Controls.Add(panel3);
            e.Controls.Add(txtPassword);
            e.Controls.Add(label6);
            e.Controls.Add(label1);
            e.Controls.Add(btnLogin);
            e.Controls.Add(btnCloseLogin);
            e.Controls.Add(label5);
            e.Controls.Add(label4);
            e.Controls.Add(pnlPassword);
            e.Controls.Add(label3);
            e.Controls.Add(label2);
            e.Dock = DockStyle.Fill;
            e.Location = new Point(0, 0);
            e.Margin = new Padding(0);
            e.Name = "e";
            e.Size = new Size(747, 469);
            e.TabIndex = 2;
            // 
            // checkboxShowPass
            // 
            checkboxShowPass.AutoSize = true;
            checkboxShowPass.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkboxShowPass.Location = new Point(391, 260);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new Size(158, 28);
            checkboxShowPass.TabIndex = 103;
            checkboxShowPass.Text = "Show Password";
            checkboxShowPass.UseVisualStyleBackColor = true;
            checkboxShowPass.CheckedChanged += checkboxShowPass_CheckedChanged;
            // 
            // forgetpass
            // 
            forgetpass.AutoSize = true;
            forgetpass.Font = new Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            forgetpass.ForeColor = Color.FromArgb(0, 0, 192);
            forgetpass.Location = new Point(566, 264);
            forgetpass.Name = "forgetpass";
            forgetpass.Size = new Size(159, 20);
            forgetpass.TabIndex = 102;
            forgetpass.Text = "forgot your password?";
            forgetpass.Click += forgetpass_Click;
            // 
            // btnRegis1
            // 
            btnRegis1.ActiveLinkColor = Color.DarkRed;
            btnRegis1.AutoSize = true;
            btnRegis1.LinkColor = Color.FromArgb(0, 0, 192);
            btnRegis1.Location = new Point(490, 421);
            btnRegis1.Name = "btnRegis1";
            btnRegis1.Size = new Size(137, 23);
            btnRegis1.TabIndex = 101;
            btnRegis1.TabStop = true;
            btnRegis1.Text = "Register Now";
            btnRegis1.Click += btnRegis_Click_1;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(402, 119);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Enter your Username";
            txtUserName.Size = new Size(310, 25);
            txtUserName.TabIndex = 99;
            txtUserName.TextChanged += txt_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(240, 198, 214);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(391, 146);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(334, 10);
            panel3.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(402, 208);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your Password";
            txtPassword.Size = new Size(310, 25);
            txtPassword.TabIndex = 100;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txt_Leave;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(391, 112);
            label6.Name = "label6";
            label6.Size = new Size(334, 41);
            label6.TabIndex = 37;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(19, 53, 71);
            label1.Location = new Point(416, 22);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 1;
            label1.Text = "Task Managerment";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.BackgroundColor = Color.White;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Roboto Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(179, 211, 234);
            btnLogin.Location = new Point(391, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(334, 50);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Log in";
            btnLogin.TextColor = Color.FromArgb(179, 211, 234);
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.Image = Properties.Resources.img_419309;
            btnCloseLogin.Location = new Point(705, 12);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(30, 30);
            btnCloseLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCloseLogin.TabIndex = 29;
            btnCloseLogin.TabStop = false;
            btnCloseLogin.Click += btnCloseLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(546, 379);
            label5.Name = "label5";
            label5.Size = new Size(24, 22);
            label5.TabIndex = 28;
            label5.Text = "or";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(391, 170);
            label4.Name = "label4";
            label4.Size = new Size(88, 24);
            label4.TabIndex = 26;
            label4.Text = "Password";
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(240, 198, 214);
            pnlPassword.ForeColor = Color.White;
            pnlPassword.Location = new Point(391, 235);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Padding = new Padding(0, 0, 0, 3);
            pnlPassword.Size = new Size(334, 10);
            pnlPassword.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(391, 81);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 24;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(391, 201);
            label2.Name = "label2";
            label2.Size = new Size(334, 41);
            label2.TabIndex = 34;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 469);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(747, 469);
            MinimumSize = new Size(747, 469);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            e.ResumeLayout(false);
            e.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnl;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel e;
        private Button btnRegis;
        private PictureBox btnCloseLogin;
        private Label label5;
        private Label label4;
        private Panel pnlPassword;
        private TextBox txtPassword;
        private Label label3;
        private RJButton btnLogin;
        private TextBox txtUserName;
        private Panel panel3;
        private Label label6;
        private Label label2;
        private Label forgetpass;
        private LinkLabel btnRegis1;
        private Label label7;
        private CheckBox checkboxShowPass;
    }
}