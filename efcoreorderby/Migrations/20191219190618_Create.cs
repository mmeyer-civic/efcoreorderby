using Microsoft.EntityFrameworkCore.Migrations;

namespace efcoreorderby.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SimpleObjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleObjects", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow1', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow2', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow3', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow4', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow5', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow6', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow7', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow8', 'Cat'");
            migrationBuilder.Sql("INSERT INTO SimpleObjects (Name, Color, Family) VALUES 'A', 'Yellow9', 'Cat'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SimpleObjects");
        }
    }
}
