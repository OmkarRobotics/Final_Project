using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Migrations
{
    public partial class AddNewColumnToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPrice = table.Column<double>(type: "float", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteBreakfasts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreakfastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBreakfasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrequencyPerWeek = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteBooks",
                columns: new[] { "Id", "BookName", "BookPrice", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Animal Farm", 5.9900000000000002, "Omkar Seth", "08/17/1945" },
                    { 2, "Harry Potter and the Goblet of Fire", 9.9499999999999993, "Sunav Adhikari", "07/08/2000" },
                    { 3, "House of Leaves", 14.949999999999999, "Nathan Dahlquist", "03/07/2000" },
                    { 4, "Ms.Peregrines Home for Peculiar Children", 12.99, "Sydney Hutton", "06/07/2011" }
                });

            migrationBuilder.InsertData(
                table: "FavoriteBreakfasts",
                columns: new[] { "Id", "BreakfastName", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Waffles", "A crispy batter cake with a gridlike design", "Omkar Seth", 2.9700000000000002 },
                    { 2, "Pancakes", "circular baked pancake mix", "Sunav Adhikari", 4.9500000000000002 },
                    { 3, "Hash Browns", "Fried potato slices", "Nathan Dahlquist", 4.4500000000000002 },
                    { 4, "Bagels", "Two pieces of toasted bread with creamcheese", "Sydney Hutton", 4.9500000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Description", "FrequencyPerWeek", "HobbyName", "Name" },
                values: new object[,]
                {
                    { 1, "Playing classical music", 3, "Piano", "Omkar Seth" },
                    { 2, "Breaststroke and Backstroke", 5, "Swimming", "Sunav Adhikari" },
                    { 3, "Collecting and learning about retro hardware, especially video game related", 2, "Vintage Tech Collecting", "Nathan Dahlquist" },
                    { 4, "Creating collages", 3, "Art", "Sydney Hutton" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "11/12", "College Credit Plus", "Omkar Seth", "Freshman" },
                    { 2, "01/8", "College Credit Plus", "Sunav Adhikari", "Freshman" },
                    { 3, "07/29", "Information Technology", "Nathan Dahlquist", "Junior" },
                    { 4, "02/18", "Information Technology", "Sydney Hutton", "Junior" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteBooks");

            migrationBuilder.DropTable(
                name: "FavoriteBreakfasts");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
