using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDBProject.Models
{
    class Countrie
    {
        [Key, Required]
        public int Id_Country { get; set; }

        public string Name { get; set; }
    }
}
