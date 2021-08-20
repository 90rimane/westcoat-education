using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using API.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public StudentRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(StudentViewModel student)
        {
            var newStudent = _mapper.Map<Student>(student);
            _context.Entry(newStudent).State = EntityState.Added;
        }

        public void Delete(Student student)
        {
            throw new System.NotImplementedException();
        }

        public Task<Student> GetStudentByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public Task<IEnumerable<Student>> GetStudentsByCourseIdAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetStudentsByStudentIdAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}