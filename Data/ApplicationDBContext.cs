using Microsoft.EntityFrameworkCore;
using Prog_poe.Models;

namespace Prog_poe.Data
{
    public class ApplicationDBContext : DbContext
    {


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
        }

            // TODO: add a DbSet<T> property here for each model,
            // once the model classes in /Models have real properties.
            // e.g. public DbSet<User> Users { get; set; }

             public DbSet<Category> Categories { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Results> Results { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<User> Users { get; set; }
    }   


    
}
