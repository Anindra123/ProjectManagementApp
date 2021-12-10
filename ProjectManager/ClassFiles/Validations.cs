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

        public bool SignUpAndUpdateValidation<T>(bool update, string fName, string lName, string email, string pass, T obj)
        {
            if (string.IsNullOrWhiteSpace(fName) ||
                string.IsNullOrWhiteSpace(lName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass))
            {
                ShowAlert("Text Feilds Cannot Be Empty");
                return false;
            }
            else if (!Regex.IsMatch(email, pattern))
            {
                ShowAlert("Invalid Email");
                return false;
            }
            else if (pass.Length > 8)
            {
                ShowAlert("Password must be 8 characters long");
                return false;
            }
            else if (!update)
            {
                if (obj is ProjectManager)
                {
                    var o = obj as ProjectManager;
                    if (o.CheckDuplicateMailAndPass(email, pass))
                    {
                        ShowAlert("An entry with same name/email/password already exists.Try something different");
                        return false;
                    }
                }
                else if (obj is ProjectMember)
                {
                    var o = obj as ProjectMember;
                    if (o.CheckDuplicateMailAndPass(email, pass))
                    {
                        ShowAlert("An entry with same name/email/password already exists.Try something different");
                        return false;
                    }
                }
            }
            else
            {
                if (obj is ProjectManager)
                {
                    var o = obj as ProjectManager;
                    if (o.CheckDuplicateUpdate(email, pass))
                    {
                        ShowAlert("An entry with same name/email/password already exists.Try something different");
                        return false;
                    }
                }
            }
            return true;
        }
    }

}
