using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgrammersBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6fdad29c-b22b-4d91-ad44-994a1b255efa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "382641ca-f18d-4997-ae43-3b424cd3f7db");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e5eada-3722-4741-ab2b-256699dece5e", "AQAAAAIAAYagAAAAECJbk12SvaLdtpSn4VYPVOHG2Day2DdySbMekqp8bhREy33McPd7N7aClf3SISazqQ==", "af727ee4-0376-4849-817c-5a5d13a8a985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b8b24bb-f78f-4ae2-a9f8-1e0630d78c15", "AQAAAAIAAYagAAAAEPvi2sQ6qPbZYIEdHAs96SQxHXtslfMHF6SAsTCDmoWjbJXuweLdEaz9M6HG4SE8Aw==", "026816d2-9e73-45aa-8308-2e36e48660c8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 17, 17, 0, 57, 587, DateTimeKind.Local).AddTicks(7017), new DateTime(2023, 7, 17, 17, 0, 57, 587, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 17, 17, 0, 57, 587, DateTimeKind.Local).AddTicks(7020), new DateTime(2023, 7, 17, 17, 0, 57, 587, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 17, 17, 0, 57, 587, DateTimeKind.Local).AddTicks(7023), new DateTime(2023, 7, 17, 17, 0, 57, 587, DateTimeKind.Local).AddTicks(7023) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c6d3724c-b492-4917-af4c-bed681eac57d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "dcfb5255-a09b-46d8-97b1-5832722d43ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "286c189e-0b38-4d19-8cb9-1aef5efce31b", "AQAAAAIAAYagAAAAEIn8zsw7g8939wsE4ZXFStsQSG+Vs4IemnFGcdwBIlfyF0aTWoRFyS/u7xmYF7bebQ==", "953c29d2-63e4-4c2b-b30f-c9b29d37fd90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09eb943b-d8ad-4f71-87b4-fe7b61cc4fb9", "AQAAAAIAAYagAAAAEAEEVMxPdPyZcRZAfAUfdFXNRpOjr5iUpUPx+ZFSxvwRAvcwBPG2nfYDD2OR/MnXhg==", "2db8942d-ce64-434f-9417-41c3a7d550d5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 3, 6, 4, 367, DateTimeKind.Local).AddTicks(6725), new DateTime(2023, 5, 22, 3, 6, 4, 367, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 3, 6, 4, 367, DateTimeKind.Local).AddTicks(6731), new DateTime(2023, 5, 22, 3, 6, 4, 367, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 3, 6, 4, 367, DateTimeKind.Local).AddTicks(6735), new DateTime(2023, 5, 22, 3, 6, 4, 367, DateTimeKind.Local).AddTicks(6735) });
        }
    }
}
