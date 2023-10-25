using Application.Models;
using System.ComponentModel.DataAnnotations;

namespace Application.Interfaces
{
    public interface IValidationService
    {
        ValidationResult ValidateEntity(Entity entity);
    }
}