using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APP.UI.Data.Migrations
{
    public partial class adddealfeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deal",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderOfferId = table.Column<Guid>(nullable: true),
                    ChiefId = table.Column<string>(nullable: true),
                    DeliveryTime = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsCanceled = table.Column<bool>(nullable: false),
                    IsChiefConfirm = table.Column<bool>(nullable: false),
                    IsClientConfirm = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deal_AspNetUsers_ChiefId",
                        column: x => x.ChiefId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deal_OrderOffers_OrderOfferId",
                        column: x => x.OrderOfferId,
                        principalTable: "OrderOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deal_ChiefId",
                table: "Deal",
                column: "ChiefId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_OrderOfferId",
                table: "Deal",
                column: "OrderOfferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deal");
        }
    }
}
