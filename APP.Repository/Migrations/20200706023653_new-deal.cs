using Microsoft.EntityFrameworkCore.Migrations;

namespace APP.UI.Data.Migrations
{
    public partial class newdeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCounterOffer",
                table: "OrderOffers");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeal",
                table: "OrderOffers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeal",
                table: "OrderOffers");

            migrationBuilder.AddColumn<bool>(
                name: "IsCounterOffer",
                table: "OrderOffers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
