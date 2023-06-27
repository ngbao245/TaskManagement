namespace TaskManagement
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            checkboxShowPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(370, 41);
            label1.TabIndex = 0;
            label1.Text = "Change Account Password\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 110);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 1;
            label2.Text = "New Password\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 157);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(251, 111);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(251, 158);
            txtConfirm.MaxLength = 100;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(240, 27);
            txtConfirm.TabIndex = 4;
            txtConfirm.UseSystemPasswordChar = true;
            txtConfirm.TextChanged += txtPassword_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(506, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 38);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(506, 258);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // checkboxShowPass
            // 
            checkboxShowPass.AutoSize = true;
            checkboxShowPass.Font = new Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkboxShowPass.Location = new Point(251, 194);
            checkboxShowPass.Name = "checkboxShowPass";
            checkboxShowPass.Size = new Size(158, 28);
            checkboxShowPass.TabIndex = 104;
            checkboxShowPass.Text = "Show Password";
            checkboxShowPass.UseVisualStyleBackColor = true;
            checkboxShowPass.CheckedChanged += checkboxShowPass_CheckedChanged;
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 159, 181);
            ClientSize = new Size(628, 308);
            Controls.Add(checkboxShowPass);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Change_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change_Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox checkboxShowPass;
    }
}