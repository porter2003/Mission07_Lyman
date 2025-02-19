﻿using Microsoft.EntityFrameworkCore;

namespace Mission06_Lyman.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; } // New table
    }

}
