namespace LabsAndCoursesManagement.Models.Dtos
{
    public class CreateReportDto
    {
        public Guid StudentId { get; set; }

        public Guid TeacherId { get; set; }

        public double Value { get; set; }

        public string EvaluationType { get; set; }

        public DateTime EvaluationDate { get; set; }
    }
}
