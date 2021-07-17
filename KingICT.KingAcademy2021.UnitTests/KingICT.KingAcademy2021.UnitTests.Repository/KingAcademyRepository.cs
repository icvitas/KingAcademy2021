using KingICT.KingAcademy2021.UnitTests.Model;
using KingICT.KingAcademy2021.UnitTests.Model.IRepository;
using System.Threading.Tasks;

namespace KingICT.KingAcademy2021.UnitTests.Repository
{
    public class KingAcademyRepository : IKingAcademyRepository
    {
        public Task<KingAcademy> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(KingAcademy kingAcademy)
        {
            throw new System.NotImplementedException();
        }
    }
}
