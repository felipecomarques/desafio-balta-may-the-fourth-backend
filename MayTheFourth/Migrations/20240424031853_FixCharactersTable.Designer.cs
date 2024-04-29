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
    [Migration("20240424031853_FixCharactersTable")]
    partial class FixCharactersTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("MayTheFourth.Models.Character", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("CharacterId");

                    b.Property<string>("BirthYear")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("birthYear");

                    b.Property<string>("EyeColor")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("eyeColor");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("gender");

                    b.Property<string>("HairColor")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("hairColor");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("height");

                    b.Property<string>("Movies")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("movies");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Planet")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("planet");

                    b.Property<string>("SkinColor")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("skinColor");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("weight");

                    b.HasKey("Id");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("MayTheFourth.Models.Planet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("PlanetId");

                    b.Property<string>("Characters")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("characters");

                    b.Property<string>("Climate")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("climate");

                    b.Property<string>("Diameter")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("diameter");

                    b.Property<string>("Gravity")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("gravity");

                    b.Property<string>("Movies")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("movies");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("OrbitalPeriod")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("orbitalPeriod");

                    b.Property<string>("Population")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("population");

                    b.Property<string>("RotationPeriod")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("rotationPeriod");

                    b.Property<string>("SurfaceWater")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("surfaceWater");

                    b.Property<string>("Terrain")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("terrain");

                    b.HasKey("Id");

                    b.ToTable("Planet");
                });

            modelBuilder.Entity("MayTheFourth.Models.StarShip", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("StarShipId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StarShip");
                });
#pragma warning restore 612, 618
        }
    }
}