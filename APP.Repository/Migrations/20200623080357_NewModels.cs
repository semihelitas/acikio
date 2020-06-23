using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APP.UI.Data.Migrations
{
    public partial class NewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderAdvertisement");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderOffers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ChiefAdsId = table.Column<Guid>(nullable: false),
                    ClientId = table.Column<string>(nullable: true),
                    OfferDescription = table.Column<string>(nullable: true),
                    OfferPrice = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsAccepted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderOffers_ChiefAdvertisement_ChiefAdsId",
                        column: x => x.ChiefAdsId,
                        principalTable: "ChiefAdvertisement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderOffers_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffers_ChiefAdsId",
                table: "OrderOffers",
                column: "ChiefAdsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffers_ClientId",
                table: "OrderOffers",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "OrderAdvertisement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdViewed = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAdvertisement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderAdvertisement_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderAdvertisement_UserId",
                table: "OrderAdvertisement",
                column: "UserId");
        }
    }
}
