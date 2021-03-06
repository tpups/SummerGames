﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using SummerGames.Models;
using System;

namespace SummerGames.Migrations
{
    [DbContext(typeof(SummerContext))]
    partial class SummerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("SummerGames.Models.Encounters", b =>
                {
                    b.Property<int>("EncountersId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PlayerId");

                    b.Property<int>("dragons");

                    b.Property<int>("orcs");

                    b.Property<int>("spiders");

                    b.Property<int>("totalEnemies");

                    b.Property<int>("zombies");

                    b.HasKey("EncountersId");

                    b.HasIndex("PlayerId");

                    b.ToTable("encounters");
                });

            modelBuilder.Entity("SummerGames.Models.Enemies", b =>
                {
                    b.Property<int>("EnemiesId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("EncountersId");

                    b.Property<int>("health");

                    b.Property<int>("healthMax");

                    b.Property<bool>("life");

                    b.Property<string>("name");

                    b.Property<int>("strength");

                    b.HasKey("EnemiesId");

                    b.HasIndex("EncountersId");

                    b.ToTable("enemies");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Enemies");
                });

            modelBuilder.Entity("SummerGames.Models.Multiplayer", b =>
                {
                    b.Property<int>("MultiplayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EncountersId");

                    b.Property<int>("PlayerId");

                    b.HasKey("MultiplayerId");

                    b.HasIndex("EncountersId");

                    b.HasIndex("PlayerId");

                    b.ToTable("multiplayer");
                });

            modelBuilder.Entity("SummerGames.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.Property<int>("dexterity");

                    b.Property<int>("health");

                    b.Property<int>("healthMax");

                    b.Property<int>("intelligence");

                    b.Property<bool>("life");

                    b.Property<int>("strength");

                    b.HasKey("PlayerId");

                    b.ToTable("player");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Player");
                });

            modelBuilder.Entity("SummerGames.Models.Story", b =>
                {
                    b.Property<int>("StoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PlayerId");

                    b.Property<DateTime>("created_at");

                    b.Property<int>("flag");

                    b.Property<string>("storyBook");

                    b.HasKey("StoryId");

                    b.HasIndex("PlayerId");

                    b.ToTable("storyline");
                });

            modelBuilder.Entity("SummerGames.Models.Dragon", b =>
                {
                    b.HasBaseType("SummerGames.Models.Enemies");


                    b.ToTable("Dragon");

                    b.HasDiscriminator().HasValue("Dragon");
                });

            modelBuilder.Entity("SummerGames.Models.Orc", b =>
                {
                    b.HasBaseType("SummerGames.Models.Enemies");


                    b.ToTable("Orc");

                    b.HasDiscriminator().HasValue("Orc");
                });

            modelBuilder.Entity("SummerGames.Models.Spider", b =>
                {
                    b.HasBaseType("SummerGames.Models.Enemies");


                    b.ToTable("Spider");

                    b.HasDiscriminator().HasValue("Spider");
                });

            modelBuilder.Entity("SummerGames.Models.Zombie", b =>
                {
                    b.HasBaseType("SummerGames.Models.Enemies");


                    b.ToTable("Zombie");

                    b.HasDiscriminator().HasValue("Zombie");
                });

            modelBuilder.Entity("SummerGames.Models.Hunter", b =>
                {
                    b.HasBaseType("SummerGames.Models.Player");


                    b.ToTable("Hunter");

                    b.HasDiscriminator().HasValue("Hunter");
                });

            modelBuilder.Entity("SummerGames.Models.Mage", b =>
                {
                    b.HasBaseType("SummerGames.Models.Player");


                    b.ToTable("Mage");

                    b.HasDiscriminator().HasValue("Mage");
                });

            modelBuilder.Entity("SummerGames.Models.Ninja", b =>
                {
                    b.HasBaseType("SummerGames.Models.Player");


                    b.ToTable("Ninja");

                    b.HasDiscriminator().HasValue("Ninja");
                });

            modelBuilder.Entity("SummerGames.Models.Priest", b =>
                {
                    b.HasBaseType("SummerGames.Models.Player");


                    b.ToTable("Priest");

                    b.HasDiscriminator().HasValue("Priest");
                });

            modelBuilder.Entity("SummerGames.Models.Samurai", b =>
                {
                    b.HasBaseType("SummerGames.Models.Player");


                    b.ToTable("Samurai");

                    b.HasDiscriminator().HasValue("Samurai");
                });

            modelBuilder.Entity("SummerGames.Models.Encounters", b =>
                {
                    b.HasOne("SummerGames.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SummerGames.Models.Enemies", b =>
                {
                    b.HasOne("SummerGames.Models.Encounters", "Encounters")
                        .WithMany()
                        .HasForeignKey("EncountersId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SummerGames.Models.Multiplayer", b =>
                {
                    b.HasOne("SummerGames.Models.Encounters", "Encounters")
                        .WithMany()
                        .HasForeignKey("EncountersId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SummerGames.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SummerGames.Models.Story", b =>
                {
                    b.HasOne("SummerGames.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
