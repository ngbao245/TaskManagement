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
using TaskManagement.notification_decor;

namespace TaskManagement
{
    public partial class Change_Password : Form
    {

        AccountService _account = new AccountService();

        private string Username;
        public Change_Password(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = _account.GetAll().FirstOrDefault(u => u.Username == Username);

            if (user != null)
            {
                string newPassword = txtPassword.Text;
                string confirmPass = txtConfirm.Text;

                bool check = Validation.checkPassValidation(newPassword, confirmPass);

                if (newPassword.Equals(confirmPass))
                {
                    if (check)
                    {
                        user.Password = newPassword;
                        _account.Update(user);
                        this.Hide();
                    }
                    else
                    {
                        //new Warning("User not found").Show();
                    }
                }
                else new Warning("Those passwords didn’t match. Try again!").Show();

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtConfirm.Text.Trim() == "")
            {
                btnSave.SendToBack();
            }
            else
            {
                btnCancel.SendToBack();
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
