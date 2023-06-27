using Microsoft.VisualBasic.ApplicationServices;
using Service.Models;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskManagement.notification_decor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TaskManagement
{
    //
    public class ValidationLam
    {
        public static bool CheckNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }
            return false;
        }

        public static bool checkLength(int minLen, int maxLen, string value)
        {
            if (value.Length < minLen || value.Length > maxLen)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]{5,}@gmail.com+$"; //update regex
            return Regex.IsMatch(email, pattern);
        }

        public static bool checkInfo(string email, string phone, string fullname, DateTime dob)
        {
            bool check = true;
            bool checkEmail = IsValidEmail(email);
            if (!checkEmail)
            {
                new Warning("Email must include at least 5 characters long!").Show();
                check = false;
            }

            DateTime selectedDate = dob;
            DateTime currentDate = DateTime.Now.Date;
            if (selectedDate > currentDate)
            {
                new Warning("Please enter a valid date!").Show();
                check = false;
            }

            bool checkPhone = checkLength(9, 11, phone);
            int number;
            if (!(int.TryParse(phone, out number)) || checkPhone)
            {
                new Warning("Please enter a valid phone number!").Show();
                check = false;
            }

            //moi update
            bool checkNullFName = CheckNull(fullname);
            if (checkNullFName)
            {
                new Warning("Please enter a valid name!").Show();
                check = false;
            }
            bool checkName = checkLength(5, 30, fullname);
            if (checkName)
            {
                new Warning("Username must between 5 and 30 characters long!").Show();
                check = false;
            }
            return check;
        }
        public static bool checkRegistration(string username, string password, string confirmPassword)
        {
            AccountService _account = new AccountService();
            var userName = _account.GetAll().Where(u => u.Username == username).Select(x => x.Username);
            string usernameExist = userName.FirstOrDefault();
            bool check = true;

            if (username == "")
            {
                new Warning("Please enter a valid username!").Show();
                check = false;
            }
            else if (username.Equals(usernameExist))
            {
                new Warning("Username is taken. Try another!").Show();
                check = false;
            }
            else if (password == "" || confirmPassword == "")
            {
                new Warning("Please enter password or confirm password!").Show();
                check = false;
            }
            else if (!(password.Equals(confirmPassword)))
            {
                new Warning("Those passwords didn’t match. Try again!").Show();
                check = false;
            }
            else if (!(ContainsLowerCase(password) && ContainsUpperCase(password) && ContainsSpecialChar(password) && ContainsNumericChar(password)))
            {
                new Warning("Use at least 1 lowercase, 1 uppercase, 1 special, and 1 numeric character for your password!").Show();
                check = false;
            }

            return check;
        }

        // Kiểm tra xem mật khẩu có chứa ký tự chữ thường
        static bool ContainsLowerCase(string password)
        {
            return password.Any(c => char.IsLower(c));
        }

        // Kiểm tra xem mật khẩu có chứa ký tự chữ hoa
        static bool ContainsUpperCase(string password)
        {
            return password.Any(c => char.IsUpper(c));
        }

        // Kiểm tra xem mật khẩu có chứa ký tự đặc biệt
        static bool ContainsSpecialChar(string password)
        {
            string specialChars = "!@#$%^&*()";
            return password.Any(c => specialChars.Contains(c));
        }

        // Kiểm tra xem mật khẩu có chứa ký tự số
        static bool ContainsNumericChar(string password)
        {
            return password.Any(c => char.IsDigit(c));
        }
    }
}


