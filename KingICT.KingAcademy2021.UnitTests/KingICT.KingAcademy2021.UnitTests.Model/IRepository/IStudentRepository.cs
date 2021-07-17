using System.Threading.Tasks;

namespace KingICT.KingAcademy2021.UnitTests.Model.IRepository
{
    public interface IStudentRepository
    {
        Task<Student> Get(int id);
    }
}
