using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATN2022.Migrations
{
    public partial class dbV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("1196700c-a49b-4d2d-8933-ef8b7e056c34"));

            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("50243e4a-47b6-4efa-b998-ed24828b208b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Color",
                table: "Coaches",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("49879f62-52f9-4f23-b6e0-cb913730b092"), null, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", "Bob", null, null, "999-888-7777" });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("b1d8d11f-c694-4f1d-a8e3-35fdd6b82abb"), null, new DateTime(1920, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "vital.bob@gmail.com", "Vital", "Water", null, null, "666-123-2345" });

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_Color",
                table: "Coaches",
                column: "Color",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Colors_Color",
                table: "Coaches",
                column: "Color",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Colors_Color",
                table: "Coaches");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_Color",
                table: "Coaches");

            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("49879f62-52f9-4f23-b6e0-cb913730b092"));

            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("b1d8d11f-c694-4f1d-a8e3-35fdd6b82abb"));

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Coaches",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("50243e4a-47b6-4efa-b998-ed24828b208b"), null, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", "Bob", null, null, "999-888-7777" });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("1196700c-a49b-4d2d-8933-ef8b7e056c34"), null, new DateTime(1920, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "vital.bob@gmail.com", "Vital", "Water", null, null, "666-123-2345" });
        }
    }
}
