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
    [Migration("20230523222124_UpdatedPermitToWork")]
    partial class UpdatedPermitToWork
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

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description_Of_Work")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration_Of_Work")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("EquipmentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JSA_NO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationOfWork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permit_Applicant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<string>("Tools_Equipmet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermitID");

                    b.ToTable("permitToWorkForm");
                });
#pragma warning restore 612, 618
        }
    }
}
