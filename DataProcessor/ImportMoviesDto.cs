namespace Cinema.DataProcessor
{
    using System;
    using System.ComponentModel.DataAnnotations;

    internal class ImportMoviesDto
    {

        [Required]
        [MinLength(3), MaxLength(20)]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        [Range((double)1, (double)10)]
        public double Rating { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        public string Director { get; set; }

    }
}