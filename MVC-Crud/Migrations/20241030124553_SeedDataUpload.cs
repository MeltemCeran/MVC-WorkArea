using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Crud.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "Urunler",
                newName: "Adi");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Urunler",
                newName: "UrunId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Siparisler",
                newName: "SiparisId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Musteriler",
                newName: "MusteriId");

            migrationBuilder.InsertData(
                table: "Musteriler",
                columns: new[] { "MusteriId", "Ad", "Email", "Soyad" },
                values: new object[,]
                {
                    { 1, "Ali", "ali.yilmaz@example.com", "Yılmaz" },
                    { 2, "Ayşe", "ayse.kara@example.com", "Kara" },
                    { 3, "Mehmet", "mehmet.demir@example.com", "Demir" },
                    { 4, "Fatma", "fatma.ozturk@example.com", "Öztürk" },
                    { 5, "Hasan", "hasan.celik@example.com", "Çelik" },
                    { 6, "Zeynep", "zeynep.koc@example.com", "Koç" },
                    { 7, "Emre", "emre.aydin@example.com", "Aydın" },
                    { 8, "Seda", "seda.akman@example.com", "Akman" },
                    { 9, "Burak", "burak.sonmez@example.com", "Sönmez" },
                    { 10, "Elif", "elif.yavuz@example.com", "Yavuz" }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "Adi", "Fiyat" },
                values: new object[,]
                {
                    { 1, "Laptop", 2500m },
                    { 2, "Akıllı Telefon", 1500m },
                    { 3, "Tablet", 1200m },
                    { 4, "Kulaklık", 300m },
                    { 5, "Masaüstü Bilgisayar", 2000m },
                    { 6, "Monitör", 800m },
                    { 7, "Klavyeli", 400m },
                    { 8, "Yazıcı", 600m },
                    { 9, "Modem", 250m },
                    { 10, "Harici Disk", 500m }
                });

            migrationBuilder.InsertData(
                table: "Siparisler",
                columns: new[] { "SiparisId", "MusteriId", "SiparisTarihi", "UrunId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(4916), 1 },
                    { 2, 1, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(4934), 2 },
                    { 3, 2, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(4936), 3 },
                    { 4, 2, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(4938), 4 },
                    { 5, 3, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(4940), 5 },
                    { 6, 3, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(4942), 6 },
                    { 7, 4, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(4943), 7 },
                    { 8, 5, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5001), 8 },
                    { 9, 6, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5004), 9 },
                    { 10, 7, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5006), 10 },
                    { 11, 8, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5008), 1 },
                    { 12, 9, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5011), 2 },
                    { 13, 10, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5013), 3 },
                    { 14, 4, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5015), 5 },
                    { 15, 5, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5017), 6 },
                    { 16, 6, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5020), 7 },
                    { 17, 7, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5022), 8 },
                    { 18, 8, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5023), 9 },
                    { 19, 9, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5025), 10 },
                    { 20, 10, new DateTime(2024, 10, 30, 15, 45, 50, 909, DateTimeKind.Local).AddTicks(5027), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Siparisler",
                keyColumn: "SiparisId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Musteriler",
                keyColumn: "MusteriId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "UrunId",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "Adi",
                table: "Urunler",
                newName: "Adı");

            migrationBuilder.RenameColumn(
                name: "UrunId",
                table: "Urunler",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SiparisId",
                table: "Siparisler",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MusteriId",
                table: "Musteriler",
                newName: "Id");
        }
    }
}
