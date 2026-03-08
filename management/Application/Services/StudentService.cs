using management.Domain.Entities;
using management.Domain.Interfaces;

namespace management.Application.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> Enrrol(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FirstName))
            {
                throw new Exception("O nome do estudante é obrigatório.");
            }
            
            if (student.FirstName.Length > 50)
            {
                throw new Exception("O nome do estudante não pode exceder 50 caracteres.");
            }

            if (!student.Email.EndsWith("@faculdade.edu"))
            {
                throw new Exception("E-mail invalido.");
            }


            var existingStudent = await _studentRepository.GetByEmail(student.Email);
            if (existingStudent != null)
                {
                    throw new Exception("Já existe estudante com esse e-mail.");
                }
                return await _studentRepository.SaveStudent(student);
            
        }

        public async Task<List<Student>> ListingStudent()
        {
            return await _studentRepository.ListingStudent();
        }
    }
}
