using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookingApp.Data.Migrations
{
    public partial class UpdateCarsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Makes_MakeId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Makes_MakeId",
                table: "Cars",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Makes_MakeId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Makes_MakeId",
                table: "Cars",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
