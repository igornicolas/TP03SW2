using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP03SW2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BLs",
                columns: table => new
                {
                    BLId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(nullable: false),
                    Consignee = table.Column<string>(nullable: true),
                    Navio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLs", x => x.BLId);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    ContainerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BLId = table.Column<int>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    Tamanho = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.ContainerId);
                    table.ForeignKey(
                        name: "FK_Containers_BLs_BLId",
                        column: x => x.BLId,
                        principalTable: "BLs",
                        principalColumn: "BLId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Containers_BLId",
                table: "Containers",
                column: "BLId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "BLs");
        }
    }
}
