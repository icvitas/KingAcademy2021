using KingICT.KingAcademy2021.UnitTests.Contract;
using KingICT.KingAcademy2021.UnitTests.Messaging.KingAcademy;
using KingICT.KingAcademy2021.UnitTests.Model.IRepository;
using KingICT.KingAcademy2021.UnitTests.Repository.Common;
using KingICT.KingAcademy2021.UnitTests.Service.Common;
using System.Threading.Tasks;

namespace KingICT.KingAcademy2021.UnitTests.Service
{
    public class KingAcademyService : ServiceBase, IKingAcademyService
    {
        private readonly IKingAcademyRepository _kingAcademyRepository;
        private readonly IStudentRepository _studentRepository;

        public KingAcademyService(
            KingAcademy2021DbContext dbContext,
            IKingAcademyRepository kingAcademyRepository,
            IStudentRepository studentRepository
        ) : base(dbContext)
        {
            _kingAcademyRepository = kingAcademyRepository;
            _studentRepository = studentRepository;
        }

        public async Task AddStudentAsync(AddStudentRequestDto requestDto)
        {
            var kingAcademy = await _kingAcademyRepository.Get(requestDto.KingAcademyId);
            var student = await _studentRepository.Get(requestDto.StudentId);

            kingAcademy.AddStudent(student);

            await _kingAcademyRepository.Update(kingAcademy);

            await DbContext.SaveChangesAsync();
        }
    }
}
