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
    [Migration("20210710092434_Medicine class added")]
    partial class Medicineclassadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MedicinePrescription", b =>
                {
                    b.Property<int>("MedicinesMId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionsPId")
                        .HasColumnType("int");

                    b.HasKey("MedicinesMId", "PrescriptionsPId");

                    b.HasIndex("PrescriptionsPId");

                    b.ToTable("MedicinePrescription");
                });

            modelBuilder.Entity("Online_Prescription.Models.Doctor", b =>
                {
                    b.Property<int>("DId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DId");

                    b.ToTable("Doctors");
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

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorDId")
                        .HasColumnType("int");

                    b.Property<int>("PatientAge")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PId");

                    b.HasIndex("DoctorDId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("MedicinePrescription", b =>
                {
                    b.HasOne("Online_Prescription.Models.Medicine", null)
                        .WithMany()
                        .HasForeignKey("MedicinesMId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Prescription.Models.Prescription", null)
                        .WithMany()
                        .HasForeignKey("PrescriptionsPId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Online_Prescription.Models.Prescription", b =>
                {
                    b.HasOne("Online_Prescription.Models.Doctor", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorDId");
                });

            modelBuilder.Entity("Online_Prescription.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
