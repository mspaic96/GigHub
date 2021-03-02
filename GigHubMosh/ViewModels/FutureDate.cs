using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHubMosh.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd.MM.yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out DateTime dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}