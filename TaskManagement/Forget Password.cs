using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Service.Service;
using TaskManagement.notification_decor;

namespace TaskManagement
{
    public partial class Forget_Password : Form
    {

        AccountService _account = new AccountService();
        public Forget_Password()
        {
            InitializeComponent();
        }


        private void btnNewPass_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string from, to, pass, content;
            from = "phongngo17092003@gmail.com";
            to = txtEmail.Text.Trim();
            pass = "fuqnehunzsfoqdld";

            var getUsername = _account.GetAll().Where(u => u.Username == username).Select(p => p.Username);
            string selectUsername = getUsername.FirstOrDefault();

            bool checkEmpty = Validation.checkEmptyForgetPass(to);
            if (checkEmpty)
            {
                if (selectUsername != null)
                {
                    Success success = new Success("Sending OTP...");
                    success.Show();

                    MailMessage mail = new MailMessage();
                    mail.To.Add(to);
                    mail.From = new MailAddress(from);
                    mail.Subject = "Task Management OTP Authentication Account";

                    Random random = new Random();
                    int otpCode = random.Next(100000, 999999);
                    mail.Body = "Your Task-Management verification code is " + otpCode;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        OTP_Form frmOTP = new OTP_Form(otpCode, username);
                        frmOTP.Show();

                        smtp.Send(mail);
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Email",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginLam = (Login)Application.OpenForms["Login"];
            loginLam.Show();
        }
    }
}
