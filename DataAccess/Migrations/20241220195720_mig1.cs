using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPurchased = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalStatus = table.Column<bool>(type: "bit", nullable: false),
                    fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipCity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "Description", "IsActive", "Name", "ParentCategoryId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1872), null, true, "Elektronik", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1871) },
                    { 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1897), null, true, "Ev ve Yaşam", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1896) },
                    { 3, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1898), null, true, "Moda", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1897) },
                    { 4, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1899), null, true, "Spor ve Outdoor", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1898) },
                    { 5, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1900), null, true, "Kitap, Müzik, Film", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1899) },
                    { 6, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1901), null, true, "Anne ve Bebek", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1900) },
                    { 7, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1901), null, true, "Sağlık ve Kişisel Bakım", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1901) },
                    { 8, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1902), null, true, "Oyun ve Hobi", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1902) },
                    { 9, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1903), null, true, "Otomobil ve Motosiklet", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1903) },
                    { 10, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1904), null, true, "Ofis ve Kırtasiye", null, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1904) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "Description", "IsActive", "Name", "ParentCategoryId", "UpdatedAt" },
                values: new object[,]
                {
                    { 11, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1905), null, true, "Telefonlar", 1, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1905) },
                    { 12, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1906), null, true, "Bilgisayarlar", 1, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1906) },
                    { 13, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1907), null, true, "Televizyon ve Ses Sistemleri", 1, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1907) },
                    { 14, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1908), null, true, "Aksesuarlar", 1, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1908) },
                    { 15, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1909), null, true, "Fotoğraf ve Kamera", 1, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1908) },
                    { 16, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1910), null, true, "Akıllı Ev Ürünleri", 1, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1909) },
                    { 17, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1911), null, true, "Tabletler", 1, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1910) },
                    { 18, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1912), null, true, "Mobilya", 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1911) },
                    { 19, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1913), null, true, "Dekorasyon", 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1912) },
                    { 20, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1914), null, true, "Mutfak Gereçleri", 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1913) },
                    { 21, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1914), null, true, "Temizlik Ürünleri", 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1914) },
                    { 22, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1915), null, true, "Aydınlatma", 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1915) },
                    { 23, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1916), null, true, "Beyaz Eşya", 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1916) },
                    { 24, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1917), null, true, "Halı ve Tekstil", 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1917) },
                    { 25, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1918), null, true, "Bahçe Ürünleri", 2, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1918) },
                    { 26, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1919), null, true, "Kadın Giyim", 3, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1919) },
                    { 27, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1920), null, true, "Erkek Giyim", 3, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1920) },
                    { 28, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1921), null, true, "Ayakkabı ve Çanta", 3, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1921) },
                    { 29, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1922), null, true, "Aksesuarlar", 3, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1922) },
                    { 30, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1923), null, true, "İç Giyim", 3, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1923) },
                    { 31, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1924), null, true, "Koşu ve Yürüyüş", 4, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1924) },
                    { 32, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1925), null, true, "Fitness", 4, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1925) },
                    { 33, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1926), null, true, "Outdoor", 4, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1925) },
                    { 34, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1927), null, true, "Yüzme", 4, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1927) },
                    { 35, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1929), null, true, "Bicycles", 4, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1928) },
                    { 36, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1930), null, true, "Kitaplar", 5, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1929) },
                    { 37, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1930), null, true, "Müzik CD'leri", 5, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1930) },
                    { 38, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1931), null, true, "Film DVD'leri", 5, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1931) },
                    { 39, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1932), null, true, "Bebek Giyim", 6, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1932) },
                    { 40, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1933), null, true, "Bebek Oyuncakları", 6, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1933) },
                    { 41, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1934), null, true, "Bebek Bakım Ürünleri", 6, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1934) },
                    { 42, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1935), null, true, "Cilt Bakımı", 7, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1935) },
                    { 43, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1936), null, true, "Saç Bakımı", 7, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1936) },
                    { 44, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1937), null, true, "Parfümler", 7, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1937) },
                    { 45, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1938), null, true, "Video Oyunları", 8, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1938) },
                    { 46, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1939), null, true, "Masa Oyunları", 8, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1939) },
                    { 47, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1940), null, true, "Otomobil Yedek Parçaları", 9, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1939) },
                    { 48, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1941), null, true, "Motosiklet Aksesuarları", 9, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1940) },
                    { 49, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1942), null, true, "Ofis Mobilyaları", 10, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1941) },
                    { 50, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1943), null, true, "Kırtasiye Ürünleri", 10, new DateTime(2024, 12, 20, 19, 57, 20, 707, DateTimeKind.Utc).AddTicks(1942) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
