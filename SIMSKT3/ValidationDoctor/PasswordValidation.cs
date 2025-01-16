using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SIMSKT3.ValidationDoctor
{
    public class PasswordValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                int counter = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!char.IsUpper(s[i]) && !char.IsLower(s[i]))
                    {
                        counter++;
                    }                    
                }
                if (counter > 0)
                {
                    return new ValidationResult(false, "The input must contains letters only!");
                }
                return new ValidationResult(true, null);
            }
            catch
            {
                return new ValidationResult(false, "Something went wrong");
            }
        }
    }
}
