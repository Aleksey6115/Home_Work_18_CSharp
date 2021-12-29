using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeWork_18.Migrations
{
    public partial class AddAgeToClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Clients");
        }
    }
}
