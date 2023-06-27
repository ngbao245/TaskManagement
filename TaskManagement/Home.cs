using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            logoutToolStripMenuItem.Enabled = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login lgLam = new Login();
            this.Opacity -= 0.8;
            //this.Hide();
            lgLam.ShowDialog();
            if (Home.ActiveForm != null)
            {
                this.Opacity += 0.8;
            }
            else this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Opacity -= 0.8;
            signup.ShowDialog();
            if (Home.ActiveForm != null)
            {
                this.Opacity += 0.8;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoPage infoPage = new InfoPage();
            this.Opacity -= 0.8;
            //this.Hide();
            infoPage.ShowDialog();
            if (Home.ActiveForm != null)
            {
                this.Opacity += 0.8;
            }
            else this.Close();
        }

        private void btnGetStart_Click_1(object sender, EventArgs e)
        {
            Login lgLam = new Login();
            this.Opacity -= 0.8;
            lgLam.ShowDialog();
            if (Home.ActiveForm != null)
            {
                this.Opacity += 0.8;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Login lgLam = new Login();
            this.Opacity -= 0.8;
            lgLam.ShowDialog();
            if (Home.ActiveForm != null)
            {
                this.Opacity += 0.8;
            }
        }

        private void signupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Opacity -= 0.8;
            signup.ShowDialog();
            if (Home.ActiveForm != null)
            {
                this.Opacity += 0.8;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoPage infoPage = new InfoPage();
            this.Opacity -= 0.8;
            //this.Hide();
            infoPage.ShowDialog();
            if (Home.ActiveForm != null)
            {
                this.Opacity += 0.8;
            }
            else this.Close();
        }
    }
}
