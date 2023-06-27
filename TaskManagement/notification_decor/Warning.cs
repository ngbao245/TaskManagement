using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement.notification_decor
{
    public partial class Warning : Form
    {
        public Warning(string msg)
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(244, 67, 54);
            label1.Text = msg;
        }

        private void Warning_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            show.Start();
        }

        int inverval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += inverval;
                inverval += 2;
            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Hide();
            }
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            close.Start();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            close.Start();
        }
    }
}
