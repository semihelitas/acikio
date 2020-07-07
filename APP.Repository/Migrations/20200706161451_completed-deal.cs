using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APP.UI.Data.Migrations
{
    public partial class completeddeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompletedDeal",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DealId = table.Column<Guid>(nullable: true),
                    DeliciousScore = table.Column<double>(nullable: false),
                    TimingScore = table.Column<double>(nullable: false),
                    CommunicationScore = table.Column<double>(nullable: false),
                    AdviceScore = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedDeal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletedDeal_Deal_DealId",
                        column: x => x.DealId,
                        principalTable: "Deal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompletedDeal_DealId",
                table: "CompletedDeal",
                column: "DealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompletedDeal");
        }
    }
}
