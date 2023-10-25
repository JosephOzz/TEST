using Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Entity> EntityOfCase1 { get; }
        DbSet<Entity2> EntityOfCase2 { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}