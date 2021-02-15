﻿// <auto-generated />
using BethanysPieShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BethanysPieShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210215121156_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BethanysPieShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruit Pie",
                            Description = "All fruit pie"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Cheese cakes",
                            Description = "Chees"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Coffee",
                            Description = "Coffee beans makes drinks"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Fruit Juice",
                            Description = "All fruit juice"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProductOftheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/images/59b13b33-a1fd-47b3-a376-f735af81c40a.jpg",
                            InStock = false,
                            IsProductOftheWeek = false,
                            Name = "Strawberry Pie",
                            Price = 15.95m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/images/ApplePie.jpg",
                            InStock = false,
                            IsProductOftheWeek = false,
                            Name = "Appel Pie",
                            Price = 15.95m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            ImageThumbnailUrl = "~/images/CheeseCacke.jpg",
                            InStock = false,
                            IsProductOftheWeek = false,
                            Name = "Cheese cake",
                            Price = 15.95m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3,
                            ImageThumbnailUrl = "~/images/turkish-coffee.jpg",
                            InStock = false,
                            IsProductOftheWeek = false,
                            Name = "Turkey coffe",
                            Price = 15.95m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4,
                            ImageThumbnailUrl = "~/images/strawberrysmoothie.jpg",
                            InStock = false,
                            IsProductOftheWeek = false,
                            Name = "Strawberry Smoothy",
                            Price = 15.95m
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.Product", b =>
                {
                    b.HasOne("BethanysPieShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BethanysPieShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
