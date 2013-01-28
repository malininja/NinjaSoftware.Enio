using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
    public static class DataAnnotationConstants
    {
        public const string Required = "Polje je obavezno.";
        public const string OibRegex = @"^(\d{11})+$";
        public const string CurrencyRegex = @"^[+]?\d{0,99}(\,\d{1,2})?$";
    }
}
