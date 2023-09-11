using MoviesApi.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.DTOs
{
    public class GenreCreationDTO
    {
        [Required(ErrorMessage = "The Feild Name Required")]
        [StringLength(50)]
        [FirstLetterUpperCaseAttribute]
        public string Name { get; set; }
    }
}
