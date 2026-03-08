
namespace management.Domain.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string Email { get; set; }

        internal bool IsNullOrWhiteSapece(object firstName)
        {
            throw new NotImplementedException();
        }
    }
}
