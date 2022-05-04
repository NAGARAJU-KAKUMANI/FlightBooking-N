﻿// <auto-generated />
using System;
using Airline.Booking.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Airline.Booking.Migrations
{
    [DbContext(typeof(ApplicationBookDbcontext))]
    [Migration("20220502134144_MysecondBookingMigration")]
    partial class MysecondBookingMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airline.Booking.Models.Bookings", b =>
                {
                    b.Property<string>("TicketID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BoardingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfJourney")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Statusstr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Updatedby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("passportNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TicketID");

                    b.ToTable("tblBookings");

                    b.HasData(
                        new
                        {
                            TicketID = "TICK585755",
                            Age = 25,
                            BoardingTime = new DateTime(2022, 5, 12, 19, 11, 43, 982, DateTimeKind.Local).AddTicks(1173),
                            BookingID = "BCK125458",
                            CreatedBy = "NAGARAJU",
                            CreatedDate = new DateTime(2022, 5, 2, 19, 11, 43, 982, DateTimeKind.Local).AddTicks(2242),
                            DateOfJourney = new DateTime(2022, 5, 12, 19, 11, 43, 981, DateTimeKind.Local).AddTicks(863),
                            EmailID = "kakumani15@gmail.com",
                            FlightNumber = "V12345",
                            FromPlace = "Hyderabd",
                            SeatNumber = 2,
                            Status = 1,
                            Statusstr = "TicketBooked",
                            ToPlace = "BASR",
                            UpdatedDate = new DateTime(2022, 5, 2, 19, 11, 43, 982, DateTimeKind.Local).AddTicks(2519),
                            Updatedby = "NAGARAJU",
                            UserName = "NAGARAJU",
                            passportNumber = "V655585"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
