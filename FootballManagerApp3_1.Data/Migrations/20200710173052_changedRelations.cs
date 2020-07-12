using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballManagerApp3_1.Data.Migrations
{
    public partial class changedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Footballers_Clubs_ClubId",
                table: "Footballers");

            migrationBuilder.DropForeignKey(
                name: "FK_PitchPositions_Footballers_FootballerId",
                table: "PitchPositions");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Clubs");

            migrationBuilder.AlterColumn<int>(
                name: "FootballerId",
                table: "PitchPositions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClubId",
                table: "Footballers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Clubs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_ClubId",
                table: "Stadiums",
                column: "ClubId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_ClubId",
                table: "Coaches",
                column: "ClubId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Clubs_ClubId",
                table: "Coaches",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Footballers_Clubs_ClubId",
                table: "Footballers",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PitchPositions_Footballers_FootballerId",
                table: "PitchPositions",
                column: "FootballerId",
                principalTable: "Footballers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_Clubs_ClubId",
                table: "Stadiums",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Clubs_ClubId",
                table: "Coaches");

            migrationBuilder.DropForeignKey(
                name: "FK_Footballers_Clubs_ClubId",
                table: "Footballers");

            migrationBuilder.DropForeignKey(
                name: "FK_PitchPositions_Footballers_FootballerId",
                table: "PitchPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_Clubs_ClubId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Stadiums_ClubId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_ClubId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Clubs");

            migrationBuilder.AlterColumn<int>(
                name: "FootballerId",
                table: "PitchPositions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClubId",
                table: "Footballers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "Clubs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Footballers_Clubs_ClubId",
                table: "Footballers",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PitchPositions_Footballers_FootballerId",
                table: "PitchPositions",
                column: "FootballerId",
                principalTable: "Footballers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
