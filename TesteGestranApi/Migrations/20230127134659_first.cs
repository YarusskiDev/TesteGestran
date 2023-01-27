using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteGestranApi.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(20)", nullable: false),
                    Telephone = table.Column<string>(type: "varchar(25)", nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Provider = table.Column<int>(type: "int", nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(50)", nullable: false),
                    Street = table.Column<string>(type: "varchar(50)", nullable: false),
                    Complement = table.Column<string>(type: "varchar(50)", nullable: false),
                    City = table.Column<string>(type: "varchar(50)", nullable: false),
                    State = table.Column<string>(type: "varchar(50)", nullable: false),
                    Country = table.Column<string>(type: "varchar(50)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adress_Providers_Id_Provider",
                        column: x => x.Id_Provider,
                        principalTable: "Providers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adress_Id_Provider",
                table: "Adress",
                column: "Id_Provider");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "Providers");
        }
    }
}
