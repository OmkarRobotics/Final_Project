namespace Final_Project.Models
{
    public class Hobby
    {
        public Hobby(string name, string hobbyName, string description, string frequencyPerWeek)
        {
            Name = name;
            HobbyName = hobbyName;
            Description = description;
            FrequencyPerWeek = frequencyPerWeek;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string HobbyName { get; set; }
        public string Description { get; set; }
        public string FrequencyPerWeek { get; set; }
    }
}
