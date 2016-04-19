﻿using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class MajaUser
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}