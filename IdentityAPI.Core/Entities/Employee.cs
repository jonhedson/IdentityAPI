using System.ComponentModel.DataAnnotations;

namespace IdentityAPI.Core.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required, MaxLength(80, ErrorMessage = "Name cannot have more than 80 characters")]
        public string Name { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Email Invalid")]
        [Required]
        public string Email { get; set; }

        public Department? Department { get; set; }
    }
}
