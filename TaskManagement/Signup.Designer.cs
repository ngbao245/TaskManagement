namespace TaskManagement
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            pnlRegister = new Panel();
            checkboxShowPass = new CheckBox();
            btnRegister = new RJButton();
            txtUConPassRe = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            txtUPassRe = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            txtUNameRe = new TextBox();
            panel4 = new Panel();
            pnl = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            btnClose = new PictureBox();
            label9 = new Label();
            pnlRegister.SuspendLayout();
            pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.FromArgb(240, 198, 214);
            pnlRegister.Controls.Add(checkboxShowPass);
            pnlRegister.Controls.Add(btnRegister);
            pnlRegister.Controls.Add(txtUConPassRe);
            pnlRegister.Controls.Add(panel1);
            pnlRegister.Controls.Add(label7);
            pnlRegister.Controls.Add(label8);
            pnlRegister.Controls.Add(txtUPassRe);
            pnlRegister.Controls.Add(panel3);
            pnlRegister.Controls.Add(label4);
            pnlRegister.Controls.Add(label5);
            pnlRegister.Controls.Add(txtUNameRe);
            pnlRegister.Controls.Add(panel4);
            pnlRegister.Controls.Add(pnl);
            pnlRegister.Controls.Add(label6);
            pnlRegister.Controls.Add(label3);
            pnlRegister.Controls.Add(btnClose);
            pnlRegister.Controls.Add(label9);
            pnlRegister.Dock = DockStyle.Bottom;
            pnlRegister.Location = new Point(0, -2);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(747, 469);
            pnlRegister.TabIndex = 99;
            // 
            // checkboxShowPass
            // 
            checkboxShowPass.AutoSize = true;
            checkboxShowPass.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkboxShowPass.Location = new Point(350, 353);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new Size(158, 28);
            checkboxShowPass.TabIndex = 108;
            checkboxShowPass.Text = "Show Password";
            checkboxShowPass.UseVisualStyleBackColor = true;
            checkboxShowPass.CheckedChanged += checkboxShowPass_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.BackgroundColor = Color.White;
            btnRegister.BorderColor = Color.PaleVioletRed;
            btnRegister.BorderRadius = 20;
            btnRegister.BorderSize = 0;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Roboto Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.FromArgb(240, 198, 214);
            btnRegister.Location = new Point(361, 397);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(310, 50);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER";
            btnRegister.TextColor = Color.FromArgb(240, 198, 214);
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUConPassRe
            // 
            txtUConPassRe.BackColor = Color.White;
            txtUConPassRe.BorderStyle = BorderStyle.None;
            txtUConPassRe.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUConPassRe.ForeColor = Color.Black;
            txtUConPassRe.Location = new Point(361, 301);
            txtUConPassRe.Name = "txtUConPassRe";
            txtUConPassRe.PlaceholderText = "Confirm Password";
            txtUConPassRe.Size = new Size(310, 25);
            txtUConPassRe.TabIndex = 104;
            txtUConPassRe.UseSystemPasswordChar = true;
            txtUConPassRe.TextChanged += txt_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 211, 234);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(350, 328);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(334, 10);
            panel1.TabIndex = 106;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(350, 294);
            label7.Name = "label7";
            label7.Size = new Size(334, 41);
            label7.TabIndex = 107;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(350, 263);
            label8.Name = "label8";
            label8.Size = new Size(155, 24);
            label8.TabIndex = 105;
            label8.Text = "Confirm Password";
            // 
            // txtUPassRe
            // 
            txtUPassRe.BackColor = Color.White;
            txtUPassRe.BorderStyle = BorderStyle.None;
            txtUPassRe.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUPassRe.ForeColor = Color.Black;
            txtUPassRe.Location = new Point(361, 203);
            txtUPassRe.Name = "txtUPassRe";
            txtUPassRe.PlaceholderText = "Enter Password";
            txtUPassRe.Size = new Size(310, 25);
            txtUPassRe.TabIndex = 100;
            txtUPassRe.UseSystemPasswordChar = true;
            txtUPassRe.TextChanged += txt_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(179, 211, 234);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(350, 230);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(334, 10);
            panel3.TabIndex = 102;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(350, 196);
            label4.Name = "label4";
            label4.Size = new Size(334, 41);
            label4.TabIndex = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(350, 165);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 101;
            label5.Text = "Password";
            // 
            // txtUNameRe
            // 
            txtUNameRe.BackColor = Color.White;
            txtUNameRe.BorderStyle = BorderStyle.None;
            txtUNameRe.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUNameRe.ForeColor = Color.Black;
            txtUNameRe.Location = new Point(361, 106);
            txtUNameRe.Name = "txtUNameRe";
            txtUNameRe.PlaceholderText = "Enter Username";
            txtUNameRe.Size = new Size(310, 25);
            txtUNameRe.TabIndex = 38;
            txtUNameRe.TextChanged += txt_Leave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(179, 211, 234);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(350, 133);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 3);
            panel4.Size = new Size(334, 10);
            panel4.TabIndex = 40;
            // 
            // pnl
            // 
            pnl.BackColor = Color.FromArgb(179, 211, 234);
            pnl.Controls.Add(label2);
            pnl.Controls.Add(pictureBox2);
            pnl.ForeColor = Color.White;
            pnl.Location = new Point(0, 0);
            pnl.Margin = new Padding(0);
            pnl.Name = "pnl";
            pnl.Size = new Size(312, 469);
            pnl.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 307);
            label2.Name = "label2";
            label2.Size = new Size(246, 29);
            label2.TabIndex = 1;
            label2.Text = "Task Managerment";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.shield___Copy;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.MaximumSize = new Size(312, 280);
            pictureBox2.MinimumSize = new Size(312, 280);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(312, 280);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(350, 99);
            label6.Name = "label6";
            label6.Size = new Size(334, 41);
            label6.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(350, 68);
            label3.Name = "label3";
            label3.Size = new Size(89, 24);
            label3.TabIndex = 39;
            label3.Text = "Username";
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.img_419309;
            btnClose.Location = new Point(705, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 18;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(353, 26);
            label9.Name = "label9";
            label9.Size = new Size(100, 27);
            label9.TabIndex = 7;
            label9.Text = "SIGN UP";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 467);
            Controls.Add(pnlRegister);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRegister;
        private Label label9;
        private Panel pnl;
        private Label label2;
        private PictureBox btnClose;
        private PictureBox pictureBox2;
        private TextBox txtUNameRe;
        private Panel panel4;
        private Label label6;
        private Label label3;
        private TextBox txtUPassRe;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private TextBox txtUConPassRe;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private RJButton btnRegister;
        private CheckBox checkboxShowPass;
    }
}