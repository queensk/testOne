using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sendMessage.Models
{
    public class User
    {
        string Name {get;set;}
        string Email {get;set;}
        public static bool IsValidEmail(string email)
        {
            var regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regex.IsMatch(email);
        }

        public static bool IsValidEmailClass(string email)
        {
            var valid = true;   
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
    }

}