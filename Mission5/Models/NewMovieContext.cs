//Jessica Kinghorn Mission 4
//Model to seed database and help pass data to database

using Microsoft.EntityFrameworkCore;
using Mission5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5.Models
{
    public class NewMovieContext : DbContext
    {
       public NewMovieContext(DbContextOptions<NewMovieContext> options) : base (options)
        { }
        public DbSet<MovieResponse> Responses { get; set; } 
        public DbSet<Category> Category { get; set; }


        //Seed 3 Favorite Movies to database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category {CategoryId = 1, CategoryName= "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" },
                new Category { CategoryId = 9, CategoryName = "Other"});

            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    CategoryId = 4,
                    Title = "17 Miracles",
                    Year = 2011,
                    DirectorFirstName = "T.C.",
                    DirectorLastName = "Christensen",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "The music is great"

                },
                new MovieResponse
                {
                    MovieId = 2,
                    CategoryId = 4,
                    Title = "Cinderella",
                    Year = 2015,
                    DirectorFirstName = "Kenneth",
                    DirectorLastName = "Branagh",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "The music is great"


                },
                new MovieResponse
                {
                    MovieId = 3,
                    CategoryId = 4,
                    Title = "The Man from Snowy River",
                    Year = 1982,
                    DirectorFirstName = "George",
                    DirectorLastName = "Miller",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "The music is great"


                });
        }

    }
}
