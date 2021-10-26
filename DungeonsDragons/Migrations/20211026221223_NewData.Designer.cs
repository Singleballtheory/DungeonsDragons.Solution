﻿// <auto-generated />
using DungeonsDragons.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DungeonsDragons.Migrations
{
    [DbContext(typeof(DungeonsDragonsContext))]
    [Migration("20211026221223_NewData")]
    partial class NewData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DungeonsDragons.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Profession")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Weapon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            Age = "15",
                            Gender = "Male",
                            Name = "Hank",
                            Profession = "Ranger",
                            Weapon = "Bow"
                        },
                        new
                        {
                            CharacterId = 2,
                            Age = "15",
                            Gender = "Male",
                            Name = "Eric",
                            Profession = "Cavalier",
                            Weapon = "Shield"
                        },
                        new
                        {
                            CharacterId = 3,
                            Age = "14",
                            Gender = "Female",
                            Name = "Diana",
                            Profession = "Acrobat",
                            Weapon = "Staff"
                        },
                        new
                        {
                            CharacterId = 4,
                            Age = "14",
                            Gender = "Male",
                            Name = "Presto",
                            Profession = "Magican",
                            Weapon = "Hat"
                        },
                        new
                        {
                            CharacterId = 5,
                            Age = "13",
                            Gender = "Female",
                            Name = "Sheila",
                            Profession = "Thief",
                            Weapon = "Cloak"
                        },
                        new
                        {
                            CharacterId = 6,
                            Age = "8",
                            Gender = "Male",
                            Name = "Bobby",
                            Profession = "Barbarian",
                            Weapon = "Club"
                        },
                        new
                        {
                            CharacterId = 7,
                            Age = "Unknown",
                            Gender = "Female",
                            Name = "Uni",
                            Profession = "Unicorn",
                            Weapon = "Teleport"
                        },
                        new
                        {
                            CharacterId = 8,
                            Age = "Unknown",
                            Gender = "Male",
                            Name = "Dungeon Master",
                            Profession = "Dungeon Master",
                            Weapon = "Magic"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}