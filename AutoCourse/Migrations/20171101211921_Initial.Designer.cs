﻿// <auto-generated />
using AutoCourse.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AutoCourse.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20171101211921_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoCourse.Models.BodyType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("VehicleTypeID");

                    b.HasKey("ID");

                    b.HasIndex("VehicleTypeID");

                    b.ToTable("BodyType");
                });

            modelBuilder.Entity("AutoCourse.Models.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ManufacturerID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("AutoCourse.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BodyTypeID");

                    b.Property<int?>("ModelID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("BodyTypeID");

                    b.HasIndex("ModelID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("AutoCourse.Models.CarCharacterisctics", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CarID");

                    b.Property<int?>("TechnicalCharacteristicsID");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.HasIndex("TechnicalCharacteristicsID");

                    b.ToTable("CarCharacteristics");
                });

            modelBuilder.Entity("AutoCourse.Models.Manufacturer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.HasKey("ID");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("AutoCourse.Models.Model", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BrandID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("AutoCourse.Models.TechnicalCharacteristics", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Units");

                    b.HasKey("ID");

                    b.ToTable("TechnicalCharacteristics");
                });

            modelBuilder.Entity("AutoCourse.Models.VehicleType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("AutoCourse.Models.BodyType", b =>
                {
                    b.HasOne("AutoCourse.Models.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeID");
                });

            modelBuilder.Entity("AutoCourse.Models.Brand", b =>
                {
                    b.HasOne("AutoCourse.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerID");
                });

            modelBuilder.Entity("AutoCourse.Models.Car", b =>
                {
                    b.HasOne("AutoCourse.Models.BodyType", "BodyType")
                        .WithMany()
                        .HasForeignKey("BodyTypeID");

                    b.HasOne("AutoCourse.Models.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelID");
                });

            modelBuilder.Entity("AutoCourse.Models.CarCharacterisctics", b =>
                {
                    b.HasOne("AutoCourse.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarID");

                    b.HasOne("AutoCourse.Models.TechnicalCharacteristics", "TechnicalCharacteristics")
                        .WithMany()
                        .HasForeignKey("TechnicalCharacteristicsID");
                });

            modelBuilder.Entity("AutoCourse.Models.Model", b =>
                {
                    b.HasOne("AutoCourse.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID");
                });
#pragma warning restore 612, 618
        }
    }
}
