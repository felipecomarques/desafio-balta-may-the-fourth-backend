﻿// <auto-generated />
using MayTheFourth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MayTheFourth.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240422174212_ModelConfiguration")]
    partial class ModelConfiguration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("MayTheFourth.Models.Movie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("MovieId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MayTheFourth.Models.StarShip", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("StarShipId");

                    b.Property<string>("CargoCapacity")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("cargoCapacity");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("class");

                    b.Property<string>("Consumables")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("consumables");

                    b.Property<long>("CostInCredits")
                        .HasColumnType("INTEGER")
                        .HasColumnName("costInCredits");

                    b.Property<int>("Crew")
                        .HasColumnType("INTEGER")
                        .HasColumnName("crew");

                    b.Property<double>("HyperdriveRating")
                        .HasColumnType("REAL")
                        .HasColumnName("hyperdriveRating");

                    b.Property<string>("Length")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("length");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("manufacturer");

                    b.Property<string>("MaxSpeed")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("maxSpeed");

                    b.Property<double>("Mglt")
                        .HasColumnType("REAL")
                        .HasColumnName("mglt");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<int>("Passangers")
                        .HasColumnType("INTEGER")
                        .HasColumnName("passangers");

                    b.HasKey("Id");

                    b.ToTable("StarShip");
                });
#pragma warning restore 612, 618
        }
    }
}