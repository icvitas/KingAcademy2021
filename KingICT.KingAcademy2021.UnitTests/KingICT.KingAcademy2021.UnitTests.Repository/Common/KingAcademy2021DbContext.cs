using Microsoft.EntityFrameworkCore;

namespace KingICT.KingAcademy2021.UnitTests.Repository.Common
{
    public class KingAcademy2021DbContext : DbContext
    {
        public KingAcademy2021DbContext(DbContextOptions<KingAcademy2021DbContext> options)
            : base(options) { }
    }
}
