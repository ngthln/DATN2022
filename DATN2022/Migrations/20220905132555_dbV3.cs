using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATN2022.Migrations
{
    public partial class dbV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("49879f62-52f9-4f23-b6e0-cb913730b092"));

            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("b1d8d11f-c694-4f1d-a8e3-35fdd6b82abb"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SeatNo",
                table: "TicketDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatNo = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Row = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Column = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("d4c60bb0-c0dc-48dc-862e-3d28147978f9"), null, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", "Bob", null, null, "999-888-7777" });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("bb5fd488-9050-4e11-85e0-2341a18c904e"), null, new DateTime(1920, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "vital.bob@gmail.com", "Vital", "Water", null, null, "666-123-2345" });

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetail_SeatNo",
                table: "TicketDetail",
                column: "SeatNo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetail_Genders_Id",
                table: "TicketDetail",
                column: "Id",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketDetail_Seat_SeatNo",
                table: "TicketDetail",
                column: "SeatNo",
                principalTable: "Seat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetail_Genders_Id",
                table: "TicketDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketDetail_Seat_SeatNo",
                table: "TicketDetail");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_TicketDetail_SeatNo",
                table: "TicketDetail");

            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("bb5fd488-9050-4e11-85e0-2341a18c904e"));

            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("d4c60bb0-c0dc-48dc-862e-3d28147978f9"));

            migrationBuilder.AlterColumn<string>(
                name: "SeatNo",
                table: "TicketDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("49879f62-52f9-4f23-b6e0-cb913730b092"), null, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", "Bob", null, null, "999-888-7777" });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("b1d8d11f-c694-4f1d-a8e3-35fdd6b82abb"), null, new DateTime(1920, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "vital.bob@gmail.com", "Vital", "Water", null, null, "666-123-2345" });
        }
    }
}
