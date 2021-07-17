using KingICT.KingAcademy2021.UnitTests.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KingICT.KingAcademy2021.UnitTests.UnitTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void FullnameIsCorrect_When_CreateStudent()
        {
            // Arrange
            var student = new Student(1, "Luka", "Modriæ");

            // Act
            var actual = student.GetFullname();

            // Assert
            var expected = "Luka Modriæ";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HaveOneTopic_When_AddTopic()
        {
            // Arrange
            var student = new Student(1, "Luka", "Modriæ");
            var studentTopic = new Topic(1, ".NET");

            // Act
            student.AddTopic(studentTopic);

            // Assert
            Assert.AreEqual(1, student.Topics.Count);
        }

        [TestMethod]
        public void HaveTwoTopics_When_AddTwoTopics()
        {
            // Arrange
            var student = new Student(1, "Luka", "Modriæ");
            var studentTopics = new[]
            {
                new Topic(1, ".NET"),
                new Topic(2, "Java")
            };

            // Act
            student.AddTopics(studentTopics);

            // Assert
            Assert.AreEqual(2, student.Topics.Count);
        }

        [TestMethod]
        public void NoTopics_When_RemoveTopic()
        {
            // Arrange
            var student = new Student(1, "Luka", "Modriæ");

            // Act
            student.RemoveTopics();

            // Assert
            Assert.AreEqual(0, student.Topics.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TopicExistException_When_AddTopic()
        {
            // Arrange
            var student = new Student(1, "Luka", "Modriæ")
            {
                Topics = new List<Topic>()
                {
                    new Topic(1, ".NET")
                }
            };

            // Act
            student.AddTopic(new Topic(1, ".NET"));
        }
    }
}
