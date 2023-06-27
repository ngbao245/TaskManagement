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

namespace TaskManagement
{
    public partial class UserDetails : Form
    {
        UserService _user = new UserService();
        private string Username;
        public UserDetails(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            var getAllInfo = _user.GetAll().Where(u => u.Username == Username);

            string username = getAllInfo.Select(u => u.Username).FirstOrDefault();
            string fullname = getAllInfo.Select(f => f.FullName).FirstOrDefault();
            string email = getAllInfo.Select(e => e.Email).FirstOrDefault();
            int phone = getAllInfo.Select(p => (int)p.PhoneNumber).FirstOrDefault();
            DateTime birthday = getAllInfo.Select(b => (DateTime)b.Birthday).FirstOrDefault();

            txtEmail.Text = email.ToString();
            txtFullname.Text = fullname.ToString();
            txtOpenDate.Text = birthday.ToString("yyyy-MM-dd");
            txtPhone.Text = phone.ToString();
            txtEmail.ReadOnly = true;
            txtFullname.ReadOnly = true;
            txtOpenDate.ReadOnly = true;
            txtPhone.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var selectedFullnames = _user.GetAll().Where(u => u.Username == Username).Select(u => u.FullName);
            string fullname = selectedFullnames.FirstOrDefault();

            var selectedEmail = _user.GetAll().Where(u => u.Username == Username).Select(u => u.Email);
            string email = selectedEmail.FirstOrDefault();

            DashBoard dashBoard = new DashBoard(fullname, email, Username);
            this.Hide();
            dashBoard.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change_Password change_Password = new Change_Password(Username);
            change_Password.ShowDialog();
        }
    }
}
