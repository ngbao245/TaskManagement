using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.notification_decor;


namespace TaskManagement
{
    
    public class Validation
    {
        public static bool checkLength(int minLen, int maxLen, string value)
        {
            if (value.Length > maxLen || value.Length <= minLen)
            {
                return true;
            }
            return false;
        }

        public static bool checkProject(string name, string description)
        {
            bool check = true;
            //Check empty
            if (string.IsNullOrEmpty(name))
            {
                new Warning("Please fill all fields!").Show();
                    check = false;
            }
            if (string.IsNullOrEmpty(description))
            {
                new Warning("Please fill all fields!").Show();
                check = false;
            }
            //Check length
            bool nameLength = checkLength(30, 0, name);
            if (!nameLength)
            {
                new Warning("Character is exceeded!").Show();
                check = false;
            }

            bool desLength = checkLength(200, 0, description);
            if (!desLength)
            {
                new Warning("Character is exceeded!").Show();
                check = false;
            }
            return check;
        }

        public static bool checOTP(string otp, int otpEnter)
        {
            bool check = true;

            int otpCode;
            if (int.TryParse(otp, out otpCode))
            {
            }
            else
            {
                new Warning("OTP code must be 6 digits!").Show();
                check = false;
            }

            if (otpCode.Equals(otpEnter))
            {
            }
            else
            {
                new Warning("Incorrect OTP code!").Show();
                check = false;
            }
            return check;
        }

        public static bool checkPassValidation(string newPassword, string confirmPassword)
        {
            bool check = true;
            if (!(ContainsLowerCase(newPassword) && ContainsUpperCase(newPassword) && ContainsSpecialChar(newPassword) && ContainsNumericChar(newPassword)))
            {
                new Warning("Use at least 1 lowercase, 1 uppercase, 1 special, and 1 numeric character for your password!").Show();
                check = false;
            }

            if (confirmPassword.Equals(confirmPassword))
            {
            }
            else
            {
                new Warning("Those passwords didn’t match. Try again!").Show();
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

        public static bool checkEmptyForgetPass(string email)
        {
            bool check = true;
            if (string.IsNullOrEmpty(email))
            {
                new Warning("Please fill all fields!").Show();
                check = false;
            }
            return check;
        }
    }
}
