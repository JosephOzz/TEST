using Application.Models;
using Application.Models.Common;

namespace Application.Interfaces
{
    public interface IEntityOfCase1Service
    {
        Task<Result> AddEntity(Entity entity);
    }
}
