using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MottFinder.Migrations
{
    /// <inheritdoc />
    public partial class intitdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_MOTO",
                columns: table => new
                {
                    ID_MOTO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_MODELO = table.Column<string>(type: "VARCHAR2(100)", nullable: false),
                    DS_LOCALIZACAO = table.Column<string>(type: "VARCHAR2(100)", nullable: false),
                    ST_MOTO = table.Column<string>(type: "VARCHAR2(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_MOTO", x => x.ID_MOTO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_MOTO");
        }
    }
}
