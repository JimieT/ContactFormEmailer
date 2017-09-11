using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactFormEmailer.Web.Helpers;

namespace ContactFormEmailer.Web.Controllers
{
    public abstract partial class BaseController : Controller
    {
        protected BaseController()
        {

        }

        internal IEmailSender EmailSender { get; set; }

        protected BaseController(IEmailSender emailSender)
        {
            EmailSender = emailSender;
        }

    }
}