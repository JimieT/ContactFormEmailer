using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactFormEmailer.Web.AttributeFilters;

namespace ContactFormEmailer.Web.Models
{
    public class ContactUsInfo
    {
        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "CityRequired", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        public string City { get; set; }

        [Required(ErrorMessageResourceName = "ReasonForMessageRequired", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        public string ReasonForMessage { get; set; }

        [Required(ErrorMessageResourceName = "MobileNumberRequired", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        public string MobileNumber { get; set; }

        [Required(ErrorMessageResourceName = "EmailAddressRequired", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        [RegularExpression(".+\\@.+\\..+", ErrorMessageResourceName = "EmailAddressInvalid", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        public string EmailAddress { get; set; }

        [Required(ErrorMessageResourceName = "EmailAddressRequired", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        public string ConfirmEmailAddress { get; set; }

        [AllowHtml]
        [Required(ErrorMessageResourceName = "MessageRequired", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        [NoUrlValidation(ErrorMessageResourceName = "MessageInvalid", ErrorMessageResourceType = typeof(Resources.Home.ContactUs))]
        public string Message { get; set; }
    }
}