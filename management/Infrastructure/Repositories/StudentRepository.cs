using management.Domain.Entities;
using management.Domain.Interfaces;

namespace management.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>();
        public Task<Student?> GetByEmail(string email)
        {
            var student = _students.FirstOrDefault(s => s.Email == email);
            return Task.FromResult(student);
        }

        public Task<List<Student>> ListingStudent()
        {
            return Task.FromResult(_students);
        }

        public Task<Student> SaveStudent(Student student)
        {
            _students.Add(student);
            return Task.FromResult(student);
        }
    }
}
