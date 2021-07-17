using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace KingICT.KingAcademy2021.UnitTests.Model
{
    public class KingAcademy
    {
        public int Id { get; }

        public string Name { get; }

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
            if (Students.Any(x => x.Id == student.Id))
            {
                throw new Exception("Student is alredy added");
            }

            Students.Add(student);
        }
    }
}
