using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KingICT.KingAcademy2021.UnitTests.Model
{
    public class KingAcademy
    {
        public int Id { get; }

        public string Name { get; init; }

        public ICollection<Student> Students { get; init; }

        public ICollection<Course> Courses { get; init; }

        public int MaxNumberOfStudents { get; init; }

        public KingAcademy()
        {
            Students = new Collection<Student>();
            Courses = new Collection<Course>();
        }

        public KingAcademy(int id, string name)
            : this()
        {
            Id = id;
            Name = name;
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
