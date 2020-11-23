using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstEntityFrameworkCore.DAC.Migrations
{
    public partial class LatestMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ownerTeacherName",
                table: "Lessons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ownerTeacherSurname",
                table: "Lessons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ownerTeacherName",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "ownerTeacherSurname",
                table: "Lessons");
        }
    }
}
