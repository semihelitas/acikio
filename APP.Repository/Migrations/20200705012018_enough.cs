using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APP.UI.Data.Migrations
{
    public partial class enough : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffers_ChiefAdvertisement_ChiefAdsId",
                table: "OrderOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffers_AspNetUsers_ClientId",
                table: "OrderOffers");

            migrationBuilder.DropIndex(
                name: "IX_OrderOffers_ChiefAdsId",
                table: "OrderOffers");

            migrationBuilder.DropIndex(
                name: "IX_OrderOffers_ClientId",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "ChiefAdsId",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "OfferDescription",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "OfferPrice",
                table: "OrderOffers");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "OrderOffers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ChiefAdvertisementId",
                table: "OrderOffers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChiefId",
                table: "OrderOffers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryTime",
                table: "OrderOffers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "OrderOffers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsChiefAccepted",
                table: "OrderOffers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsClientAccepted",
                table: "OrderOffers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCounterOffer",
                table: "OrderOffers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "OrderOffers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "OrderOffers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffers_ChiefAdvertisementId",
                table: "OrderOffers",
                column: "ChiefAdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffers_ChiefId",
                table: "OrderOffers",
                column: "ChiefId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffers_ChiefAdvertisement_ChiefAdvertisementId",
                table: "OrderOffers",
                column: "ChiefAdvertisementId",
                principalTable: "ChiefAdvertisement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffers_AspNetUsers_ChiefId",
                table: "OrderOffers",
                column: "ChiefId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffers_ChiefAdvertisement_ChiefAdvertisementId",
                table: "OrderOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderOffers_AspNetUsers_ChiefId",
                table: "OrderOffers");

            migrationBuilder.DropIndex(
                name: "IX_OrderOffers_ChiefAdvertisementId",
                table: "OrderOffers");

            migrationBuilder.DropIndex(
                name: "IX_OrderOffers_ChiefId",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "ChiefAdvertisementId",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "ChiefId",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "DeliveryTime",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "IsChiefAccepted",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "IsClientAccepted",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "IsCounterOffer",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderOffers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "OrderOffers");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "OrderOffers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ChiefAdsId",
                table: "OrderOffers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "OrderOffers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OfferDescription",
                table: "OrderOffers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "OfferPrice",
                table: "OrderOffers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffers_ChiefAdsId",
                table: "OrderOffers",
                column: "ChiefAdsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderOffers_ClientId",
                table: "OrderOffers",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffers_ChiefAdvertisement_ChiefAdsId",
                table: "OrderOffers",
                column: "ChiefAdsId",
                principalTable: "ChiefAdvertisement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderOffers_AspNetUsers_ClientId",
                table: "OrderOffers",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
