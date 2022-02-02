﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission5.Models;

namespace Mission5.Migrations
{
    [DbContext(typeof(NewMovieContext))]
    partial class NewMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission5.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "VHS"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("Mission5.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DirectorFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DirectorLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 4,
                            DirectorFirstName = "T.C.",
                            DirectorLastName = "Christensen",
                            Edited = false,
                            LentTo = "",
                            Notes = "The music is great",
                            Rating = "PG",
                            Title = "17 Miracles",
                            Year = 2011
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 4,
                            DirectorFirstName = "Kenneth",
                            DirectorLastName = "Branagh",
                            Edited = false,
                            LentTo = "",
                            Notes = "The music is great",
                            Rating = "PG",
                            Title = "Cinderella",
                            Year = 2015
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 4,
                            DirectorFirstName = "George",
                            DirectorLastName = "Miller",
                            Edited = false,
                            LentTo = "",
                            Notes = "The music is great",
                            Rating = "PG",
                            Title = "The Man from Snowy River",
                            Year = 1982
                        });
                });

            modelBuilder.Entity("Mission5.Models.MovieResponse", b =>
                {
                    b.HasOne("Mission5.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
