using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrabStudent.Migrations
{
    public partial class Crabs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    RollNumber = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.RollNumber);
                });

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubjectName = table.Column<string>(nullable: true),
                    SubjectMark = table.Column<int>(nullable: false),
                    StudentRollNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mark_Student_StudentRollNumber",
                        column: x => x.StudentRollNumber,
                        principalTable: "Student",
                        principalColumn: "RollNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreateAt", "Email", "FirstName", "LastName", "Status", "UpdateAt" },
                values: new object[] { "D00529", new DateTime(2018, 11, 6, 19, 43, 50, 561, DateTimeKind.Local), "hungpvh00529@fpt.edu.vn", "Hoang", "Hung", 1, new DateTime(2018, 11, 6, 19, 43, 50, 561, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreateAt", "Email", "FirstName", "LastName", "Status", "UpdateAt" },
                values: new object[] { "D00530", new DateTime(2018, 11, 6, 19, 43, 50, 561, DateTimeKind.Local), "hungpvh00530@fpt.edu.vn", "Hung", "Hoang", 1, new DateTime(2018, 11, 6, 19, 43, 50, 561, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[] { 9999, "D00529", 9, "Java" });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[] { 9998, "D00530", 0, "Uwp" });

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StudentRollNumber",
                table: "Mark",
                column: "StudentRollNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
