using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MottFinder.Migrations
{
    /// <inheritdoc />
    public partial class AddCameraGps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CAMERA",
                columns: table => new
                {
                    ID_CAMERA = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DS_POSICAO = table.Column<string>(type: "VARCHAR2(100)", nullable: false),
                    ID_MOTO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CAMERA", x => x.ID_CAMERA);
                });

            migrationBuilder.CreateTable(
                name: "TB_GPS",
                columns: table => new
                {
                    ID_GPS = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NR_LATITUDE = table.Column<string>(type: "VARCHAR2(50)", nullable: false),
                    NR_LONGITUDE = table.Column<string>(type: "VARCHAR2(50)", nullable: false),
                    ID_MOTO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GPS", x => x.ID_GPS);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CAMERA");

            migrationBuilder.DropTable(
                name: "TB_GPS");
        }
    }
}
