using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKrakow.Data.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public MovieKind MovieKind { get; set; }
    }
}
