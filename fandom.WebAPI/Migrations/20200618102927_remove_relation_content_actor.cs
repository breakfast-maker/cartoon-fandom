using Microsoft.EntityFrameworkCore.Migrations;

namespace fandom.WebAPI.Migrations
{
    public partial class remove_relation_content_actor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Actors_ActorId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Characters_CharacterId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_ActorId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Contents");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "Contents",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Characters_CharacterId",
                table: "Contents",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Characters_CharacterId",
                table: "Contents");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ActorId",
                table: "Contents",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Actors_ActorId",
                table: "Contents",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Characters_CharacterId",
                table: "Contents",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
