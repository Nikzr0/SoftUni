﻿// <auto-generated />
using System;
using Ex02.MigrationExersices.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ex02.MigrationExersices.Migrations
{
    [DbContext(typeof(BudgetContext))]
    partial class BudgetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ex02.MigrationExersices.Models.Expenses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("expensId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("expensId");

                    b.ToTable("Expens");
                });

            modelBuilder.Entity("Ex02.MigrationExersices.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Ex02.MigrationExersices.Models.Expenses", b =>
                {
                    b.HasOne("Ex02.MigrationExersices.Models.Expenses", "expens")
                        .WithMany()
                        .HasForeignKey("expensId");

                    b.Navigation("expens");
                });
#pragma warning restore 612, 618
        }
    }
}
