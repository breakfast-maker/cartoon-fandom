using Microsoft.EntityFrameworkCore.Migrations;

namespace fandom.WebAPI.Migrations
{
    public partial class _130920_EpisodeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Episodes");

            migrationBuilder.AlterColumn<int>(
                name: "Viewcount",
                table: "Episodes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Viewcount",
                table: "Episodes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<long>(
                name: "Duration",
                table: "Episodes",
                type: "bigint",
                nullable: true);
        }
    }
}
