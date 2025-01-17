﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHubMosh.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out DateTime dateTime);
            return isValid ;
        }
    }
}