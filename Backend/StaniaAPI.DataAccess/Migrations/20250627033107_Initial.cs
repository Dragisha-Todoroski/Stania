using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StaniaAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RentalUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    RentalUnitType = table.Column<string>(type: "text", nullable: false),
                    RentalUnitTerm = table.Column<string>(type: "text", nullable: false),
                    BedroomCount = table.Column<int>(type: "integer", nullable: false),
                    BathroomCount = table.Column<int>(type: "integer", nullable: false),
                    SquareFootage = table.Column<int>(type: "integer", nullable: false),
                    NumOfFloors = table.Column<int>(type: "integer", nullable: true),
                    FloorNumber = table.Column<int>(type: "integer", nullable: true),
                    ParkingOption = table.Column<string>(type: "text", nullable: false),
                    ParkingCost = table.Column<string>(type: "text", nullable: true),
                    HasGarage = table.Column<bool>(type: "boolean", nullable: true),
                    HasGarden = table.Column<bool>(type: "boolean", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Currency = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalUnits", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentalUnits");
        }
    }
}
