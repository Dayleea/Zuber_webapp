using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zuber_webapp.Data.Migrations
{
    public partial class addtabledetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStarted",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer_NameId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Trip",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tripid",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateofBirth",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TRN",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    CarTypeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrand = table.Column<string>(nullable: true),
                    CarModel = table.Column<string>(nullable: true),
                    CarVIN = table.Column<string>(nullable: true),
                    CarColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.CarTypeid);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Driverid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameId = table.Column<string>(nullable: true),
                    Trip = table.Column<int>(nullable: false),
                    Tripid = table.Column<int>(nullable: false),
                    CarType = table.Column<int>(nullable: false),
                    CarTypeid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Driverid);
                    table.ForeignKey(
                        name: "FK_Drivers_AspNetUsers_NameId",
                        column: x => x.NameId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Tripid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointA = table.Column<string>(nullable: true),
                    PointB = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    Customer = table.Column<string>(nullable: true),
                    Customerid = table.Column<string>(nullable: true),
                    Driver = table.Column<int>(nullable: false),
                    Driverid = table.Column<int>(nullable: false),
                    DateShedule = table.Column<DateTime>(nullable: false),
                    Cartypeid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Tripid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NameId",
                table: "AspNetUsers",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Customer_NameId",
                table: "AspNetUsers",
                column: "Customer_NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_NameId",
                table: "Drivers",
                column: "NameId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_NameId",
                table: "AspNetUsers",
                column: "NameId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_Customer_NameId",
                table: "AspNetUsers",
                column: "Customer_NameId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_Customer_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Customer_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateStarted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Customer_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Trip",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tripid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TRN",
                table: "AspNetUsers");
        }
    }
}
