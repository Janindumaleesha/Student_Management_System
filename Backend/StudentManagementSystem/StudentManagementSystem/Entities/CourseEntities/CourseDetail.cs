using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Entities.CourseEntities
{
    public class CourseDetail
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(20)]
        public string? Code { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Range(1, 10)]
        public int? Credits { get; set; }
    }
}
