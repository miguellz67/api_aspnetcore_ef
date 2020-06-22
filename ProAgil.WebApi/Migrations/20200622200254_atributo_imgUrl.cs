using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgil.WebApi.Migrations
{
    public partial class atributo_imgUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgUrl",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgUrl",
                table: "Events");
        }
    }
}
