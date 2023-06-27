namespace TaskManagement
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboStatus = new ComboBox();
            btnAdd = new RJButton();
            txtProjectName = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            dtpDeadline = new DateTimePicker();
            label7 = new Label();
            txtDescription = new TextBox();
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            rtbProjectName = new RichTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 163);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Project Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 217);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Deadline";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 272);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 334);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(126, 267);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(333, 28);
            cboStatus.TabIndex = 61;
            cboStatus.SelectedValueChanged += txtProjectName_Leave;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.IndianRed;
            btnAdd.BackgroundColor = Color.IndianRed;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 20;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Roboto Condensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(179, 211, 234);
            btnAdd.Location = new Point(22, 392);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(439, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Create";
            btnAdd.TextColor = Color.FromArgb(179, 211, 234);
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProjectName
            // 
            txtProjectName.BackColor = Color.White;
            txtProjectName.BorderStyle = BorderStyle.None;
            txtProjectName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtProjectName.ForeColor = Color.Black;
            txtProjectName.Location = new Point(137, 160);
            txtProjectName.MaxLength = 30;
            txtProjectName.Name = "txtProjectName";
            txtProjectName.PlaceholderText = "Enter Project Name";
            txtProjectName.Size = new Size(310, 25);
            txtProjectName.TabIndex = 41;
            txtProjectName.TextChanged += txtProjectName_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(179, 211, 234);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(126, 187);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 3);
            panel3.Size = new Size(334, 10);
            panel3.TabIndex = 42;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(126, 153);
            label6.Name = "label6";
            label6.Size = new Size(334, 41);
            label6.TabIndex = 43;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(179, 211, 234);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(127, 243);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 0, 3);
            panel4.Size = new Size(334, 10);
            panel4.TabIndex = 50;
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(127, 212);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(334, 27);
            dtpDeadline.TabIndex = 51;
            dtpDeadline.ValueChanged += txtProjectName_Leave;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(127, 209);
            label7.Name = "label7";
            label7.Size = new Size(334, 41);
            label7.TabIndex = 52;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(137, 329);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter Description";
            txtDescription.Size = new Size(310, 25);
            txtDescription.TabIndex = 71;
            txtDescription.TextChanged += txtProjectName_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(179, 211, 234);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(126, 356);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 3);
            panel1.Size = new Size(334, 10);
            panel1.TabIndex = 54;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Location = new Point(126, 322);
            label8.Name = "label8";
            label8.Size = new Size(334, 41);
            label8.TabIndex = 55;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(179, 211, 234);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(126, 299);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 3);
            panel2.Size = new Size(334, 10);
            panel2.TabIndex = 57;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Location = new Point(126, 265);
            label9.Name = "label9";
            label9.Size = new Size(334, 41);
            label9.TabIndex = 58;
            // 
            // rtbProjectName
            // 
            rtbProjectName.BackColor = Color.FromArgb(247, 188, 205);
            rtbProjectName.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            rtbProjectName.ForeColor = Color.Black;
            rtbProjectName.Location = new Point(22, 12);
            rtbProjectName.MaxLength = 45;
            rtbProjectName.Name = "rtbProjectName";
            rtbProjectName.ReadOnly = true;
            rtbProjectName.RightToLeft = RightToLeft.No;
            rtbProjectName.ScrollBars = RichTextBoxScrollBars.None;
            rtbProjectName.Size = new Size(439, 102);
            rtbProjectName.TabIndex = 599;
            rtbProjectName.Text = "";
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 211, 234);
            ClientSize = new Size(482, 458);
            Controls.Add(rtbProjectName);
            Controls.Add(panel2);
            Controls.Add(txtDescription);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(panel4);
            Controls.Add(dtpDeadline);
            Controls.Add(label7);
            Controls.Add(txtProjectName);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(btnAdd);
            Controls.Add(cboStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(-30, 3);
            MaximizeBox = false;
            Name = "ProjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProjectForm";
            Load += ProjectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboStatus;
        private RJButton btnAdd;
        private TextBox txtProjectName;
        private Panel panel3;
        private Label label6;
        private Panel panel4;
        private DateTimePicker dtpDeadline;
        private Label label7;
        private TextBox txtDescription;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private Label label9;
        private RichTextBox rtbProjectName;
        //private RJButton btnAdd;
    }
}