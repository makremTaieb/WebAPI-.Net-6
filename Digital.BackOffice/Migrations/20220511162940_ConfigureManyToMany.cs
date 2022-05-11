using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digital.BackOffice.Migrations
{
    public partial class ConfigureManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RT_Relations_RelationId",
                table: "RT");

            migrationBuilder.DropForeignKey(
                name: "FK_RT_Tiers_TierId",
                table: "RT");

            migrationBuilder.AlterColumn<int>(
                name: "TierId",
                table: "RT",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AlterColumn<int>(
                name: "RelationId",
                table: "RT",
                type: "NUMBER(10)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.AddForeignKey(
                name: "FK_RT_Relations_RelationId",
                table: "RT",
                column: "RelationId",
                principalTable: "Relations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RT_Tiers_TierId",
                table: "RT",
                column: "TierId",
                principalTable: "Tiers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RT_Relations_RelationId",
                table: "RT");

            migrationBuilder.DropForeignKey(
                name: "FK_RT_Tiers_TierId",
                table: "RT");

            migrationBuilder.AlterColumn<int>(
                name: "TierId",
                table: "RT",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RelationId",
                table: "RT",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RT_Relations_RelationId",
                table: "RT",
                column: "RelationId",
                principalTable: "Relations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RT_Tiers_TierId",
                table: "RT",
                column: "TierId",
                principalTable: "Tiers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
