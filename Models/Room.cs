using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDBProject.Models
{
    class Room
    {
        [Key, Required]
        public int RoomId { get; set; }

        [Required]
        public int EstablishmentId { get; set; }

        [Required, Display(Name = "Тип приміщення")]
        public string RoomType { get; set; }

        [Display(Name = "К-ть місць")]
        public int PlaceCount { get; set; }

        [Required, Display(Name = "Площа")]
        public int Area { get; set; }

    }
}