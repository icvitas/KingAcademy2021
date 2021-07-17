using KingICT.KingAcademy2021.UnitTests.Repository.Common;

namespace KingICT.KingAcademy2021.UnitTests.Service.Common
{
    public abstract class ServiceBase
    {
        protected KingAcademy2021DbContext DbContext;

        protected ServiceBase(KingAcademy2021DbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
