using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "Emails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "Emails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "Emails");

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
    }
}
