using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Entities.GradeEntities
{
    public class GradeDetail
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public int? StudentId { get; set; }

        [Required]
        public int? CourseId { get; set; }

        [Range(0, 100)]
        public decimal? Score { get; set; }

        [Required]
        [StringLength(2)]
        public string? LetterGrade { get; set; }
    }
}
