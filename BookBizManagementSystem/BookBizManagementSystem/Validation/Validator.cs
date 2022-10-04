using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace BookBizManagementSystem.Validation
{
    public static class Validator
    {
        //Numerical
        public static bool NumIsValid(TextBox textBoxInput, int size1, int size2)
        {
            return (Regex.IsMatch(textBoxInput.Text, @"^\d{" + size1 + "," + size2 + "}$"));
        }

        //Alphapetical
        public static bool AlphapetIsValid(TextBox textBoxInput, int size1, int size2)
        {
            return (Regex.IsMatch(textBoxInput.Text, @"^[a-zA-Z]{" + size1 + "," + size2 + "}$"));
        }

        //Alphapetical and spaces
        public static bool AlphapeTwzSpaceeIsValid(TextBox textBoxInput, int size1, int size2)
        {
            return (Regex.IsMatch(textBoxInput.Text, @"^[a-zA-Z ]{" + size1 + "," + size2 + "}$"));
        }

        //Alphanumerical
        public static bool AlphaNumIsValid(TextBox textBoxInput, int size1, int size2)
        {
            return (Regex.IsMatch(textBoxInput.Text, @"^[a-zA-Z0-9]{" + size1 + "," + size2 + "}$"));
        }

        //Alphanumerical and spaces
        public static bool AlphaNuMwzSpaceIsValid(TextBox textBoxInput, int size1, int size2)
        {
            return (Regex.IsMatch(textBoxInput.Text, @"^[a-zA-Z0-9 ]{" + size1 + "," + size2 + "}$"));
        }

        //Email Check 1
        public static bool EmailIsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //Email check2
        public static bool EmailIsValid2(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

    }
}
