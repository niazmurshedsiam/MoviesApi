using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Validations
{
    public class FirstLetterUpperCaseAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var firstName = value.ToString()[0].ToString();
            if(firstName != firstName.ToString())
            {
                return new ValidationResult("First Letter Should be UpperCase");
            }
            return ValidationResult.Success;
        }
    }
}
