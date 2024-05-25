﻿// <auto-generated />
using BlazorFileUploadDownload.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorFileUploadDownload.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("BlazorFileUploadDownload.Domain.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(7, 2)")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Assassin's Creed",
                            Preco = 135m
                        },
                        new
                        {
                            Id = 2,
                            Nome = "FallOut 4",
                            Preco = 155m
                        },
                        new
                        {
                            Id = 3,
                            Nome = "BordeLands",
                            Preco = 195m
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Duke Nukem",
                            Preco = 58m
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Maria Cart Deluxe 8",
                            Preco = 350m
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Castlevania",
                            Preco = 35m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
