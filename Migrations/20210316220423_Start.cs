using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUpGenius.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "signUps",
                columns: table => new
                {
                    SignUpId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameOfGroup = table.Column<string>(type: "TEXT", nullable: true),
                    SizeOfGroup = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    date = table.Column<string>(type: "TEXT", nullable: true),
                    time = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signUps", x => x.SignUpId);
                });

            migrationBuilder.CreateTable(
                name: "signUpTimes",
                columns: table => new
                {
                    SingUpTimeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Day = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signUpTimes", x => x.SingUpTimeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "signUps");

            migrationBuilder.DropTable(
                name: "signUpTimes");
        }
    }
}
