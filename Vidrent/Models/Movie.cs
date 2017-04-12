using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidrent.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Genretype")]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }
        [Display (Name = "Number In Stock")]
        public byte NumberInStock { get; set; }
    }
}