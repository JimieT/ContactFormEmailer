using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactFormEmailer.Web.Helpers;
using ContactFormEmailer.Web.Models;

namespace ContactFormEmailer.Web.Controllers
{
    public partial class HomeController : BaseController
    {
        public HomeController()
        {
        }

        public HomeController(IEmailSender emailSender) : base(emailSender)
        {

        }

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public virtual ActionResult ContactUs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public virtual ActionResult ContactUs(ContactUsViewModel viewModel)
        {
            if (viewModel.ContactUsInfo != null)
            {
                if (ModelState.IsValid)
                {
                    var emailSender = new EmailSender();
                    emailSender.Send(viewModel.ContactUsInfo);
                    return View();
                }
            }
            viewModel.ContactUsInfo = new ContactUsInfo
            {
                City = string.Empty,
                ConfirmEmailAddress = string.Empty,
                EmailAddress = string.Empty,
                Message = string.Empty,
                Name = string.Empty,
                MobileNumber = string.Empty,
                ReasonForMessage = string.Empty
            };
            TryValidateModel(viewModel.ContactUsInfo, viewModel.ContactUsInfo.GetType().Name);
            ModelState.AddModelError(string.Empty, Resources.Home.ContactUs.ContactUsSubmitFailure);
            return View(MVC.Home.Views.ContactUs, viewModel);
        }
    }
}