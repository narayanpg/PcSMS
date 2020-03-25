using Microsoft.EntityFrameworkCore.Migrations;

namespace PcSMS.Data.Migrations
{
    public partial class vesseladdedagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vessel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IN = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vessel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vessel_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vessel_UserId",
                table: "Vessel",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vessel");
        }
    }
}
