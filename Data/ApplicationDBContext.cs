using Microsoft.EntityFrameworkCore;

namespace Prog_poe.Data
{
    public class ApplicationDBContext : DbContext
    {

        
            public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
            {
            
            // TODO: add a DbSet<T> property here for each model,
            // once the model classes in /Models have real properties.
            // e.g. public DbSet<User> Users { get; set; }
        }   


    }
}
