using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ContactFormEmailer.Web.AttributeFilters
{
    public class CaseInsensitiveCompareAttribute : CompareAttribute
    {
        public CaseInsensitiveCompareAttribute(string otherProperty)
            : base(otherProperty)
        { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(this.OtherProperty);
            if (property == null)
            {
                return new ValidationResult(string.Format(CultureInfo.CurrentCulture, "Unknown property {0}", this.OtherProperty));
            }
            var otherValue = property.GetValue(validationContext.ObjectInstance, null) as string;
            if (string.Equals(value as string, otherValue, StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
        }
    }
}