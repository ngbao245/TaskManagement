namespace TaskManagement
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label8 = new Label();
            dtBirthday = new DateTimePicker();
            label6 = new Label();
            label3 = new Label();
            abc = new Label();
            label9 = new Label();
            txtFullname = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txtPhonenum = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            txtEmail = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            btnSave = new RJButton();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(32, 99);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 11;
            label8.Text = "Fullname";
            // 
            // dtBirthday
            // 
            dtBirthday.Location = new Point(32, 253);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.Size = new Size(334, 27);
            dtBirthday.TabIndex = 48;
            dtBirthday.ValueChanged += txt_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 220);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 24;
            label6.Text = "Birthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(396, 220);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 32;
            label3.Text = "Email";
            // 
            // abc
            // 
            abc.AutoSize = true;
            abc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abc.Location = new Point(396, 99);
            abc.Name = "abc";
            abc.Size = new Size(157, 23);
            abc.TabIndex = 30;
            abc.Text = "Phone Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(281, 24);
            label9.Name = "label9";
            label9.Size = new Size(168, 27);
            label9.TabIndex = 34;
            label9.Text = "INFORMATION";
            // 
            // txtFullname
            // 
            txtFullname.BackColor = Color.White;
            txtFullname.BorderStyle = BorderStyle.None;
            txtFullname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFullname.ForeColor = Color.Black;
            txtFullname.Location = new Point(43, 135);
            txtFullname.Name = "txtFullname";
            txtFullname.PlaceholderText = "Enter Full Name";
            txtFullname.Size = new Size(310, 25);
            txtFullname.TabIndex = 38;
            txtFullname.TextChanged += txt_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(179, 211, 234);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(32, 162);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(334, 10);
            panel3.TabIndex = 39;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(32, 128);
            label2.Name = "label2";
            label2.Size = new Size(334, 41);
            label2.TabIndex = 40;
            // 
            // txtPhonenum
            // 
            txtPhonenum.BackColor = Color.White;
            txtPhonenum.BorderStyle = BorderStyle.None;
            txtPhonenum.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhonenum.ForeColor = Color.Black;
            txtPhonenum.Location = new Point(407, 135);
            txtPhonenum.Name = "txtPhonenum";
            txtPhonenum.PlaceholderText = "Enter Phone Number";
            txtPhonenum.Size = new Size(310, 25);
            txtPhonenum.TabIndex = 41;
            txtPhonenum.TextChanged += txt_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 211, 234);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(396, 162);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(334, 10);
            panel1.TabIndex = 42;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(396, 128);
            label4.Name = "label4";
            label4.Size = new Size(334, 41);
            label4.TabIndex = 43;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(407, 257);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.Size = new Size(310, 25);
            txtEmail.TabIndex = 44;
            txtEmail.TextChanged += txt_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(179, 211, 234);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(396, 284);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 3);
            panel2.Size = new Size(334, 10);
            panel2.TabIndex = 45;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(396, 250);
            label5.Name = "label5";
            label5.Size = new Size(334, 41);
            label5.TabIndex = 46;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(179, 211, 234);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(32, 284);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 3);
            panel4.Size = new Size(334, 10);
            panel4.TabIndex = 48;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(32, 250);
            label7.Name = "label7";
            label7.Size = new Size(334, 41);
            label7.TabIndex = 49;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.BackgroundColor = Color.White;
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Roboto Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(240, 198, 214);
            btnSave.Location = new Point(165, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(428, 50);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.TextColor = Color.FromArgb(240, 198, 214);
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 198, 214);
            ClientSize = new Size(747, 469);
            Controls.Add(btnSave);
            Controls.Add(panel4);
            Controls.Add(txtEmail);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(txtPhonenum);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(txtFullname);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(abc);
            Controls.Add(dtBirthday);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(747, 469);
            MinimumSize = new Size(747, 469);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox txtFullnamsse;
        private DateTimePicker dtBirthday;
        private Label label6;
        private Label label3;
        private Label abc;
        private Label label9;
        private TextBox txtFullname;
        private Panel panel3;
        private Label label2;
        private TextBox txtPhonenum;
        private Panel panel1;
        private Label label4;
        private TextBox txtEmail;
        private Panel panel2;
        private Label label5;
        private Panel panel4;
        private Label label7;
        private RJButton btnSave;
    }
}