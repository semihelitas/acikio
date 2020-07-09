using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APP.UI.Data.Migrations
{
    public partial class notifyadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffers_ChiefAdvertisement_ChiefAdvertisementId",
                table: "OrderOffers");

            migrationBuilder.DropTable(
                name: "ChiefAdvertisement");

            migrationBuilder.DropIndex(
                name: "IX_OrderOffers_ChiefAdvertisementId",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "ChiefAdvertisementId",
                table: "OrderOffers");

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NotificationString = table.Column<string>(nullable: true),
                    SenderId = table.Column<string>(nullable: true),
                    SenderName = table.Column<string>(nullable: true),
                    ReceiverId = table.Column<string>(nullable: true),
                    IsItRead = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.AddColumn<Guid>(
                name: "ChiefAdvertisementId",
                table: "OrderOffers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChiefAdvertisement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdViewed = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiefAdvertisement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiefAdvertisement_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffers_ChiefAdvertisementId",
                table: "OrderOffers",
                column: "ChiefAdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiefAdvertisement_UserId",
                table: "ChiefAdvertisement",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffers_ChiefAdvertisement_ChiefAdvertisementId",
                table: "OrderOffers",
                column: "ChiefAdvertisementId",
                principalTable: "ChiefAdvertisement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
