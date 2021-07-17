using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace KingICT.KingAcademy2021.UnitTests.Model
{
    public class Student
    {
        public int Id { get; }

        public string Firstname { get; init; }

        public string Lastname { get; init; }

        public ICollection<Topic> Topics { get; init; }

        public Student(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Topics = new Collection<Topic>();
        }

        public string GetFullname()
        {
            return $"{Firstname} {Lastname}";
        }

        public void AddTopic(Topic topic)
        {
            if (Topics.Any(x => x.Id == topic.Id))
            {
                throw new Exception($"The student alredy has a {topic.Name} topic.");
            }

            Topics.Add(topic);
        }

        public void AddTopics(Topic[] topics)
        {
            foreach (var topic in topics)
            {
                AddTopic(topic);
            }
        }

        public void RemoveTopics()
        {
            Topics.Clear();
        }
    }
}
