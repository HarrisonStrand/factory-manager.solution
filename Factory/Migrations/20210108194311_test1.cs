using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EngineerName",
                table: "EngineerMachine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MachineName",
                table: "EngineerMachine",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineerName",
                table: "EngineerMachine");

            migrationBuilder.DropColumn(
                name: "MachineName",
                table: "EngineerMachine");
        }
    }
}
