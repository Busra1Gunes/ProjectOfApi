using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttachmentPaths = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8990), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8991), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8992), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8997), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8998), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8999), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9000), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9001), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9002), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9003), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9004), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9005), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9007), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9008), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9009), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9010), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9011), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9012), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9013), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9014), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9015), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9016), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9017), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9018), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9019), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9021), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9023), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9024), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9025), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9026), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9027), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9028), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9029), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9030), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9031), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9032), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9033), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9034), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9035), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9036), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9037), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9038), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9039), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9040), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9041), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9042), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9043), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9044), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9045), new DateTime(2025, 1, 15, 12, 23, 20, 351, DateTimeKind.Utc).AddTicks(9045) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(839), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(841), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(842), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(843), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(844), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(845), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(847), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(848), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(849), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(852), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(853), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(854), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(856), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(857), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(858), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(859), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(860), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(861), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(862), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(863), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(864), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(865), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(866), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(867), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(868), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(869), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(870), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(872), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(873), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(874), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(875), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(915), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(916), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(917), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(918), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(920), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(921), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(922), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(923), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(924), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(925), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(926), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(927), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(928), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(930), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(931), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(932), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(933), new DateTime(2025, 1, 15, 11, 50, 56, 526, DateTimeKind.Utc).AddTicks(932) });
        }
    }
}
