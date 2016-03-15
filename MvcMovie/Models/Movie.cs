using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    //Each instance of the Movie class represents a row in the database table; each property is a column
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    //The DbContext handles fetching, storing and updating Model class instances.  Thus MovieDbContext, with a DbSet of Movies, handles fetching, storing and updating of Movie class instances in the database
    //Enables you to query a database and group together changes that will then be written back to the store as a unit
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}