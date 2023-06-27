using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class OTP_Form : Form
    {
        private int OTPCode;
        private string Username;
        public OTP_Form(int oTPCode, string username)
        {
            InitializeComponent();
            OTPCode = oTPCode;
            Username = username;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Success success = new Success("Checking OTP...");
            success.ShowDialog();

            string otp = txtOtp.Text;
            bool checkOTP = Validation.checOTP(otp, OTPCode);
            if (checkOTP)
            {
                Change_Password frmChangePass = new Change_Password(Username);
                frmChangePass.ShowDialog();
                //ko ẩn otp form ====FIX====
                this.Hide();
            }
        }

        private void OTP_Form_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c start https://mail.google.com/");
        }
    }
}
