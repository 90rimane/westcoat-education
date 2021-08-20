using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Course")]
    public class Course
    {
        public int Id {get; set;}
        [Column(TypeName = "VARCHAR(80)")]
        public string CourseName { get; set; }
        [Column(TypeName = "SMALLINT")]
        public int CourseNumber { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string CoursePeriod { get; set; }
        [Column(TypeName = "SMALLINT")]
        public int CoursePrice { get; set; }
        public bool Retired { get; set; }

    }
}