using KingICT.KingAcademy2021.UnitTests.Model;
using KingICT.KingAcademy2021.UnitTests.Model.IRepository;
using System.Threading.Tasks;

namespace KingICT.KingAcademy2021.UnitTests.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public Task<Student> Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
