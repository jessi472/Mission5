//Jessica Kinghorn Mission 4
//Model for New Movie Form
using Mission5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5.Models
{
    public class MovieResponse
    {
        //Primary Key
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the year the movie was released")]
        public int Year { get; set; }
        
        [Required]
        public string DirectorFirstName { get; set; }

        [Required]
        public string DirectorLastName { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }
        
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
