using Application.Interfaces;
using Application.Models;
using Application.Models.Common;
using Application.Persistence;

namespace Application.Services
{
    public class EntityOfCase2Service : IEntityOfCase2Service
    {
        private readonly IValidationService _validationService;
        private readonly IApplicationDbContext _context;
        private static List<Entity2> _entities;
        private static int _count = 1;

        public EntityOfCase2Service(IValidationService validationService, IApplicationDbContext context)
        {
            _validationService = validationService;
            _context = context;
        }

        public async Task<Result> ProcessFile(string filePath)
        {
            await Validation(filePath);

            _entities = new List<Entity2>();

            bool first = true;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    var row = await sr.ReadLineAsync();

                    if (first)
                    {
                        first = false;
                        continue;
                    }

                    var columns = row.Split(',');

                    _entities.Add(new Entity2()
                    {
                        Field1 = columns[0],
                        Field2 = columns[1],
                        Field3 = columns[2]
                    });
                }
            }

            if (_entities.Any())
            {
                await _context.EntityOfCase2.AddRangeAsync(_entities);
                await _context.SaveChangesAsync();
            }

            return new Result { Success = true };
        }

        private async Task Validation(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string? readLine = await sr.ReadLineAsync();
                if (string.IsNullOrEmpty(readLine))
                    throw new Exception("The selected file is empty!");
            }
        }
    }
}
