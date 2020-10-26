using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace single_page_app.Models
{
    public class MovieModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Remote("VerifyMovie", "Movies", HttpMethod = "POST", ErrorMessage = "Movie already exists in database.")]
        public string Name { get; set; }
        [Required]
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Description { get; set; }
        
    }

}
