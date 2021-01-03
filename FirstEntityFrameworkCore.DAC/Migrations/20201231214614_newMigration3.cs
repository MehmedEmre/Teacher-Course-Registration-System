using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstEntityFrameworkCore.DAC.Migrations
{
    public partial class newMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    surname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Branch_TeacherTable",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branchid = table.Column<int>(nullable: false),
                    branchName = table.Column<string>(nullable: true),
                    teacherid = table.Column<int>(nullable: false),
                    teacherName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch_TeacherTable", x => x.id);
                    table.ForeignKey(
                        name: "FK_Branch_TeacherTable_Branch_branchid",
                        column: x => x.branchid,
                        principalTable: "Branch",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Branch_TeacherTable_Teachers_teacherid",
                        column: x => x.teacherid,
                        principalTable: "Teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    code = table.Column<string>(nullable: true),
                    ownerBranch = table.Column<string>(nullable: true),
                    branchid = table.Column<int>(nullable: true),
                    isFull = table.Column<bool>(nullable: false),
                    teacherid = table.Column<int>(nullable: true),
                    ownerTeacherName = table.Column<string>(nullable: true),
                    ownerTeacherSurname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lessons_Teachers_teacherid",
                        column: x => x.teacherid,
                        principalTable: "Teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    text = table.Column<string>(nullable: true),
                    subjectStart = table.Column<DateTime>(nullable: false),
                    subjectFinish = table.Column<DateTime>(nullable: false),
                    lessonid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.id);
                    table.ForeignKey(
                        name: "FK_Subjects_Lessons_lessonid",
                        column: x => x.lessonid,
                        principalTable: "Lessons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_TeacherTable_branchid",
                table: "Branch_TeacherTable",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_TeacherTable_teacherid",
                table: "Branch_TeacherTable",
                column: "teacherid");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_teacherid",
                table: "Lessons",
                column: "teacherid");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_lessonid",
                table: "Subjects",
                column: "lessonid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branch_TeacherTable");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
