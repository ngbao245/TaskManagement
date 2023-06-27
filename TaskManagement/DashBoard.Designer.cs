namespace TaskManagement
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            username = new Label();
            labelFullname = new Label();
            labelEmail = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            button1 = new Button();
            panel1 = new Panel();
            btnBack = new Button();
            panel3 = new Panel();
            Planned = new Label();
            panel2 = new Panel();
            Inprogress = new Label();
            panel4 = new Panel();
            monthCalendar = new MonthCalendar();
            pictureBox1 = new PictureBox();
            labelPriority = new Label();
            dgvDashBoard = new DataGridView();
            panel5 = new Panel();
            btnDelete = new Button();
            btnAddProject = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDashBoard).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(57, 27);
            username.Name = "username";
            username.Size = new Size(0, 20);
            username.TabIndex = 0;
            // 
            // labelFullname
            // 
            labelFullname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFullname.Location = new Point(24, 131);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(232, 28);
            labelFullname.TabIndex = 1;
            labelFullname.Text = "Fullname";
            labelFullname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            labelEmail.Location = new Point(24, 159);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(224, 21);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(24, 193);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter to Search";
            txtSearch.Size = new Size(257, 20);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(24, 229);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(157, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(79, 18);
            button1.Name = "button1";
            button1.Size = new Size(116, 110);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += UserDetail_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(179, 211, 234);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelFullname);
            panel1.Controls.Add(username);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 605);
            panel1.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(49, 434);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(182, 34);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(Planned);
            panel3.Location = new Point(1, 363);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 54);
            panel3.TabIndex = 9;
            // 
            // Planned
            // 
            Planned.AutoSize = true;
            Planned.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Planned.ForeColor = SystemColors.ButtonHighlight;
            Planned.Location = new Point(48, 12);
            Planned.Name = "Planned";
            Planned.Size = new Size(101, 31);
            Planned.TabIndex = 1;
            Planned.Text = "Planned";
            Planned.Click += Planned_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(Inprogress);
            panel2.Location = new Point(1, 285);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 58);
            panel2.TabIndex = 8;
            // 
            // Inprogress
            // 
            Inprogress.AutoSize = true;
            Inprogress.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Inprogress.ForeColor = SystemColors.ButtonHighlight;
            Inprogress.Location = new Point(41, 12);
            Inprogress.Name = "Inprogress";
            Inprogress.Size = new Size(127, 31);
            Inprogress.TabIndex = 0;
            Inprogress.Text = "Inprogress";
            Inprogress.Click += Inprogress_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(217, 159, 181);
            panel4.Controls.Add(monthCalendar);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(labelPriority);
            panel4.Controls.Add(dgvDashBoard);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(296, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(712, 604);
            panel4.TabIndex = 11;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(405, 18);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 18;
            monthCalendar.Visible = false;
            monthCalendar.MouseEnter += monthCalendar_MouseEnter;
            monthCalendar.MouseLeave += monthCalendar_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(607, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // labelPriority
            // 
            labelPriority.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPriority.Location = new Point(44, 18);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(225, 41);
            labelPriority.TabIndex = 15;
            labelPriority.Text = "List of Projects";
            // 
            // dgvDashBoard
            // 
            dgvDashBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDashBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDashBoard.BackgroundColor = SystemColors.Control;
            dgvDashBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashBoard.Location = new Point(44, 93);
            dgvDashBoard.Name = "dgvDashBoard";
            dgvDashBoard.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDashBoard.RowHeadersWidth = 51;
            dgvDashBoard.RowTemplate.Height = 29;
            dgvDashBoard.Size = new Size(623, 440);
            dgvDashBoard.TabIndex = 13;
            dgvDashBoard.CellClick += dgvDashBoard_CellClick;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnAddProject);
            panel5.Location = new Point(0, 539);
            panel5.Name = "panel5";
            panel5.Size = new Size(712, 65);
            panel5.TabIndex = 16;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(535, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 46);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddProject
            // 
            btnAddProject.Location = new Point(44, 7);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(132, 46);
            btnAddProject.TabIndex = 0;
            btnAddProject.Text = "New Project";
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 211, 234);
            ClientSize = new Size(1008, 604);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1026, 651);
            MinimumSize = new Size(1026, 651);
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += DashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDashBoard).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label username;
        private Label labelFullname;
        private Label labelEmail;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button button1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label Inprogress;
        private Label Planned;
        private Button btnBack;
        private Panel panel4;
        private Button btnDelete;
        private Button btnAddProject;
        private Label labelPriority;
        private DataGridView dgvDashBoard;
        private Panel panel5;
        private PictureBox pictureBox1;
        private MonthCalendar monthCalendar;
    }
}