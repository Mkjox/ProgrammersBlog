using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgrammersBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 2, 14, 16, 7, 17, 946, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(343), new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(346), new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(2946), new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(8120), new DateTime(2023, 2, 14, 16, 7, 17, 947, DateTimeKind.Local).AddTicks(8121) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6830), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6828), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6836), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6835), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6840), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6839), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(8286), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(8290), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(8293), new DateTime(2022, 12, 4, 15, 35, 1, 758, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(704), new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(711), new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(2028), new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(5839), new DateTime(2022, 12, 4, 15, 35, 1, 759, DateTimeKind.Local).AddTicks(5840) });
        }
    }
}
