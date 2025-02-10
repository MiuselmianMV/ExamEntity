using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalWork.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddMissedGoals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MissedGoals",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissedGoals",
                table: "Teams");
        }
    }
}
