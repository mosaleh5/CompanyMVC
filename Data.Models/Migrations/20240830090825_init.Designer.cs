﻿// <auto-generated />
using System;
using Company.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company.Data.Migrations
{
    [DbContext(typeof(CompanyDBContext))]
    [Migration("20240830090825_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Company.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Company.Data.Entities.Employee", b =>
                {
                    b.HasOne("Company.Data.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
