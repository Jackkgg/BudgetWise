using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetWise.Migrations
{
    /// <inheritdoc />
    public partial class AddTargetsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    TargetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalAccountID = table.Column<int>(type: "int", nullable: false),
                    Necessities = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Luxuries = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Future = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.TargetID);
                    table.ForeignKey(
                        name: "FK_Targets_PersonalAccounts_PersonalAccountID",
                        column: x => x.PersonalAccountID,
                        principalTable: "PersonalAccounts",
                        principalColumn: "PersonalAccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Targets_PersonalAccountID",
                table: "Targets",
                column: "PersonalAccountID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Targets");
        }
    }
}
