using Application.Interfaces;
using Application.Models;
using System.ComponentModel.DataAnnotations;

namespace Application.Services.Helpers
{
    public class ValidationService : IValidationService
    {
        public ValidationResult ValidateEntity(Entity entity)
        {
            var vContext = new ValidationContext(entity, null, null);
            var validator = new List<ValidationResult>();

            if (!Validator.TryValidateObject(entity, vContext, validator, true))
            {
                return validator.FirstOrDefault(result => result != ValidationResult.Success);
            }

            return ValidationResult.Success;
        }
    }
}