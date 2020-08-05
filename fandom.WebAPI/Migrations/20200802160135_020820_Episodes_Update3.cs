using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fandom.WebAPI.Migrations
{
    public partial class _020820_Episodes_Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAssignedToSeason",
                table: "Episodes");

            migrationBuilder.AlterColumn<int>(
                name: "Viewcount",
                table: "Episodes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SeasonEpisodeNumber",
                table: "Episodes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OverallNumberOfEpisode",
                table: "Episodes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Duration",
                table: "Episodes",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AirDate",
                table: "Episodes",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<byte[]>(
                name: "Thumbnail",
                table: "Episodes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Episodes");

            migrationBuilder.AlterColumn<int>(
                name: "Viewcount",
                table: "Episodes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SeasonEpisodeNumber",
                table: "Episodes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OverallNumberOfEpisode",
                table: "Episodes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Duration",
                table: "Episodes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AirDate",
                table: "Episodes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAssignedToSeason",
                table: "Episodes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
