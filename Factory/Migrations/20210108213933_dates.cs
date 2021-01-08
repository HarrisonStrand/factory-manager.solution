using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class dates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstallDate",
                table: "Machines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HireDate",
                table: "Engineers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstallDate",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Engineers");
        }
    }
}
