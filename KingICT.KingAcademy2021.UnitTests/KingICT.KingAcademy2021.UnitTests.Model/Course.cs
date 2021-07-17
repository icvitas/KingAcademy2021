using System.Collections.Generic;

namespace KingICT.KingAcademy2021.UnitTests.Model
{
    public class Course
    {
        public int Id { get; }

        public int Name { get; init; }

        public ICollection<Topic> Topics { get; init; }

        public ICollection<Student> Listeners { get; }

        public int MaxNumberOfListeners { get; init; }
    }
}
