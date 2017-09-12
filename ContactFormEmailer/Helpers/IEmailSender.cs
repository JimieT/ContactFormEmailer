using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactFormEmailer.Web.Models;

namespace ContactFormEmailer.Web.Helpers
{
    public interface IEmailSender
    {
        void Send(dynamic contactInfo);
    }
}