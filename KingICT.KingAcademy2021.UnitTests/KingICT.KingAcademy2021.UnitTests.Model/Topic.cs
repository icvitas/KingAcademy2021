namespace KingICT.KingAcademy2021.UnitTests.Model
{
    public class Topic
    {
        public int Id { get; }

        public string Name { get; init; }

        public Topic(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
