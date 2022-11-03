using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Server_App_Final_Project.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Trumpet",
                columns: table => new
                {
                    HornID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trumpet", x => x.HornID);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 1, "Ford", "Mustang Coupe", 1969 },
                    { 2, "Ford", "Focus SE", 2010 },
                    { 3, "Jeep", "J20", 1973 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Genre", "Name", "Platform", "Year" },
                values: new object[,]
                {
                    { 1, "Fighting", "Tekken 7", "PC, PS4, Xbox", 2017 },
                    { 2, "Action-Adventure", "Detroit Become Human", "PC, PS4, Xbox", 2018 },
                    { 3, "Adventure, Indie", "Hollow Knight", "PC, PS4, Xbox", 2017 }
                });

            migrationBuilder.InsertData(
                table: "Trumpet",
                columns: new[] { "HornID", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 1, "Advantage", "Yamaha", 2012 },
                    { 2, "Xeno", "Yamaha", 2022 },
                    { 3, "Stradivarius", "Bach", 2002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Trumpet");
        }
    }
}
