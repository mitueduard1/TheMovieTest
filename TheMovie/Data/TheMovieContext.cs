using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheMovie.Models;

namespace TheMovie.Data
{
    public class TheMovieContext : DbContext
    {
        public TheMovieContext (DbContextOptions<TheMovieContext> options)
            : base(options)
        {
        }

        public DbSet<TheMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
