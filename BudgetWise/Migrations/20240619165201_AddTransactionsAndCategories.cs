using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetWise.Migrations
{
    /// <inheritdoc />
    public partial class AddTransactionsAndCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeStream_PersonalAccounts_PersonalAccountID",
                table: "IncomeStream");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeStream",
                table: "IncomeStream");

            migrationBuilder.RenameTable(
                name: "IncomeStream",
                newName: "IncomeStreams");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeStream_PersonalAccountID",
                table: "IncomeStreams",
                newName: "IX_IncomeStreams_PersonalAccountID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeStreams",
                table: "IncomeStreams",
                column: "IncomeStreamID");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    PersonalAccountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_PersonalAccounts_PersonalAccountID",
                        column: x => x.PersonalAccountID,
                        principalTable: "PersonalAccounts",
                        principalColumn: "PersonalAccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CategoryID",
                table: "Transactions",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PersonalAccountID",
                table: "Transactions",
                column: "PersonalAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeStreams_PersonalAccounts_PersonalAccountID",
                table: "IncomeStreams",
                column: "PersonalAccountID",
                principalTable: "PersonalAccounts",
                principalColumn: "PersonalAccountID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeStreams_PersonalAccounts_PersonalAccountID",
                table: "IncomeStreams");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeStreams",
                table: "IncomeStreams");

            migrationBuilder.RenameTable(
                name: "IncomeStreams",
                newName: "IncomeStream");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeStreams_PersonalAccountID",
                table: "IncomeStream",
                newName: "IX_IncomeStream_PersonalAccountID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeStream",
                table: "IncomeStream",
                column: "IncomeStreamID");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeStream_PersonalAccounts_PersonalAccountID",
                table: "IncomeStream",
                column: "PersonalAccountID",
                principalTable: "PersonalAccounts",
                principalColumn: "PersonalAccountID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
