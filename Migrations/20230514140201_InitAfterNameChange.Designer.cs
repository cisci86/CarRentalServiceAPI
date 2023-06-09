﻿// <auto-generated />
using System;
using CarRentalServiceAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRentalServiceAPI.Migrations
{
    [DbContext(typeof(CarRentalContext))]
    [Migration("20230514140201_InitAfterNameChange")]
    partial class InitAfterNameChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarRentalServiceAPI.Models.Rental", b =>
                {
                    b.Property<Guid>("BookingNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CustomerNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndMileage")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentalEndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RentalStartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartMileage")
                        .HasColumnType("int");

                    b.Property<string>("VehicleLicensePlateNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookingNumber");

                    b.HasIndex("VehicleLicensePlateNumber");

                    b.ToTable("Rentals");

                    b.HasData(
                        new
                        {
                            BookingNumber = new Guid("779b27c3-1f2b-4f3a-b4cb-9315d29d0918"),
                            Active = true,
                            CustomerNumber = "860919-1666",
                            EndMileage = 0,
                            RentalEndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentalStartTime = new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            StartMileage = 230148,
                            VehicleLicensePlateNumber = "KHU876"
                        },
                        new
                        {
                            BookingNumber = new Guid("f364ed32-9df9-42c1-937b-7bd366bd1f27"),
                            Active = true,
                            CustomerNumber = "440712-5621",
                            EndMileage = 0,
                            RentalEndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentalStartTime = new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            StartMileage = 5689421,
                            VehicleLicensePlateNumber = "PLD982"
                        });
                });

            modelBuilder.Entity("CarRentalServiceAPI.Models.Vehicle", b =>
                {
                    b.Property<string>("LicensePlateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LicensePlateNumber");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            LicensePlateNumber = "ABC123",
                            Available = true,
                            Type = "Småbil"
                        },
                        new
                        {
                            LicensePlateNumber = "MPK459",
                            Available = true,
                            Type = "Småbil"
                        },
                        new
                        {
                            LicensePlateNumber = "NNE867",
                            Available = true,
                            Type = "Småbil"
                        },
                        new
                        {
                            LicensePlateNumber = "JML707",
                            Available = true,
                            Type = "Kombi"
                        },
                        new
                        {
                            LicensePlateNumber = "KHU876",
                            Available = false,
                            Type = "Kombi"
                        },
                        new
                        {
                            LicensePlateNumber = "UYE987",
                            Available = true,
                            Type = "Kombi"
                        },
                        new
                        {
                            LicensePlateNumber = "WWO098",
                            Available = true,
                            Type = "Kombi"
                        },
                        new
                        {
                            LicensePlateNumber = "PLD982",
                            Available = false,
                            Type = "Lastbil"
                        },
                        new
                        {
                            LicensePlateNumber = "MJD291",
                            Available = true,
                            Type = "Lastbil"
                        });
                });

            modelBuilder.Entity("CarRentalServiceAPI.Models.Rental", b =>
                {
                    b.HasOne("CarRentalServiceAPI.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleLicensePlateNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
