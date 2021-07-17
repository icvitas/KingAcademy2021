using System.Collections.Generic;

namespace KingICT.KingAcademy2021.UnitTests.Model
{
    public class Course
    {
        public int Id { get; }

        public string Name { get; }

        public ICollection<Topic> Topics { get; init; }

        public ICollection<Student> Listeners { get; init; }

        public int MaxNumberOfListeners { get; init; }

        public Course(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
