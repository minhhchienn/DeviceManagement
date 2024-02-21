using System;
using System.Globalization;
using System.Windows.Controls;

namespace DeviceManagement.Validation
{
    public class DateValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string dateString = value as string;

            if (string.IsNullOrWhiteSpace(dateString))
            {
                return new ValidationResult(false, "Invalid Date");
            }

            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return ValidationResult.ValidResult;
            }

            return new ValidationResult(false, "Invalid Date.");
        }
    }
}
