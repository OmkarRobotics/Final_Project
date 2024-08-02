namespace Final_Project.Models
{
    public class FavoriteBook
    {
        public FavoriteBook(int id, string name, string bookName, double bookPrice, string releaseDate)
        {
            this.Id = id;
            this.Name = name;
            this.BookName = bookName;
            this.BookPrice = bookPrice;
            this.ReleaseDate = releaseDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string BookName { get; set; }
        public double BookPrice { get; set; }
        public string ReleaseDate { get; set; }
    }
}
