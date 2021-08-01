﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PropTabTabIK.DataAccess.Context;

namespace PropTabTabIK.DataAccess.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20210624062356_cvk4")]
    partial class cvk4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.CompanyAdmin", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("ErrorLogin")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("PackageID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProfilPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchasePackageDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<Guid>("SiteAdminID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("PackageID");

                    b.HasIndex("SiteAdminID");

                    b.ToTable("CompanyAdmins");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.Employee", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<byte>("AllowCount")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CompanyAdminID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("ErrorLogin")
                        .HasColumnType("tinyint");

                    b.Property<decimal?>("IBAN")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("TCNo")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CompanyAdminID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.SiteAdmin", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("ErrorLogin")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProfilPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("SuperAdminID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("SuperAdminID");

                    b.ToTable("SiteAdmins");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.SuperAdmin", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("ErrorLogin")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProfilPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("SuperAdmins");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.AdvancePayment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ConfirmedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("AdvancePayments");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.AllowRequest", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<int>("AllowTime")
                        .HasColumnType("int");

                    b.Property<int>("AllowType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ConfirmedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<byte>("TotalAllowTime")
                        .HasColumnType("tinyint");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("AllowRequests");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Contract", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("OwnerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PackageID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Department", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("CompanyID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<Guid>("LocationID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("LocationID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.EmployeeAllowRequest", b =>
                {
                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AllowRequestID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("AllowRight")
                        .HasColumnType("tinyint");

                    b.HasKey("EmployeeID", "AllowRequestID");

                    b.ToTable("EmployeeAllowRequests");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Expense", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Location", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.MailTemplate", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("MailTemplates");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.OvertimePeriod", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<DateTime>("ConfirmedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("OvertimePeriods");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Package", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<int>("ExpireTime")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Unit", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("DepartmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.CompanyAdmin", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.SideEntities.Package", "Package")
                        .WithMany("Companies")
                        .HasForeignKey("PackageID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PropTabTabIK.Entities.Entities.SiteAdmin", "SiteAdmin")
                        .WithMany("CompanyAdmins")
                        .HasForeignKey("SiteAdminID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("SiteAdmin");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.Employee", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.Entities.CompanyAdmin", "CompanyAdmin")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyAdminID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CompanyAdmin");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.SiteAdmin", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.Entities.SuperAdmin", "SuperAdmin")
                        .WithMany("SiteAdmins")
                        .HasForeignKey("SuperAdminID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("SuperAdmin");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.AdvancePayment", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.Entities.Employee", "Employee")
                        .WithMany("AdvancePayments")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.AllowRequest", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.Entities.Employee", "Employee")
                        .WithMany("AllowRequests")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Department", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.Entities.CompanyAdmin", "CompanyAdmin")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PropTabTabIK.Entities.SideEntities.Location", "Location")
                        .WithMany("Departments")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CompanyAdmin");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Expense", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.Entities.Employee", "Employee")
                        .WithMany("Expenses")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.OvertimePeriod", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.Entities.Employee", "Employee")
                        .WithMany("OvertimePeriods")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Unit", b =>
                {
                    b.HasOne("PropTabTabIK.Entities.SideEntities.Department", "Department")
                        .WithMany("Units")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.CompanyAdmin", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.Employee", b =>
                {
                    b.Navigation("AdvancePayments");

                    b.Navigation("AllowRequests");

                    b.Navigation("Expenses");

                    b.Navigation("OvertimePeriods");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.SiteAdmin", b =>
                {
                    b.Navigation("CompanyAdmins");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.Entities.SuperAdmin", b =>
                {
                    b.Navigation("SiteAdmins");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Department", b =>
                {
                    b.Navigation("Units");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Location", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("PropTabTabIK.Entities.SideEntities.Package", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
