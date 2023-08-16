using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DateAccess.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 17, "Boris", "Petrovich" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 2, 30, "Bohdan", "Slonets" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 3, 21, "Max", "Prymak" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
