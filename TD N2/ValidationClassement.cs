using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TD_N2
{
    class ValidationClassement:ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {   int result=0;
        if (int.TryParse(value.ToString(), out result))
        {
            if (result > 0) return ValidationResult.ValidResult;
            else return new ValidationResult(false, "le classement doit etre positif !");
        }
        else return new ValidationResult(false, "le classement doit etre un nombre ");
        }
    }
}
