using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_EF02.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrationAddStud_Course : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Course",
                columns: table => new
                {
                    Stud_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Course", x => new { x.Stud_ID, x.Course_ID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Course");
        }
    }
}
