using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteGestranApi.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "varchar(40)", nullable: false),
                    Rua = table.Column<string>(type: "varchar(40", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(40", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(40", nullable: false),
                    Estado = table.Column<string>(type: "varchar(40)", nullable: false),
                    Pais = table.Column<string>(type: "varchar(40", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAdress = table.Column<int>(name: "Id_Adress", type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(20)", nullable: false),
                    Telephone = table.Column<string>(type: "varchar(25)", nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Providers_Adress_Id_Adress",
                        column: x => x.IdAdress,
                        principalTable: "Adress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Providers_Id_Adress",
                table: "Providers",
                column: "Id_Adress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Adress");
        }
    }
}
