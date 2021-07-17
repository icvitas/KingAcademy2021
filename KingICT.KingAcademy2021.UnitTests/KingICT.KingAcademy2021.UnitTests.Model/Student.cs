using System.Collections.Generic;

namespace KingICT.KingAcademy2021.UnitTests.Model
{
    public class Student
    {
        public int Id { get; }

        public string Firstname { get; init; }

        public string Lastname { get; init; }

        public ICollection<Topic> Topics { get; init; }
    }
}
