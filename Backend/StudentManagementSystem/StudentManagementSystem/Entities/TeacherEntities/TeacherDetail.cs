using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Entities.TeacherEntities
{
    public class TeacherDetail
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(100)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        [StringLength(15)]
        public string? Phone { get; set; }
    }
}
