using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ClassFiles
{
    public class Mail
    {
        public static async Task<bool> SendMail(string msg)
        {
            var sender = new SmtpSender(() => new SmtpClient(host: "smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    //mail to setup the server don't modify this !
                    //password is google generated you won't be 
                    //able to acess this account
                    UserName = "projmanagapp@gmail.com",
                    Password = "klqasedwaimsvwet"
                }
            }

            );

            Email.DefaultSender = sender;
            //change the .To() to your own mail for testing
            //make sure to check the spam folder
            var email = await Email
                .From("projmanagapp@gmail.com")
                .To("bivasdas911@gmail.com", "Anindra Das") //change this mail to your own mail for testing
                .Subject("Password Recovery")
                .Body(msg)
                .SendAsync();
            return email.Successful;

        }
    }
}
