using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Job_Plataform.Data.Migrations
{
    public partial class jobpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(nullable: true),
                    JobLocation = table.Column<string>(nullable: true),
                    Descripton = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ContactPhone = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: true),
                    ContactWebSite = table.Column<string>(nullable: true),
                    CompanyImage = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPosts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPosts");
        }
    }
}
