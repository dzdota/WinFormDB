using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDBProject.Models
{
    class Establishment
    {
        [Key, Required, Display(Name = "Номер")]
        public int Number { get; set; }

        [Required, Display(Name = "Назва закладу")]
        public string EstablishmentName { get; set; }

        [Required, Display(Name = "Тип закладу")]
        public string EstablishmentType { get; set; }

        [Required, Display(Name = "Адреса")]
        public string EstablishmentAdress { get; set; }

    }
}