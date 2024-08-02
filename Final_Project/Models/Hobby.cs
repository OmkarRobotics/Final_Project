namespace Final_Project.Models
{
    public class Hobby
    {
        public Hobby(int id, string Name, string HobbyName, string Description, int FrequencyPerWeek)
        {
            this.Id = id;
            this.Name = Name;
            this.HobbyName = HobbyName;
            this.Description = Description;
            this.FrequencyPerWeek = FrequencyPerWeek;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string HobbyName { get; set; }
        public string Description { get; set; }
        public int FrequencyPerWeek { get; set; }
    }
}
