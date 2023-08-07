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
        [StringLength(20)]
        public string Name { get; set; }
        //[Range(10,100)]
        //public int Age { get; set; }
        //[CreditCard]
        //public int CreditCard { get; set; }
        //[Url]
        //public string Url { get; set; }
    }
}
