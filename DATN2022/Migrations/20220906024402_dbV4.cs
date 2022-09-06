using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATN2022.Migrations
{
    public partial class dbV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("bb5fd488-9050-4e11-85e0-2341a18c904e"));

            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("d4c60bb0-c0dc-48dc-862e-3d28147978f9"));

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("8c914483-bbfd-473d-84a9-0e2ade072b2a"), null, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", "Bob", null, null, "999-888-7777" });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("cad25f1b-f28e-41a2-b1e8-708472e4ca34"), null, new DateTime(1920, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "vital.bob@gmail.com", "Vital", "Water", null, null, "666-123-2345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("8c914483-bbfd-473d-84a9-0e2ade072b2a"));

            migrationBuilder.DeleteData(
                table: "CoachOwners",
                keyColumn: "Id",
                keyValue: new Guid("cad25f1b-f28e-41a2-b1e8-708472e4ca34"));

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("d4c60bb0-c0dc-48dc-862e-3d28147978f9"), null, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Uncle", "Bob", null, null, "999-888-7777" });

            migrationBuilder.InsertData(
                table: "CoachOwners",
                columns: new[] { "Id", "Address", "DateOfBirth", "Email", "FirstName", "LastName", "LisenseNo", "Nationality", "PhoneNumber" },
                values: new object[] { new Guid("bb5fd488-9050-4e11-85e0-2341a18c904e"), null, new DateTime(1920, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "vital.bob@gmail.com", "Vital", "Water", null, null, "666-123-2345" });
        }
    }
}
