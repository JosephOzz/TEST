using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Entity : BaseEntity
    {
        [Required(ErrorMessage = "The field 1 is required!")]
        public string Field1 { get; set; }
        [Required(ErrorMessage = "The field 2 is required!")]
        public string Field2 { get; set; }
        [Required(ErrorMessage = "The field 3 is required!")]
        public string Field3 { get; set; }
        [Required(ErrorMessage = "The field 4 is required!")]
        public string Field4 { get; set; }
        [Required(ErrorMessage = "The field 5 is required!")]
        public string Field5 { get; set; }
    }
}