﻿using System.ComponentModel.DataAnnotations;
using System;

namespace MoviesApi.DTOs
{
    public class ActorCreationDTO
    {
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Biography { get; set; }
        //public string Picture { get; set; }
    }
}
