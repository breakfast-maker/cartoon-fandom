using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fandom.WebAPI.Migrations
{
    public partial class _070820_MediaFile_Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Episodes");

            migrationBuilder.AddColumn<byte[]>(
                name: "Thumbnail",
                table: "MediaFile",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "MediaFile");

            migrationBuilder.AddColumn<byte[]>(
                name: "Thumbnail",
                table: "Episodes",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
