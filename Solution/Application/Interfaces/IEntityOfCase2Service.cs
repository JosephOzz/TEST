using Application.Models.Common;

namespace Application.Interfaces
{
    public interface IEntityOfCase2Service
    {
        Task<Result> ProcessFile(string filePath);
    }
}
