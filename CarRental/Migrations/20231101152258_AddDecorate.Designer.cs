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
    [Migration("20231101152258_AddDecorate")]
    partial class AddDecorate
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
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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

                    b.Property<float>("TotalFee")
                        .HasColumnType("real");

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
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("Camera360")
                        .HasColumnType("bit");

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.Property<bool>("CollisionSensor")
                        .HasColumnType("bit");

                    b.Property<bool>("DashCam")
                        .HasColumnType("bit");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<bool>("GPS")
                        .HasColumnType("bit");

                    b.Property<bool>("Map")
                        .HasColumnType("bit");

                    b.Property<bool>("MarginalCamera")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

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
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

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