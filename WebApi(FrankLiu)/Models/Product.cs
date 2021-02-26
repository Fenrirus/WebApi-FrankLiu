using System;
using System.ComponentModel.DataAnnotations;
using WebApiFrankLiu.Validation;

namespace WebApiFrankLiu.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        [ReleaseDateInPast]
        public DateTime ReleaseDate { get; set; }
    }
}