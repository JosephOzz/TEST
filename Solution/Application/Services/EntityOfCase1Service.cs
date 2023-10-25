using Application.Interfaces;
using Application.Models;
using Application.Models.Common;
using Application.Persistence;
using System.ComponentModel.DataAnnotations;

namespace Application.Services
{
    public class EntityOfCase1Service : IEntityOfCase1Service
    {
        private readonly IValidationService _validationService;
        private readonly IApplicationDbContext _context;
        public EntityOfCase1Service(IValidationService validationService, IApplicationDbContext context)
        {
            _validationService = validationService;
            _context = context;
        }

        public async Task<Result> AddEntity(Entity entity)
        {
            ValidationResult validationResult = _validationService.ValidateEntity(entity);

            if (validationResult != null && !validationResult.Equals(ValidationResult.Success))
                throw new Exception(validationResult.ErrorMessage);

            List<Entity> entities = new List<Entity>
            {
                entity,
                entity,
                entity,
                entity,
                entity
            };

            await _context.EntityOfCase1.AddRangeAsync(entities);

            return new Result { Success = await _context.SaveChangesAsync() > 0 };
        }
    }
}