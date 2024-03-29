﻿// <auto-generated />
using System;
using CarRental.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRental.Migrations
{
    [DbContext(typeof(CarRentalContext))]
    [Migration("20231022160901_AddCarFeature")]
    partial class AddCarFeature
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarRental.Entities.AppUserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("CarRental.Entities.BookingNoteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RealReturnAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RentAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("BookingNotes");
                });

            modelBuilder.Entity("CarRental.Entities.CarEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("BlueTooth")
                        .HasColumnType("bit");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Camera360")
                        .HasColumnType("bit");

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.Property<bool>("CollisionSensor")
                        .HasColumnType("bit");

                    b.Property<bool>("DashCam")
                        .HasColumnType("bit");

                    b.Property<bool>("GPS")
                        .HasColumnType("bit");

                    b.Property<bool>("Map")
                        .HasColumnType("bit");

                    b.Property<bool>("MarginalCamera")
                        .HasColumnType("bit");

                    b.Property<string>("NameCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PickupTruckTrunkCover")
                        .HasColumnType("bit");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<bool>("ReversingCamera")
                        .HasColumnType("bit");

                    b.Property<bool>("SpareTire")
                        .HasColumnType("bit");

                    b.Property<bool>("SpeedWarningKit")
                        .HasColumnType("bit");

                    b.Property<bool>("Sunroof")
                        .HasColumnType("bit");

                    b.Property<bool>("TireSensor")
                        .HasColumnType("bit");

                    b.Property<bool>("USB")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarRental.Entities.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CarRental.Entities.BookingNoteEntity", b =>
                {
                    b.HasOne("CarRental.Entities.CarEntity", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.HasOne("CarRental.Entities.CustomerEntity", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
