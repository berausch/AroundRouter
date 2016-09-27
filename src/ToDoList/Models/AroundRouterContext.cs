using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AroundRouter.Models
{
    public class AroundRouterContext : DbContext
    {


        public DbSet<Location> Locations { get; set; }
        
        public DbSet<Route> Routes { get; set; }

        public AroundRouterContext(DbContextOptions<AroundRouterContext> options) : base(options)
        {
        }

        public AroundRouterContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AroundRouter;integrated security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}


