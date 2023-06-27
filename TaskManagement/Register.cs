using Service.Models;
using Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.notification_decor;

namespace TaskManagement
{
    public partial class Register : Form
    {
        UserService _users = new UserService();
        AccountService _account = new AccountService();

        private string username;
        private string password;
        public Register(string uname, string upass)
        {
            InitializeComponent();
            username = uname;
            password = upass;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            string uFullname = txtFullname.Text;
            string uPhone = txtPhonenum.Text;
            string uEmail = txtEmail.Text;
            DateTime dob = dtBirthday.Value;

            //tạo userID
            Random random = new Random();
            int userID = random.Next(500);

            //check userID nếu trùng
            var user = _users.GetAll().Select(x => x.UserId);
            int userIdfromDB = user.FirstOrDefault();
            if (userIdfromDB == userID)
            {
                userID = random.Next(500);
            }

            bool checkInfo = ValidationLam.checkInfo(uEmail, uPhone, uFullname, dob);
            if (checkInfo)
            {
                //create new account
                Account account = new Account();
                account.Username = username;
                account.Password = password;
                _account.Create(account);

                // Tạo đối tượng User và gán giá trị từ các trường nhập liệu
                User newUser = new User();
                newUser.Email = uEmail;
                newUser.PhoneNumber = Convert.ToInt32(uPhone);
                newUser.FullName = uFullname;
                newUser.Birthday = dtBirthday.Value;
                newUser.Username = username;
                newUser.UserId = userID;
                newUser.DateCreate = DateTime.Now;
                _users.Create(newUser);

                Home obj = (Home)Application.OpenForms["Home"];
                obj.Hide();

                new Success("Save successful").Show();
                DashBoard db = new DashBoard(newUser.FullName, newUser.Email, newUser.Username);
                this.Hide();
                db.ShowDialog();
                this.Close();
            }
            else
            {
                btnSave.BackColor = Color.IndianRed;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnSave.BackColor = Color.White;
        }
    }
}
