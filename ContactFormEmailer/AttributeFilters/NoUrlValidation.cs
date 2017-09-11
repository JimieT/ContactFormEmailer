using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ContactFormEmailer.Web.AttributeFilters
{
    public class NoUrlValidation : ValidationAttribute
    {
        public NoUrlValidation()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string strInput = Convert.ToString(value);

                if (Regex.IsMatch(strInput, "(?=<a href).*(?<=</a>)") || strInput.Contains("[url="))
                {
                    if (string.IsNullOrEmpty(ErrorMessage))
                    {
                        ErrorMessage = "Html links are not allowed.";
                    }

                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
}