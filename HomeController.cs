using mail.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace mail.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailsender;

        public HomeController(IEmailSender emailSender)
        {
            _emailsender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var receiver = "shreya.prajapati@info.com.np";
            var subject = "test mail abcderf";
            var message = "hello shreya";
            await _emailsender.SendEmailAsync(receiver, subject, message);
            return View();
        }

    
    }
}