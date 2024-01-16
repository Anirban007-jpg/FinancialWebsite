using FinancialWebsite.Model;
using MongoDB.Bson;

namespace FinancialWebsite.Repositories
{
    public interface IStudentRepository
    {
        Task<ObjectId> Create(Student);
        Task<Student> Get(ObjectId id);
        Task<IEnumerable<Student>> GetAll();
        Task<IEnumerable<Student>> GetByName(string Name);

    }
}
