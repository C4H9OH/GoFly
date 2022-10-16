using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoFly_web.Migrations
{
    public partial class Base45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Itineraries_ItineraryId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ItineraryId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "HotelsCount",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "ItinerariesCount",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ItineraryId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "Orders",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "OrederDate",
                table: "Orders",
                newName: "OrderTime");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalCity",
                table: "Wishlists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArrivalTime",
                table: "Wishlists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureCity",
                table: "Wishlists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hotel",
                table: "Wishlists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Wishlists",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "RegCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArrivalCity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArrivalTime",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureCity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hotel",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArrivalCityName",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartureCityName",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TransportName",
                table: "Itineraries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalCityName",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "DepartureCities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "ArrivalCities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "ArrivalCity",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "DepartureCity",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "Hotel",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "RegCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ArrivalCity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DepartureCity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Hotel",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ArrivalCityName",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "DepartureCityName",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "TransportName",
                table: "Itineraries");

            migrationBuilder.DropColumn(
                name: "ArrivalCityName",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "DepartureCities");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "ArrivalCities");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Orders",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "OrderTime",
                table: "Orders",
                newName: "OrederDate");

            migrationBuilder.AddColumn<int>(
                name: "HotelsCount",
                table: "Wishlists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItinerariesCount",
                table: "Wishlists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ItineraryId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ItineraryId",
                table: "Orders",
                column: "ItineraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Itineraries_ItineraryId",
                table: "Orders",
                column: "ItineraryId",
                principalTable: "Itineraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
