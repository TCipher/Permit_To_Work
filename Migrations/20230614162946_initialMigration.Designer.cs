﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PermitToWorkSystem.Data;

#nullable disable

namespace PermitToWorkSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230614162946_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PermitToWorkSystem.Models.PermitToWorkForm", b =>
                {
                    b.Property<int>("PermitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermitID"));

                    b.Property<bool>("Accent")
                        .HasColumnType("bit");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration_Of_Work")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Equipment_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipment_To_Be_Used")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JSANO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("Type_Of_Work")
                        .HasColumnType("int");

                    b.HasKey("PermitID");

                    b.ToTable("permitToWorkForm");
                });

            modelBuilder.Entity("PermitToWorkSystem.Models.SiteCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Access")
                        .HasColumnType("bit");

                    b.Property<bool>("Barricade")
                        .HasColumnType("bit");

                    b.Property<string>("Bypass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CO")
                        .HasColumnType("float");

                    b.Property<string>("CriticalLift")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GasTesterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GasTesting")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("H2S")
                        .HasColumnType("float");

                    b.Property<string>("InstrumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Isolation")
                        .HasColumnType("bit");

                    b.Property<string>("JSA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LEL")
                        .HasColumnType("float");

                    b.Property<string>("MOC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NightWork")
                        .HasColumnType("bit");

                    b.Property<double>("O2")
                        .HasColumnType("float");

                    b.Property<string>("Others")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialRequirements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("siteChecker");
                });
#pragma warning restore 612, 618
        }
    }
}
