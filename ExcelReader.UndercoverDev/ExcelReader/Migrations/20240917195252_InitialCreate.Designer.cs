﻿// <auto-generated />
using ExcelReader.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExcelReader.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240917195252_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ExcelReader.Models.DataModel", b =>
                {
                    b.Property<string>("Away")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AwayProbability")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Home")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeProbability")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("League")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OverTwoGoals")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("DataModels");
                });
#pragma warning restore 612, 618
        }
    }
}
