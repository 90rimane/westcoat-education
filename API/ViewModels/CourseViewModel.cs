using System.ComponentModel.DataAnnotations;

namespace API.ViewModels
{
    public class CourseViewModel
    {
        [Required(ErrorMessage = "Course name is required")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Course number is required")]
        public int CourseNumber { get; set; }
        public string CoursePeriod { get; set; }
        public int CoursePrice { get; set; }
        public bool Retired { get; set; }
    }
}