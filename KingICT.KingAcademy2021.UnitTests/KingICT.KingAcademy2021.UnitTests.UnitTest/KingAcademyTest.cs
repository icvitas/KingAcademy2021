using KingICT.KingAcademy2021.UnitTests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace KingICT.KingAcademy2021.UnitTests.UnitTest
{
    [TestClass]
    public class KingAcademyTest
    {
        private KingAcademy kingAcademy;

        [TestInitialize]
        public void Setup()
        {
            var topics = new Collection<Topic>()
            {
                new Topic(1, ".NET"),
                new Topic(2, "Java"),
                new Topic(3, "BA"),
                new Topic(4, "QA")
            };

            var students = new Collection<Student>()
            {
                new Student(1, "Luka", "Modrić")
                {
                    Topics = new Collection<Topic>() { topics[0], topics[1] }
                },
                new Student(2, "Ivan", "Perišić")
                {
                    Topics = new Collection<Topic>() { topics[0] }
                },
                new Student(3, "Ivan", "Rakitić")
                {
                    Topics = new Collection<Topic>() { topics[2] }
                },
                new Student(4, "Šime", "Vrsaljko")
                {
                    Topics = new Collection<Topic>() { topics[3] }
                }
            };

            kingAcademy = new KingAcademy(1, "King Academy 2021")
            {
                MaxNumberOfStudents = 16,
                Students = students,
                Courses = new Collection<Course>
                {
                    new Course(1, "Backend arhitektura sustava")
                    {
                        MaxNumberOfListeners = 10,
                        Topics = new Collection<Topic>() { topics[0] },
                        Listeners = students.Where(student => student.Topics.Any(topic => topic.Id == topics[0].Id)).ToList()
                    },
                    new Course(2, "Hibernate i JPA")
                    {
                        MaxNumberOfListeners = 6,
                        Topics = new Collection<Topic>() { topics[1] },
                        Listeners = students.Where(student => student.Topics.Any(topic => topic.Id == topics[1].Id)).ToList()
                    },
                    new Course(3, "Funkcionalna specifikacija")
                    {
                        MaxNumberOfListeners = 30,
                        Topics = new Collection<Topic>()
                        { topics[2] },
                        Listeners = students.Where(student => student.Topics.Any(topic => topic.Id == topics[2].Id)).ToList()
                    },
                    new Course(4, "Radionica sa korisnicima")
                    {
                        MaxNumberOfListeners = 30,
                        Topics = new Collection<Topic>() { topics[2], topics[3] },
                        Listeners = students.Where(student => student.Topics.Any(topic => topic.Id == topics[2].Id || topic.Id == topics[3].Id)).ToList()
                    },
                    new Course(5, "Crtanje skica ekrana")
                    {
                        MaxNumberOfListeners = 30,
                        Topics = new Collection<Topic>() { topics[2] }
                    }
                }
            };
        }

        [TestMethod]
        public void StudentIsAdded_When_AddStudent()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void StudentIsNotAdded_When_StudentIsAlredyAdded()
        {
            // Assert
            var student = new Student(1, "Luka", "Modrić");

            // Act
            kingAcademy.AddStudent(student);
        }

        [TestMethod]
        public void StudentIsNotAdded_When_KingAcademyMaxNumberOfStudentsIsExceeded()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void StudentIsNotAdded_When_StudentDoNotHaveAnyTopic()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void StudentIsNotAdded_When_KingAcademyDoNotHaveAnyStudentTopic()
        {
            throw new NotImplementedException();
        }
    }
}
