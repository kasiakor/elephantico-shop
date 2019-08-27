using Microsoft.EntityFrameworkCore.Migrations;

namespace Elephantico.Migrations
{
    public partial class ElephaitemModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Elephaitems",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Elephaitems");
        }
    }
}
