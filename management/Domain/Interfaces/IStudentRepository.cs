using management.Domain.Entities;

namespace management.Domain.Interfaces
{
    public interface IStudentRepository
    {
        
        Task<Student?> GetByEmail(string email);
        Task<Student> SaveStudent(Student student);

        Task<List<Student>> ListingStudent();


    }
}
