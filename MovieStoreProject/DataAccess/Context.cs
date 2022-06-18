using Microsoft.EntityFrameworkCore;
using MovieStoreProject.Entities;
using System.Reflection;

namespace MovieStoreProject.DataAccess
{
    public class Context:DbContext
    {
        
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }




    }
}

