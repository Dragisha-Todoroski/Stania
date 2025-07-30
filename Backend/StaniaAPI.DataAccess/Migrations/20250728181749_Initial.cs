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
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Region_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    BathroomCount = table.Column<double>(type: "double precision", nullable: false),
                    SquareFootage = table.Column<int>(type: "integer", nullable: false),
                    NumOfFloors = table.Column<int>(type: "integer", nullable: true),
                    FloorNumber = table.Column<int>(type: "integer", nullable: true),
                    ParkingOption = table.Column<string>(type: "text", nullable: false),
                    ParkingCost = table.Column<string>(type: "text", nullable: true),
                    HasGarage = table.Column<bool>(type: "boolean", nullable: true),
                    HasGarden = table.Column<bool>(type: "boolean", nullable: true),
                    RegionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalUnits_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Region_CountryId",
                table: "Region",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalUnits_RegionId",
                table: "RentalUnits",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentalUnits");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
