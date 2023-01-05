using System.ComponentModel.DataAnnotations;

namespace CollegeNoteApp.Models
{
    public class CalculateViewModel
    {
        [Range(0,100)]
        public int Exam1 { get; set; }

        [Range(0,100)]
        public int Exam2 { get; set; }

        [Range(0,100)]
        public int Percent1 { get; set; }

        [Range(0,100)]
        public int Percent2 { get; set; }
        public int AverageExamScore { get; set; }
        public string AverageExamStatus { get; set; }
    }
}
