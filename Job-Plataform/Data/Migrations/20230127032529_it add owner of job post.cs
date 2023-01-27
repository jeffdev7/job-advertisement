using Microsoft.EntityFrameworkCore.Migrations;

namespace Job_Plataform.Data.Migrations
{
    public partial class itaddownerofjobpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerUserName",
                table: "JobPosts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerUserName",
                table: "JobPosts");
        }
    }
}
