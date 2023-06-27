namespace TaskManagement
{
    partial class OTP_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTP_Form));
            btnEnter = new Button();
            txtOtp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(364, 194);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(114, 39);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtOtp
            // 
            txtOtp.Location = new Point(124, 149);
            txtOtp.MaxLength = 30;
            txtOtp.Name = "txtOtp";
            txtOtp.PlaceholderText = "Enter OTP Verification Code";
            txtOtp.Size = new Size(354, 27);
            txtOtp.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(124, 112);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 9;
            label2.Text = "Verification Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 45);
            label1.Name = "label1";
            label1.Size = new Size(229, 38);
            label1.TabIndex = 8;
            label1.Text = "OTP Verification\r\n";
            // 
            // OTP_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 211, 234);
            ClientSize = new Size(602, 279);
            Controls.Add(btnEnter);
            Controls.Add(txtOtp);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OTP_Form";
            Text = "OTP_Form";
            Load += OTP_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private TextBox txtOtp;
        private Label label2;
        private Label label1;
    }
}