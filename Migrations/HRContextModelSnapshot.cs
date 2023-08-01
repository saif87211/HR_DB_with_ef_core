﻿// <auto-generated />
using System;
using HR_DB_with_ef_core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR_DB_with_ef_core.Migrations
{
    [DbContext(typeof(HRContext))]
    partial class HRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("HR_DB_with_ef_core.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<int>("RegionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CountryId");

                    b.HasIndex("RegionId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DepartmentId");

                    b.HasIndex("LocationId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<string>("City")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnOrder(4);

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(5);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.HasKey("LocationId");

                    b.HasIndex("CountryId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Models.Dependent", b =>
                {
                    b.Property<int>("DependentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.Property<string>("RelationsShip")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT")
                        .HasColumnOrder(4);

                    b.HasKey("DependentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Dependents");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(4);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<DateOnly>("HireDate")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(6);

                    b.Property<int>("JobId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(7);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.Property<int?>("ManagerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(5);

                    b.Property<int?>("Salary")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaxSalary")
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.Property<string>("MinSalary")
                        .HasMaxLength(6)
                        .HasColumnType("TEXT");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Country", b =>
                {
                    b.HasOne("HR_DB_with_ef_core.Region", "Region")
                        .WithMany("Countries")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Department", b =>
                {
                    b.HasOne("HR_DB_with_ef_core.Location", "Location")
                        .WithMany("Departments")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Location", b =>
                {
                    b.HasOne("HR_DB_with_ef_core.Country", "Country")
                        .WithMany("Locations")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Models.Dependent", b =>
                {
                    b.HasOne("HR_DB_with_ef_core.Models.Employee", "Employee")
                        .WithMany("Dependents")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Models.Employee", b =>
                {
                    b.HasOne("HR_DB_with_ef_core.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_DB_with_ef_core.Models.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR_DB_with_ef_core.Models.Employee", "Manager")
                        .WithMany("Employees")
                        .HasForeignKey("ManagerId");

                    b.Navigation("Department");

                    b.Navigation("Job");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Country", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Location", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Models.Employee", b =>
                {
                    b.Navigation("Dependents");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Models.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("HR_DB_with_ef_core.Region", b =>
                {
                    b.Navigation("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
