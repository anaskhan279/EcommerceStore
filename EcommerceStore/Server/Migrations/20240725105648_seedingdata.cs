using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceStore.Server.Migrations
{
    public partial class seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "book", "glasses", "glasses" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "book", "bikes", "bikes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 4, "book", "books", "books" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, 2, new DateTime(2024, 7, 25, 16, 26, 47, 958, DateTimeKind.Local).AddTicks(405), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "this is some amazing product", "urls", false, false, 10.99m, 9.99m, "first product" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 2, 3, new DateTime(2024, 7, 25, 16, 26, 47, 958, DateTimeKind.Local).AddTicks(416), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "this is some amazing product", "urls", false, false, 10.99m, 9.99m, "second product" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 3, 4, new DateTime(2024, 7, 25, 16, 26, 47, 958, DateTimeKind.Local).AddTicks(417), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "this is some amazing product", "urls", false, false, 10.99m, 9.99m, "third product" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
