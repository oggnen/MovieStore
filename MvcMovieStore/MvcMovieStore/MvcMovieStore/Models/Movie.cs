using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovieStore.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string MovieArtUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
    }
}