using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicles.Database.Migrations
{
    /// <inheritdoc />
    public partial class Tulaj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OwnerId",
                table: "Vehicle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthday = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    TAJ = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_OwnerId",
                table: "Vehicle",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_TAJ",
                table: "Owner",
                column: "TAJ",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Owner_OwnerId",
                table: "Vehicle",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Owner_OwnerId",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_OwnerId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Vehicle");
        }
    }
}
