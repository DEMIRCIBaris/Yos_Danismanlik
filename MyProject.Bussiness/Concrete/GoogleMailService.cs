using MyProject.Bussiness.Abstract;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace MyProject.Bussiness.Concrete
{
    public class GoogleMailService : IMailService
    {
        public void SendMail(string ToMailAddress, string mailBody,string subject)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential("bitirmetest26@gmail.com", "bittigitti");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("bitirmetest26@gmail.com", "Blackerback");
            mail.To.Add(ToMailAddress);

            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = mailBody;

            smtpClient.Send(mail);


        }
    }
}
