﻿namespace Cinema.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Seat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Hall")]
        public int HallId { get; set; }

        public Hall Hall { get; set; }
    }
}
//Id – integer, Primary Key
//HallId – integer, foreign key(required)
//Hall – the seat’s hall