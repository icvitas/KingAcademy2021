using System.Threading.Tasks;

namespace KingICT.KingAcademy2021.UnitTests.Model.IRepository
{
    public interface IKingAcademyRepository
    {
        Task<KingAcademy> Get(int id);

        Task Update(KingAcademy kingAcademy);
    }
}
