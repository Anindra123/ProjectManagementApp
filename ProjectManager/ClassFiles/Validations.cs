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
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public void ShowError(string msg)
        {
            MessageBox.Show($"{msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult ShowAlert(string msg)
        {
            DialogResult result = MessageBox.Show($"{msg}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return result;
        }

        public DialogResult ShowInfo(string msg)
        {
            DialogResult result = MessageBox.Show($"{msg}", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result;
        }
        public bool VerifyDates(DateTime sDate, DateTime eDate)
        {
            if (sDate.Date == eDate.Date || sDate.Date > eDate.Date)
            {
                ShowAlert("Start Date is greater or equal to end date. Please choose a new date");
                return true;
            }
            return false;
        }

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
