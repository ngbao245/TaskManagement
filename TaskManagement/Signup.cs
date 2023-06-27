using Service.Models;
using Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.notification_decor;

namespace TaskManagement
{
    public partial class Signup : Form
    {
        UserService _user = new UserService();
        AccountService _account = new AccountService();


        public Signup()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;

            string uname = txtUNameRe.Text;
            string upass = txtUPassRe.Text;
            string uconpass = txtUConPassRe.Text;
            Warning warning;
            Success success;

            bool checkRegis = ValidationLam.checkRegistration(uname, upass, uconpass);
            if (checkRegis)
            {
                //
                this.Hide();
                addInfo(uname, upass);
                this.Close();
            }
            else
            {
                btnRegister.BackColor = Color.IndianRed;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addInfo(string username, string password)
        {
            // Tạo một đối tượng 
            Register registerForm = new Register(username, password);
            // Hiển thị 
            registerForm.ShowDialog();
            // Sau khi form được đóng, hiện lại form hiện tại
            this.Show();
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtUPassRe.UseSystemPasswordChar = false;
                txtUConPassRe.UseSystemPasswordChar = false;
            }
            else
            {
                txtUPassRe.UseSystemPasswordChar = true;
                txtUConPassRe.UseSystemPasswordChar = true;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            btnRegister.Enabled = true;
            btnRegister.BackColor = Color.White;
        }
    }
}
