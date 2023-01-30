using Microsoft.EntityFrameworkCore.Migrations;

namespace Job_Plataform.Data.Migrations
{
    public partial class correctfnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripton",
                table: "JobPosts");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "JobPosts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "JobPosts");

            migrationBuilder.AddColumn<string>(
                name: "Descripton",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
