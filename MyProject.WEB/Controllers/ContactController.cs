using Microsoft.AspNetCore.Mvc;
using MyProject.Bussiness.Abstract;
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
        private readonly IMailService mailService;

        public ContactController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GoMail(ContactModel contactModel)
        {
            var body= $"Mesaj Bilgisi: {contactModel.Message} Bu arkadaş tarafından gönderildi: {contactModel.Name}  bu arkadaşın maili de bu: {contactModel.Email}";
            mailService.SendMail("bitirmetest26@gmail.com", body, contactModel.Subject);

            TempData["Success"] = true;

            return RedirectToAction("Index");
        }

    }
}
