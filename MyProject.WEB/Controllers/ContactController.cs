using Microsoft.AspNetCore.Mvc;
using MyProject.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MyProject.WEB.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class ContactController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GoMail(ContactModel contactModel)
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
            mail.To.Add("bitirmetest26@gmail.com");

            mail.Subject = contactModel.Subject;
            mail.IsBodyHtml = true;
            mail.Body = $"Mesaj Bilgisi: {contactModel.Message} Bu arkadaş tarafından gönderildi: {contactModel.Name}  bu arkadaşın maili de bu: {contactModel.Email}";

            smtpClient.Send(mail);

            TempData["Success"] = true;

            return RedirectToAction("Index");
        }

    }
}
