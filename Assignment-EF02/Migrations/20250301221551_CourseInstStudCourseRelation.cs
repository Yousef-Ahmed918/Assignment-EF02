using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_EF02.Migrations
{
    /// <inheritdoc />
    public partial class CourseInstStudCourseRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "Stud_Course",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Stud_ID",
                table: "Stud_Course",
                newName: "StudentId");

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "InstructorId", "CourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseId",
                table: "Stud_Course",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_CourseId",
                table: "Course_Inst",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Course_CourseId",
                table: "Course_Inst",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructor_InstructorId",
                table: "Course_Inst",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Students_StudentId",
                table: "Stud_Course",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Course_CourseId",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructor_InstructorId",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Students_StudentId",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_CourseId",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Course_Inst");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Stud_Course",
                newName: "Course_ID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Stud_Course",
                newName: "Stud_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "Inst_ID", "Course_ID" });
        }
    }
}
