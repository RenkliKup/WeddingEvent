using Microsoft.EntityFrameworkCore.Migrations;

namespace DugunDaveti.Migrations
{
    public partial class dene2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "message",
                table: "weddingInvents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "message",
                table: "weddingInvents");
        }
    }
}
