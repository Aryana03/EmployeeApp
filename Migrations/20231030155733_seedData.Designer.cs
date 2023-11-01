﻿// <auto-generated />
using EmployeeApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeApp.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20231030155733_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeApp.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "Management",
                            Email = "michael.scott@nonamecompany.com",
                            FirstName = "Michael",
                            LastName = "Scott",
                            Password = "randompassword",
                            Role = "CEO",
                            Username = "MScott",
                            isAdmin = true
                        },
                        new
                        {
                            Id = 2,
                            Department = "Marketing",
                            Email = "alice.rodriguez@nonamecompany.com",
                            FirstName = "Alice",
                            LastName = "Rodriguez",
                            Password = "12345",
                            Role = "Marketing Manager",
                            Username = "ARodriguez",
                            isAdmin = true
                        },
                        new
                        {
                            Id = 3,
                            Department = "Human Resources",
                            Email = "olivia.patel@nonamecompany.com",
                            FirstName = "Olivia",
                            LastName = "Patel",
                            Password = "12345",
                            Role = "HR Coordinator",
                            Username = "OPatel",
                            isAdmin = true
                        },
                        new
                        {
                            Id = 4,
                            Department = "IT",
                            Email = "david.nguyen@nonamecompany.com",
                            FirstName = "David",
                            LastName = "Nguyen",
                            Password = "12345",
                            Role = "Software Developer",
                            Username = "DNguyen",
                            isAdmin = false
                        },
                        new
                        {
                            Id = 5,
                            Department = "Customer Service",
                            Email = "sophia.garcia@nonamecompany.com",
                            FirstName = "Sophia",
                            LastName = "Garcia",
                            Password = "12345",
                            Role = "Customer Support Representative",
                            Username = "SGarcia",
                            isAdmin = false
                        },
                        new
                        {
                            Id = 6,
                            Department = "IT",
                            Email = "daniel.kim@nonamecompany.com",
                            FirstName = "Daniel",
                            LastName = "Kim",
                            Password = "12345",
                            Role = "Systems Administrator",
                            Username = "DKim",
                            isAdmin = false
                        },
                        new
                        {
                            Id = 7,
                            Department = "Operations",
                            Email = "emily.ali@nonamecompany.com",
                            FirstName = "Emily",
                            LastName = "Ali",
                            Password = "12345",
                            Role = "Operations Coordinator",
                            Username = "EAli",
                            isAdmin = false
                        },
                        new
                        {
                            Id = 8,
                            Department = "Sales",
                            Email = "amelia.williams@nonamecompany.com",
                            FirstName = "Amelia",
                            LastName = "Williams",
                            Password = "12345",
                            Role = "Sales Analyst",
                            Username = "AWilliams",
                            isAdmin = false
                        },
                        new
                        {
                            Id = 9,
                            Department = "IT",
                            Email = "mia.davis@nonamecompany.com",
                            FirstName = "Mia",
                            LastName = "Davis",
                            Password = "12345",
                            Role = "IT Support Specialist",
                            Username = "MDavis",
                            isAdmin = false
                        },
                        new
                        {
                            Id = 10,
                            Department = "Sales",
                            Email = "gabriel.hernandez@nonamecompany.com",
                            FirstName = "Gabriel",
                            LastName = "Hernandez",
                            Password = "12345",
                            Role = "Sales Support Specialist",
                            Username = "GHernandez",
                            isAdmin = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}