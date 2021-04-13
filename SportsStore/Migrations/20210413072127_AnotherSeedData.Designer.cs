﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsStore.Models;

namespace SportsStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210413072127_AnotherSeedData")]
    partial class AnotherSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal (8,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Watersports",
                            Description = "A 1 Person Boat",
                            Name = "Kayak",
                            Price = 275m
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Watersports",
                            Description = "Protective & Fashionable",
                            Name = "Life Jacket",
                            Price = 48.95m
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Soccer",
                            Description = "Like The Pros",
                            Name = "Corner Flags",
                            Price = 19.50m
                        },
                        new
                        {
                            ProductId = 5,
                            Category = "Running",
                            Description = "A New Level Of Comfort",
                            Name = "Running Shoes",
                            Price = 89.95m
                        },
                        new
                        {
                            ProductId = 6,
                            Category = "Football",
                            Description = "Broncos Logo",
                            Name = "Football",
                            Price = 59.95m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
