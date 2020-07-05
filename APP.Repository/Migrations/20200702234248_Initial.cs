using Microsoft.EntityFrameworkCore.Migrations;

namespace APP.UI.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserCategoryId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCategory_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_UserCategoryId",
                table: "Category",
                column: "UserCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategory_UserId",
                table: "UserCategory",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_UserCategory_UserCategoryId",
                table: "Category",
                column: "UserCategoryId",
                principalTable: "UserCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_UserCategory_UserCategoryId",
                table: "Category");

            migrationBuilder.DropTable(
                name: "UserCategory");

            migrationBuilder.DropIndex(
                name: "IX_Category_UserCategoryId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "UserCategoryId",
                table: "Category");
        }
    }
}
