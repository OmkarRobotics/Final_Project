namespace Final_Project.Models
{
    public class FavoriteBreakfast
    {
        public FavoriteBreakfast(int id, string name, string breakfastName, string description, double price)
        {
            this.Id = id;
            this.Name = name;
            this.BreakfastName = breakfastName;
            this.Description = description;
            this.Price = price;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string BreakfastName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
