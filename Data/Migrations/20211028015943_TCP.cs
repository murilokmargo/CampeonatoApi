using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class TCP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campeonato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeAId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampeonatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampeonatoId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GolTimeA = table.Column<int>(type: "int", nullable: false),
                    GolTimeB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partida_Campeonato_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partida_Campeonato_CampeonatoId1",
                        column: x => x.CampeonatoId1,
                        principalTable: "Campeonato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partida_Time_TimeAId",
                        column: x => x.TimeAId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partida_Time_TimeBId",
                        column: x => x.TimeBId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partida_CampeonatoId",
                table: "Partida",
                column: "CampeonatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_CampeonatoId1",
                table: "Partida",
                column: "CampeonatoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_TimeAId",
                table: "Partida",
                column: "TimeAId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_TimeBId",
                table: "Partida",
                column: "TimeBId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_Nome",
                table: "Time",
                column: "Nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partida");

            migrationBuilder.DropTable(
                name: "Campeonato");

            migrationBuilder.DropTable(
                name: "Time");
        }
    }
}
