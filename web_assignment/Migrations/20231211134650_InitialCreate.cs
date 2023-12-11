using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_assignment.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionModels",
                columns: table => new
                {
                    QuestionModelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", nullable: true),
                    content = table.Column<string>(type: "TEXT", nullable: true),
                    correctOption = table.Column<string>(type: "TEXT", nullable: true),
                    optionOne = table.Column<string>(type: "TEXT", nullable: true),
                    optionTwo = table.Column<string>(type: "TEXT", nullable: true),
                    optionThree = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionModels", x => x.QuestionModelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionModels");
        }
    }
}
