using System.ComponentModel.DataAnnotations;


namespace CinemaKrakow.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public int Year { get; set; }
        public string PosterUrl { get; set; }
        public MovieKind MovieKind { get; set; }
        public int EditorRating { get; set; }
    }
}
