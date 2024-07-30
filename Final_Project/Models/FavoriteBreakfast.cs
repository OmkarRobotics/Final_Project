namespace Final_Project.Models
{
    public class FavoriteBreakfast
    {
        public FavoriteBreakfast(string name, string breakfastName, string description, string price)
        {
            Name = name;
            BreakfastName = breakfastName;
            Description = description;
            Price = price;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string BreakfastName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
