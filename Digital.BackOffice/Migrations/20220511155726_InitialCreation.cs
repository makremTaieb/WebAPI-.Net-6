using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digital.BackOffice.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Relations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DigitalId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Segment = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CUser = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    UUSer = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DigitalId = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Scope = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Domain = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CUser = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    UUSer = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    AccountNumber = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    RIB = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TierId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CUser = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    UUSer = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Tiers_TierId",
                        column: x => x.TierId,
                        principalTable: "Tiers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RelationId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TierId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CUser = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    UUSer = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RT_Relations_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Relations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RT_Tiers_TierId",
                        column: x => x.TierId,
                        principalTable: "Tiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_TierId",
                table: "Accounts",
                column: "TierId");

            migrationBuilder.CreateIndex(
                name: "IX_RT_RelationId",
                table: "RT",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_RT_TierId",
                table: "RT",
                column: "TierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "RT");

            migrationBuilder.DropTable(
                name: "Relations");

            migrationBuilder.DropTable(
                name: "Tiers");
        }
    }
}
