using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    class SendEmail
    {
        public void Notify(string msg)
        {
            ReadAccount readAccount = new ReadAccount();
            var body = msg;
            var message = new MailMessage();
            message.To.Add(new MailAddress("sonhoang236@gmail.com"));
            message.From = new MailAddress(readAccount.Read().account);
            message.Subject = "Send" + msg;
            message.Body = string.Format(body);
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = readAccount.Read().account,
                    Password = readAccount.Read().password
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
        }
    }
}
