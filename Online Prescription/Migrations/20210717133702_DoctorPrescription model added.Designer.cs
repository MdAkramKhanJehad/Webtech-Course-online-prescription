﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Prescription.Models;

namespace Online_Prescription.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210717133702_DoctorPrescription model added")]
    partial class DoctorPrescriptionmodeladded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Online_Prescription.Models.Doctor", b =>
                {
                    b.Property<int>("DId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Online_Prescription.Models.DoctorPrescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DoctorPrescriptions");
                });

            modelBuilder.Entity("Online_Prescription.Models.Medicine", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Indication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Instruction")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("Online_Prescription.Models.Prescription", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientAge")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PId");

                    b.ToTable("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
