namespace Final_Project.Models
{
    public class Hobby
    {
        public Hobby(string name, string hobbyName, string description, string frequencyPerWeek)
        {
            this.Name = name;
            this.HobbyName = hobbyName;
            this.Description = description;
            this.FrequencyPerWeek = frequencyPerWeek;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string HobbyName { get; set; }
        public string Description { get; set; }
        public string FrequencyPerWeek { get; set; }
    }
}
