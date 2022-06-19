using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Urunler",
                type: "image",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageExtension",
                table: "Urunler",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "ImageExtension",
                table: "Urunler");
        }
    }
}
