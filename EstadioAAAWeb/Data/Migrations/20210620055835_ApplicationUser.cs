using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstadioAAAWeb.Data.Migrations
{
    public partial class ApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RUT",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventUUID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventQuorum = table.Column<int>(type: "int", nullable: false),
                    EventFee = table.Column<int>(type: "int", nullable: false),
                    EventOrg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventUUID);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketUUID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserRUT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventUUID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketUUID);
                    table.ForeignKey(
                        name: "FK_Ticket_Event_EventUUID",
                        column: x => x.EventUUID,
                        principalTable: "Event",
                        principalColumn: "EventUUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    ReceiptUUID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TicketUUID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalCost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.ReceiptUUID);
                    table.ForeignKey(
                        name: "FK_Receipt_Ticket_TicketUUID",
                        column: x => x.TicketUUID,
                        principalTable: "Ticket",
                        principalColumn: "TicketUUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_TicketUUID",
                table: "Receipt",
                column: "TicketUUID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EventUUID",
                table: "Ticket",
                column: "EventUUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropColumn(
                name: "RUT",
                table: "AspNetUsers");
        }
    }
}
