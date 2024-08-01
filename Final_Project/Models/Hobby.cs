namespace Final_Project.Models
{
    public class Hobby
    {
        public Hobby(string Name, string HobbyName, string Description, string FrequencyPerWeek)
        {
            this.Name = Name;
            this.HobbyName = HobbyName;
            this.Description = Description;
            this.FrequencyPerWeek = FrequencyPerWeek;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string HobbyName { get; set; }
        public string Description { get; set; }
        public string FrequencyPerWeek { get; set; }
    }
}
