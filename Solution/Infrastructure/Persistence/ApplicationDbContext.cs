using Application.Models;
using Application.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base()
        { }

        public DbSet<Entity> EntityOfCase1 => base.Set<Entity>();
        public DbSet<Entity2> EntityOfCase2 => base.Set<Entity2>();


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
            => await base.SaveChangesAsync(cancellationToken);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(Properties.Resources.ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}