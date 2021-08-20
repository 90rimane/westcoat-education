using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students {get; set;}
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }       
    }
}