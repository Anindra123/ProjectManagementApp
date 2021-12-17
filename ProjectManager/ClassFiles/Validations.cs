using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.ClassFiles
{
    public class Validations
    {
        /// <summary>
        /// pattern against which email is checked
        /// </summary>
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        /// <summary>
        /// takes a string and shows a message box for showing error to user
        /// </summary>
        public void ShowError(string msg)
        {
            MessageBox.Show($"{msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// takes a string and shows a message box for alerting user and
        /// returns the dialog result
        /// </summary>
        public DialogResult ShowAlert(string msg)
        {
            DialogResult result = MessageBox.Show($"{msg}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return result;
        }
        /// <summary>
        /// takes a string and shows a message box for showing information to user and
        /// returns the dialog result
        /// </summary>
        public DialogResult ShowInfo(string msg)
        {
            DialogResult result = MessageBox.Show($"{msg}", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }
        /// <summary>
        /// verify whether start date is high or equal to end date
        /// </summary>

        public bool VerifyDates(DateTime sDate, DateTime eDate)
        {
            if (sDate.Date == eDate.Date || sDate.Date > eDate.Date)
            {
                ShowAlert("Start Date is greater or equal to end date. Please choose a new date");
                return true;
            }
            return false;
        }
        /// <summary>
        /// Checks whether mail follows a proper pattern
        /// </summary>

        public bool ValidateMail(string email)
        {
            if (!Regex.IsMatch(email, pattern))
            {
                ShowAlert("Invalid Email");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Generic method which will provide sign up and update validations    
        /// </summary>

        public bool SignUpAndUpdateValidation(bool update, string fName, string lName,
            string email, string pass, bool lastNameExist)
        {
            bool ret = true;

            if (lastNameExist == true)
            {
                if (string.IsNullOrWhiteSpace(fName) ||
                string.IsNullOrWhiteSpace(lName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass))
                {
                    ShowAlert("Text Feilds Cannot Be Empty");
                    ret = false;
                }
                else if (!Regex.IsMatch(email, pattern))
                {
                    ShowAlert("Invalid Email");
                    ret = false;
                }
                else if (pass.Length > 8)
                {
                    ShowAlert("Password must be 8 characters long");
                    ret = false;
                }
                else if (User.CheckDuplicateMailPassName(email, pass, fName, lName))
                {
                    ShowAlert("Account with same name/email/pass already exists.Try something different.");
                    ret = false;
                }

            }
            else
            {
                if (string.IsNullOrWhiteSpace(fName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass))
                {
                    ShowAlert("Text Feilds Cannot Be Empty");
                    ret = false;
                }
                else if (!Regex.IsMatch(email, pattern))
                {
                    ShowAlert("Invalid Email");
                    ret = false;
                }
                else if (pass.Length > 8)
                {
                    ShowAlert("Password must be 8 characters long");
                    ret = false;
                }
                else if (User.CheckDuplicateMailPassName(email, pass, fName))
                {
                    ShowAlert("Account with same name/email/pass already exists.Try something different.");
                    ret = false;
                }

            }

            return ret;
        }


        public bool SignInValidation(User obj)
        {
            if (obj.UserStatus == "Unverified")
            {
                ShowAlert("Your account is currently not verified.Please wait for verification.");
                return false;
            }
            if (obj.UserStatus == "Block")
            {
                ShowError("Your account was blocked by admin.Please create a different account or contact administration.");
                return false;
            }
            return true;
        }

        public bool SignInValidation(string email, string pass)
        {
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass))
            {
                ShowAlert("Text feilds cannot be empty");
                return false;
            }
            return true;
        }
    }

}
