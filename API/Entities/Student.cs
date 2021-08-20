using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
    
    }
}