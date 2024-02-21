using System.Globalization;
using System.Windows.Controls;

namespace DeviceManagement.Validation
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, "Không được để trống.")
                : ValidationResult.ValidResult;
        }
    }
}