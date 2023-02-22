﻿// <auto-generated />
using System;
using LabsAndCoursesManagement.DataAccess.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabsAndCoursesManagement.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230102235311_InitialTenant3")]
    partial class InitialTenant3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LabStudent", b =>
                {
                    b.Property<Guid>("LabsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LabsId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("LabStudent");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Homework", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Bonus")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Homework");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Lab", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Labs");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EvaluationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EvaluationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cabinet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("StudentID")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LabStudent", b =>
                {
                    b.HasOne("LabsAndCoursesManagement.Models.Models.Lab", null)
                        .WithMany()
                        .HasForeignKey("LabsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabsAndCoursesManagement.Models.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Lab", b =>
                {
                    b.HasOne("LabsAndCoursesManagement.Models.Models.Teacher", "Teacher")
                        .WithMany("Labs")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Teacher", b =>
                {
                    b.HasOne("LabsAndCoursesManagement.Models.Models.Course", null)
                        .WithMany("Students")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.User", b =>
                {
                    b.HasOne("LabsAndCoursesManagement.Models.Models.Teacher", "Student")
                        .WithOne()
                        .HasForeignKey("LabsAndCoursesManagement.Models.Models.User", "StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Course", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("LabsAndCoursesManagement.Models.Models.Teacher", b =>
                {
                    b.Navigation("Labs");
                });
#pragma warning restore 612, 618
        }
    }
}