using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.ViewModels;

namespace API.Interfaces
{
    public interface IStudentRepository
    {
        void Add(StudentViewModel student);
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<IEnumerable<Student>> GetStudentsByCourseIdAsync();
        Task<IEnumerable<Student>> GetStudentsByStudentIdAsync();
        Task<Student> GetStudentByIdAsync(int id);
        void Delete(Student student);
        Task<bool> SaveAllAsync();
    }
}