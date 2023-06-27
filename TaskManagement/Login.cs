using Service.Models;
using Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using TaskManagement.notification_decor;
namespace TaskManagement
{

    public partial class Login : Form
    {
        AccountService _account = new AccountService();
        UserService _user = new UserService();
        Success success = null;
        Warning warning = null;

        public Login()
        {
            InitializeComponent();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegis_Click_1(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Opacity -= 0.8;
            signup.ShowDialog();
            if (Home.ActiveForm != null)
            {
                this.Opacity += 0.8;
            }
            this.Hide();
        }

        private void forgetpass_Click(object sender, EventArgs e)
        {
            forgetpass.ForeColor = Color.DarkRed;
            Forget_Password frmForgetPassword = new Forget_Password();
            frmForgetPassword.Show();
            forgetpass.ForeColor = Color.FromArgb(0, 0, 192);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            string username = txtUserName.Text;
            string password = txtPassword.Text;

            btnLogin.Enabled = false;
            //validation input data
            if (txtUserName.Text == "")
            {
                btnLogin.BackColor = Color.IndianRed;
                new Warning("Please input username").Show();
            }
            else if (txtPassword.Text == "")
            {
                btnLogin.BackColor = Color.IndianRed;
                new Warning("Please input password").Show();
            }
            else
            {
                //goi vao db de lay cac user
                var accounts = _account.GetAll();
                var account = accounts.FirstOrDefault(a => a.Username == txtUserName.Text
                && a.Password == txtPassword.Text);
                if (account == null)
                {
                    btnLogin.BackColor = Color.IndianRed;
                    new Warning("Invalid username or password!").Show();

                }
                //correct username and password  -> check role
                else
                {
                    //Login success => Show main form

                    var selectedFullnames = _user.GetAll().Where(u => u.Username == username).Select(u => u.FullName);
                    string fullname = selectedFullnames.FirstOrDefault();

                    var selectedEmail = _user.GetAll().Where(u => u.Username == username).Select(u => u.Email);
                    string email = selectedEmail.FirstOrDefault();

                    Home obj = (Home)Application.OpenForms["Home"];
                    obj.Hide();

                    new Success("Success").Show();

                    DashBoard dashBoard = new DashBoard(fullname, email, username);
                    this.Hide();
                    dashBoard.Show();
                }
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            btnLogin.BackColor = Color.White;
        }
    }
}
