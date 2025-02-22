using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ResumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ResumeId);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6405), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6407), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6408), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6409), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6410), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6411), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6412), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6413), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6414), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6415), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6416), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6417), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6418), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6419), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6420), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6421), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6422), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6423), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6424), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6425), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6426), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6427), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6428), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6429), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6430), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6431), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6432), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6433), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6434), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6435), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6436), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6437), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6438), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6439), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6440), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6441), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6442), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6443), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6444), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6445), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6446), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6447), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6448), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6449), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6450), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6451), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6452), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6454), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6455), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6456), new DateTime(2025, 2, 22, 8, 4, 33, 272, DateTimeKind.Utc).AddTicks(6455) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1960), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1961), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1962), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1963), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1965), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1966), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1967), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1968), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1969), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1970), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1971), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1972), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1973), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1974), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1975), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1976), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1978), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1980), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1981), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1982), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1983), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1984), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1986), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1987), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1991), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1993), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1994), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1995), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1997), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1998), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1999), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2000), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2001), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2002), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2003), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2004), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2005), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2006), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2007), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2008), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2009), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2010), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2011), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2012), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2013), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2014), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2015), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2016), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2017), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2018), new DateTime(2025, 1, 15, 14, 10, 14, 782, DateTimeKind.Utc).AddTicks(2018) });
        }
    }
}
