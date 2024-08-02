﻿// <auto-generated />
using Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_Project.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240802021814_AddNewColumnToTable")]
    partial class AddNewColumnToTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Final_Project.Models.FavoriteBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BookPrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteBooks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookName = "Animal Farm",
                            BookPrice = 5.9900000000000002,
                            Name = "Omkar Seth",
                            ReleaseDate = "08/17/1945"
                        },
                        new
                        {
                            Id = 2,
                            BookName = "Harry Potter and the Goblet of Fire",
                            BookPrice = 9.9499999999999993,
                            Name = "Sunav Adhikari",
                            ReleaseDate = "07/08/2000"
                        },
                        new
                        {
                            Id = 3,
                            BookName = "House of Leaves",
                            BookPrice = 14.949999999999999,
                            Name = "Nathan Dahlquist",
                            ReleaseDate = "03/07/2000"
                        },
                        new
                        {
                            Id = 4,
                            BookName = "Ms.Peregrines Home for Peculiar Children",
                            BookPrice = 12.99,
                            Name = "Sydney Hutton",
                            ReleaseDate = "06/07/2011"
                        });
                });

            modelBuilder.Entity("Final_Project.Models.FavoriteBreakfast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BreakfastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("FavoriteBreakfasts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BreakfastName = "Waffles",
                            Description = "A crispy batter cake with a gridlike design",
                            Name = "Omkar Seth",
                            Price = 2.9700000000000002
                        },
                        new
                        {
                            Id = 2,
                            BreakfastName = "Pancakes",
                            Description = "circular baked pancake mix",
                            Name = "Sunav Adhikari",
                            Price = 4.9500000000000002
                        },
                        new
                        {
                            Id = 3,
                            BreakfastName = "Hash Browns",
                            Description = "Fried potato slices",
                            Name = "Nathan Dahlquist",
                            Price = 4.4500000000000002
                        },
                        new
                        {
                            Id = 4,
                            BreakfastName = "Bagels",
                            Description = "Two pieces of toasted bread with creamcheese",
                            Name = "Sydney Hutton",
                            Price = 4.9500000000000002
                        });
                });

            modelBuilder.Entity("Final_Project.Models.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FrequencyPerWeek")
                        .HasColumnType("int");

                    b.Property<string>("HobbyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Playing classical music",
                            FrequencyPerWeek = 3,
                            HobbyName = "Piano",
                            Name = "Omkar Seth"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Breaststroke and Backstroke",
                            FrequencyPerWeek = 5,
                            HobbyName = "Swimming",
                            Name = "Sunav Adhikari"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Collecting and learning about retro hardware, especially video game related",
                            FrequencyPerWeek = 2,
                            HobbyName = "Vintage Tech Collecting",
                            Name = "Nathan Dahlquist"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Creating collages",
                            FrequencyPerWeek = 3,
                            HobbyName = "Art",
                            Name = "Sydney Hutton"
                        });
                });

            modelBuilder.Entity("Final_Project.Models.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Birthdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = "11/12",
                            CollegeProgram = "College Credit Plus",
                            Name = "Omkar Seth",
                            Year = "Freshman"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = "01/8",
                            CollegeProgram = "College Credit Plus",
                            Name = "Sunav Adhikari",
                            Year = "Freshman"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = "07/29",
                            CollegeProgram = "Information Technology",
                            Name = "Nathan Dahlquist",
                            Year = "Junior"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = "02/18",
                            CollegeProgram = "Information Technology",
                            Name = "Sydney Hutton",
                            Year = "Junior"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
