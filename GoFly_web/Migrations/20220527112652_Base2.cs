using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoFly_web.Migrations
{
    public partial class Base2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArrivalCities_ArrivalCountris_ArrivalCountryId",
                table: "ArrivalCities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArrivalCountris",
                table: "ArrivalCountris");

            migrationBuilder.RenameTable(
                name: "ArrivalCountris",
                newName: "ArrivalCountries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArrivalCountries",
                table: "ArrivalCountries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArrivalCities_ArrivalCountries_ArrivalCountryId",
                table: "ArrivalCities",
                column: "ArrivalCountryId",
                principalTable: "ArrivalCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArrivalCities_ArrivalCountries_ArrivalCountryId",
                table: "ArrivalCities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArrivalCountries",
                table: "ArrivalCountries");

            migrationBuilder.RenameTable(
                name: "ArrivalCountries",
                newName: "ArrivalCountris");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArrivalCountris",
                table: "ArrivalCountris",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArrivalCities_ArrivalCountris_ArrivalCountryId",
                table: "ArrivalCities",
                column: "ArrivalCountryId",
                principalTable: "ArrivalCountris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
