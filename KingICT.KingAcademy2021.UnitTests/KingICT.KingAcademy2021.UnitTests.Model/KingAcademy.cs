using System.Collections.Generic;

namespace KingICT.KingAcademy2021.UnitTests.Model
{
    public class KingAcademy
    {
        public int Id { get; }

        public int Name { get; init; }

        public ICollection<Student> Students { get; init; }

        public ICollection<Course> Courses { get; init; }

        public int MaxNumberOfStudents { get; init; }
    }
}
