using MoviesApi.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage="The Feild Name Required")]
        [StringLength(50)]
        [FirstLetterUpperCaseAttribute]
        public string Name { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (!string.IsNullOrEmpty(Name))
        //    {
        //        var firstLetter = Name[0].ToString();
        //        if (firstLetter != firstLetter.ToUpper())
        //        {
        //            yield return new ValidationResult("First Letter Should be UpperCase", new string[] { nameof(Name) });
        //        }
        //    }
        //}
        //[Range(10,100)]
        //public int Age { get; set; }
        //[CreditCard]
        //public int CreditCard { get; set; }
        //[Url]
        //public string Url { get; set; }
    }
}
