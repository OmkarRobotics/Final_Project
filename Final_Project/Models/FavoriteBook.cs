namespace Final_Project.Models
{
    public class FavoriteBook
    {
        public FavoriteBook(string name, string bookName, string bookPrice, string releaseDate)
        {
            Name = name;
            BookName = bookName;
            BookPrice = bookPrice;
            ReleaseDate = releaseDate;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string BookName { get; set; }
        public string BookPrice { get; set; }
        public string ReleaseDate { get; set; }
    }
}
