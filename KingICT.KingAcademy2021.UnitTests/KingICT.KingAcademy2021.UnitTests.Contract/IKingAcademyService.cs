using KingICT.KingAcademy2021.UnitTests.Messaging.KingAcademy;
using System.Threading.Tasks;

namespace KingICT.KingAcademy2021.UnitTests.Contract
{
    public interface IKingAcademyService
    {
        Task AddStudentAsync(AddStudentRequestDto requestDto);
    }
}
