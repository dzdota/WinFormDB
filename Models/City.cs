using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDBProject.Models
{
    class City
    {
        [Key, Required]
        public int Id_City { get; set; }

        [Required]
        public int Id_Region { get; set; }

        [Required]
        public int Id_Country { get; set; }

        public string Name { get; set; }
    }
}
