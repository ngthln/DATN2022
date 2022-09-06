﻿// <auto-generated />
using System;
using DATN2022.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DATN2022.Migrations
{
    [DbContext(typeof(DATN2022DbContext))]
    [Migration("20220906082108_DATN2022Migrations")]
    partial class DATN2022Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DATN2022.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DATN2022.Models.Coach", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Color")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LisencePlates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Reserve")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Color")
                        .IsUnique();

                    b.HasIndex("OwnerId");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("DATN2022.Models.CoachOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LisenseNo")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoachOwners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9dee0a21-f185-4e19-bc3c-3a58d7a3aa51"),
                            DateOfBirth = new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "uncle.bob@gmail.com",
                            FirstName = "Uncle",
                            LastName = "Bob",
                            LisenseNo = 0,
                            PhoneNumber = "999-888-7777"
                        },
                        new
                        {
                            Id = new Guid("bdca49cf-cb1a-4967-9fcd-e7c696ab35b1"),
                            DateOfBirth = new DateTime(1920, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "vital.bob@gmail.com",
                            FirstName = "Vital",
                            LastName = "Water",
                            LisenseNo = 0,
                            PhoneNumber = "666-123-2345"
                        });
                });

            modelBuilder.Entity("DATN2022.Models.Colors", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("DATN2022.Models.DropOff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<Guid?>("TripId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("DropOffs");
                });

            modelBuilder.Entity("DATN2022.Models.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("DATN2022.Models.Layout", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Layouts");
                });

            modelBuilder.Entity("DATN2022.Models.Pickup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<Guid?>("TripId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Pickups");
                });

            modelBuilder.Entity("DATN2022.Models.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Column")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Row")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatNo")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("DATN2022.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TripId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DATN2022.Models.TicketDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerAge")
                        .HasColumnType("int");

                    b.Property<Guid>("CustomerGender")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerPhone")
                        .HasColumnType("int");

                    b.Property<string>("IdentityCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("SeatNo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TicketNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerGender")
                        .IsUnique();

                    b.HasIndex("SeatNo")
                        .IsUnique();

                    b.HasIndex("TicketId");

                    b.ToTable("TicketDetails");
                });

            modelBuilder.Entity("DATN2022.Models.Trip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CoachId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TripNo")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("DATN2022.Models.Types", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Layout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("DATN2022.Models.Coach", b =>
                {
                    b.HasOne("DATN2022.Models.Colors", "Colors")
                        .WithOne("Coach")
                        .HasForeignKey("DATN2022.Models.Coach", "Color")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN2022.Models.Types", "Types")
                        .WithOne("Coach")
                        .HasForeignKey("DATN2022.Models.Coach", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN2022.Models.CoachOwner", "CoachOwner")
                        .WithMany("Coaches")
                        .HasForeignKey("OwnerId");

                    b.Navigation("CoachOwner");

                    b.Navigation("Colors");

                    b.Navigation("Types");
                });

            modelBuilder.Entity("DATN2022.Models.DropOff", b =>
                {
                    b.HasOne("DATN2022.Models.Trip", "Trip")
                        .WithMany("DropOffs")
                        .HasForeignKey("TripId");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("DATN2022.Models.Pickup", b =>
                {
                    b.HasOne("DATN2022.Models.Trip", "Trip")
                        .WithMany("Pickups")
                        .HasForeignKey("TripId");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("DATN2022.Models.Ticket", b =>
                {
                    b.HasOne("DATN2022.Models.Trip", "Trip")
                        .WithMany("Tickets")
                        .HasForeignKey("TripId");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("DATN2022.Models.TicketDetail", b =>
                {
                    b.HasOne("DATN2022.Models.Gender", "Gender")
                        .WithOne("TicketDetail")
                        .HasForeignKey("DATN2022.Models.TicketDetail", "CustomerGender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN2022.Models.Seat", "Seat")
                        .WithOne("TicketDetail")
                        .HasForeignKey("DATN2022.Models.TicketDetail", "SeatNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN2022.Models.Ticket", "Ticket")
                        .WithMany("TicketDetails")
                        .HasForeignKey("TicketId");

                    b.Navigation("Gender");

                    b.Navigation("Seat");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("DATN2022.Models.Trip", b =>
                {
                    b.HasOne("DATN2022.Models.Coach", "Coach")
                        .WithMany("Trips")
                        .HasForeignKey("CoachId");

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("DATN2022.Models.Coach", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("DATN2022.Models.CoachOwner", b =>
                {
                    b.Navigation("Coaches");
                });

            modelBuilder.Entity("DATN2022.Models.Colors", b =>
                {
                    b.Navigation("Coach");
                });

            modelBuilder.Entity("DATN2022.Models.Gender", b =>
                {
                    b.Navigation("TicketDetail");
                });

            modelBuilder.Entity("DATN2022.Models.Seat", b =>
                {
                    b.Navigation("TicketDetail");
                });

            modelBuilder.Entity("DATN2022.Models.Ticket", b =>
                {
                    b.Navigation("TicketDetails");
                });

            modelBuilder.Entity("DATN2022.Models.Trip", b =>
                {
                    b.Navigation("DropOffs");

                    b.Navigation("Pickups");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DATN2022.Models.Types", b =>
                {
                    b.Navigation("Coach");
                });
#pragma warning restore 612, 618
        }
    }
}