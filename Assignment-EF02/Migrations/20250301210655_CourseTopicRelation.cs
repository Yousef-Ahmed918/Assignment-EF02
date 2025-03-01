using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_EF02.Migrations
{
    /// <inheritdoc />
    public partial class CourseTopicRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_TopicId",
                table: "Course",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_topics_TopicId",
                table: "Course",
                column: "TopicId",
                principalTable: "topics",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_topics_TopicId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_TopicId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Course");
        }
    }
}
