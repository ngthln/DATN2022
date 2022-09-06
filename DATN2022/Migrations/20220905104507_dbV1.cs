using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATN2022.Migrations
{
    public partial class dbV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoachOwners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LisenseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentAddresses",
                columns: table => new
                {
                    StudentAddressId = table.Column<int>(type: "int", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddresses", x => x.StudentAddressId);
                    table.ForeignKey(
                        name: "FK_StudentAddresses_Students_StudentAddressId",
                        column: x => x.StudentAddressId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LisencePlates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reserve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_CoachOwners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "CoachOwners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coaches_Types_Id",
                        column: x => x.Id,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TripNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    CoachId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DropOffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropOffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DropOffs_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pickups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pickups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pickups_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TripId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketDetail_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("50243e4a-47b6-4efa-b998-ed24828b208b"), null, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", "Bob", null, null, "999-888-7777" });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("1196700c-a49b-4d2d-8933-ef8b7e056c34"), null, new DateTime(1920, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "vital.bob@gmail.com", "Vital", "Water", null, null, "666-123-2345" });

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_OwnerId",
                table: "Coaches",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_DropOffs_TripId",
                table: "DropOffs",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Pickups_TripId",
                table: "Pickups",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TripId",
                table: "Ticket",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetail_TicketId",
                table: "TicketDetail",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_CoachId",
                table: "Trips",
                column: "CoachId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "DropOffs");

            migrationBuilder.DropTable(
                name: "Pickups");

            migrationBuilder.DropTable(
                name: "StudentAddresses");

            migrationBuilder.DropTable(
                name: "TicketDetail");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "CoachOwners");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
