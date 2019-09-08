using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wholesale.Migrations
{
    public partial class a3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "condition",
                table: "Orders");

            migrationBuilder.AddColumn<bool>(
                name: "activeUser",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "exisitState",
                table: "Products",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<bool>(
                name: "activeProduct",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "conditionID",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Condition",
                columns: table => new
                {
                    conditionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.conditionID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_conditionID",
                table: "Orders",
                column: "conditionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Condition_conditionID",
                table: "Orders",
                column: "conditionID",
                principalTable: "Condition",
                principalColumn: "conditionID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Condition_conditionID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropIndex(
                name: "IX_Orders_conditionID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "activeUser",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "activeProduct",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "conditionID",
                table: "Orders");

            migrationBuilder.AlterColumn<bool>(
                name: "exisitState",
                table: "Products",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "condition",
                table: "Orders",
                nullable: true);
        }
    }
}
