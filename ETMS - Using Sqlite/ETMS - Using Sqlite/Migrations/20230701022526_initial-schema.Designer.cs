﻿// <auto-generated />
using System;
using ETMS___Using_Sqlite.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ETMS___Using_Sqlite.Migrations
{
    [DbContext(typeof(TimeSheetDbContext))]
    [Migration("20230701022526_initial-schema")]
    partial class initialschema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("ETMS___Using_Sqlite.Entities.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CardNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserAccountID")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeId");

                    b.HasIndex("UserAccountID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ETMS___Using_Sqlite.Entities.Log", b =>
                {
                    b.Property<Guid>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Timeshift")
                        .HasColumnType("INTEGER");

                    b.HasKey("LogId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("ETMS___Using_Sqlite.Entities.UserAccount", b =>
                {
                    b.Property<int>("UserAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UserAccountID");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("ETMS___Using_Sqlite.Entities.Employee", b =>
                {
                    b.HasOne("ETMS___Using_Sqlite.Entities.UserAccount", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserAccountID");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("ETMS___Using_Sqlite.Entities.Log", b =>
                {
                    b.HasOne("ETMS___Using_Sqlite.Entities.Employee", null)
                        .WithMany("Logs")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("ETMS___Using_Sqlite.Entities.Employee", b =>
                {
                    b.Navigation("Logs");
                });
#pragma warning restore 612, 618
        }
    }
}
