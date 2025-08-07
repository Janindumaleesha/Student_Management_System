namespace StudentManagementSystem.Entities.GradeEntities
{
    public class GradeDetailView
    {
        public int? GradeId { get; set; }
        public string? StudentName { get; set; }
        public string? CourseName { get; set; }
        public decimal? Score { get; set; }
        public string? LetterGrade { get; set; }
    }
}
