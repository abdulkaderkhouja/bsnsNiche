using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bsnsNiche.Models;

namespace bsnsNiche.Data
{

    /*
     * Scaffolding creates the Data/MvcMovieContext.cs database context class:
     */
    public class bsnsNicheContext : DbContext
    {
        public bsnsNicheContext (DbContextOptions<bsnsNicheContext> options)
            : base(options)
        {
        }

        public DbSet<bsnsNiche.Models.PurchaseOrder> PurchaseOrder { get; set; } = default!;
    }

    /*
     * The preceding code creates a DbSet<Movie> property that represents the movies in the database.
     */
}
