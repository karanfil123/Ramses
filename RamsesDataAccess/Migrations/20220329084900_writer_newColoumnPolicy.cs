using Microsoft.EntityFrameworkCore.Migrations;

namespace RamsesDataAccess.Migrations
{
    public partial class writer_newColoumnPolicy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Policy",
                table: "Writers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Policy",
                table: "Writers");
        }
    }
}
