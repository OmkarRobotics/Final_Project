namespace Final_Project.Models
{
    public class TeamMember
    {
        public TeamMember(int Id, string Name, string Birthdate, string CollegeProgram, string Year) { 
            this.Id = Id;
            this.Name = Name;
            this.Birthdate = Birthdate;
            this.CollegeProgram = CollegeProgram;
            this.Year = Year;
        }
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string CollegeProgram { get; set; }
        public string Year { get; set; }
    }
}
