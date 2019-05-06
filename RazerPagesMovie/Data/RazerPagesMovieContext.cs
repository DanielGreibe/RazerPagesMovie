using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazerPagesMovie.Models
{
    public class RazerPagesMovieContext : DbContext
    {
        public RazerPagesMovieContext (DbContextOptions<RazerPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazerPagesMovie.Models.Movie> Movie { get; set; }
    }
}
