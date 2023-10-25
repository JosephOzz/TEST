using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field1 = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Field2 = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Field3 = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Field4 = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Field5 = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entity");
        }
    }
}
