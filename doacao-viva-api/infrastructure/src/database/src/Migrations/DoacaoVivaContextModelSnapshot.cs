﻿// <auto-generated />
using System;
using DoacaoViva.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DoacaoViva.Infrastructure.Database.Migrations
{
    [DbContext(typeof(DoacaoVivaContext))]
    partial class DoacaoVivaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdCity")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdCountry")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdProvince")
                        .HasColumnType("uuid");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdCity");

                    b.HasIndex("IdCountry");

                    b.HasIndex("IdProvince");

                    b.ToTable("Addresss");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Campaign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IdRequest")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Organizer")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("IdRequest");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Donations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DonationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("IdDonator")
                        .HasColumnType("uuid");

                    b.Property<int>("QtdMl")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdDonator");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Donator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<Guid>("IdBloodType")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdPerson")
                        .HasColumnType("uuid");

                    b.Property<string>("RhFactor")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdBloodType");

                    b.HasIndex("IdPerson");

                    b.ToTable("Donators");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.DonatorHospital", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DonatorId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdHospital")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DonatorId");

                    b.HasIndex("IdHospital");

                    b.ToTable("DonatorHospitals");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.HospitalRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdHospital")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdRequest")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IdHospital");

                    b.HasIndex("IdRequest");

                    b.ToTable("HospitalRequest");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdAddress")
                        .HasColumnType("uuid");

                    b.Property<string>("MainContact")
                        .HasColumnType("text");

                    b.Property<string>("MainEmail")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecondaryContact")
                        .HasColumnType("text");

                    b.Property<string>("SecondaryEmail")
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdAddress");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdPersonRequest")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonRequest");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.RequestBloodType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double?>("Gratification")
                        .HasColumnType("double precision");

                    b.Property<Guid>("IdBloodType")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdHospitalRequest")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IdBloodType");

                    b.HasIndex("IdHospitalRequest");

                    b.ToTable("RequestBloodTypes");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Suport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Abbreviation")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Suports");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("EmailOrPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("IdPerson")
                        .HasColumnType("uuid");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdPerson");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DoacaoViva.Infrastructure.Notification.Entitys.Notifications", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FromEmailOrPhone")
                        .HasColumnType("text");

                    b.Property<string>("FromName")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("NotificationStatus")
                        .HasColumnType("text");

                    b.Property<int?>("NotificationType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Address", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Suport", "City")
                        .WithMany()
                        .HasForeignKey("IdCity");

                    b.HasOne("DoacaoViva.Domain.Entitys.Suport", "Country")
                        .WithMany()
                        .HasForeignKey("IdCountry");

                    b.HasOne("DoacaoViva.Domain.Entitys.Suport", "Province")
                        .WithMany()
                        .HasForeignKey("IdProvince");

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Campaign", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Request", "Request")
                        .WithMany()
                        .HasForeignKey("IdRequest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Donations", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Donator", "Donator")
                        .WithMany()
                        .HasForeignKey("IdDonator");

                    b.Navigation("Donator");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Donator", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Suport", "BloodType")
                        .WithMany()
                        .HasForeignKey("IdBloodType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoacaoViva.Domain.Entitys.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BloodType");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.DonatorHospital", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Donator", "Donator")
                        .WithMany("DonatorHospital")
                        .HasForeignKey("DonatorId");

                    b.HasOne("DoacaoViva.Domain.Entitys.Suport", "Hospital")
                        .WithMany()
                        .HasForeignKey("IdHospital")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donator");

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.HospitalRequest", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Suport", "Hospital")
                        .WithMany()
                        .HasForeignKey("IdHospital")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoacaoViva.Domain.Entitys.Request", "Request")
                        .WithMany("Hospitals")
                        .HasForeignKey("IdRequest");

                    b.Navigation("Hospital");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Person", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Address", "Address")
                        .WithMany()
                        .HasForeignKey("IdAddress");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Request", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPersonRequest");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.RequestBloodType", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Suport", "BloodType")
                        .WithMany()
                        .HasForeignKey("IdBloodType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoacaoViva.Domain.Entitys.HospitalRequest", "HospitalRequest")
                        .WithMany("RequestBloodTypes")
                        .HasForeignKey("IdHospitalRequest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BloodType");

                    b.Navigation("HospitalRequest");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Suport", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Suport", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Users", b =>
                {
                    b.HasOne("DoacaoViva.Domain.Entitys.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Donator", b =>
                {
                    b.Navigation("DonatorHospital");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.HospitalRequest", b =>
                {
                    b.Navigation("RequestBloodTypes");
                });

            modelBuilder.Entity("DoacaoViva.Domain.Entitys.Request", b =>
                {
                    b.Navigation("Hospitals");
                });
#pragma warning restore 612, 618
        }
    }
}
