using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BordauxWebApp.Migrations.Bordaux
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AddressLine = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false),
                    PromotorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Promotors_PromotorId",
                        column: x => x.PromotorId,
                        principalTable: "Promotors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventActs",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    ActId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventActs", x => new { x.EventId, x.ActId });
                    table.ForeignKey(
                        name: "FK_EventActs_Acts_ActId",
                        column: x => x.ActId,
                        principalTable: "Acts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventActs_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Acts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c6d6f274-a00d-4428-ad02-ee5144014458"), "Bordaux" },
                    { new Guid("e7a05533-de1a-4233-bc53-a3bee82acc40"), "Justified" },
                    { new Guid("7639f454-a6e5-4c04-b10c-5f44cdac09d1"), "DwightLight" }
                });

            migrationBuilder.InsertData(
                table: "Promotors",
                columns: new[] { "Id", "Email" },
                values: new object[] { "a11f645a-a580-47c4-87fb-6a57b8e16f68", "robbe.durnez@student.howest.be" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AddressLine", "City", "DateCreated", "EndDate", "EndTime", "Name", "PostalCode", "PromotorId", "StartDate", "StartTime" },
                values: new object[] { new Guid("76fd0935-62ef-4fc1-ad0f-a88473edc94e"), "Stationsstraat 19", "Torhout", new DateTime(2020, 1, 5, 20, 34, 4, 524, DateTimeKind.Local).AddTicks(5992), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), "2Fish invites Bordaux", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AddressLine", "City", "DateCreated", "EndDate", "EndTime", "Name", "PostalCode", "PromotorId", "StartDate", "StartTime" },
                values: new object[] { new Guid("c453bfbe-bf5a-48fb-9b65-a93fe8aa102d"), "Kuipersstraat 13", "Brugge", new DateTime(2020, 1, 5, 20, 34, 4, 526, DateTimeKind.Local).AddTicks(5740), new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0), "Club NEO invites Bordaux", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 23, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AddressLine", "City", "DateCreated", "EndDate", "EndTime", "Name", "PostalCode", "PromotorId", "StartDate", "StartTime" },
                values: new object[] { new Guid("8c092154-95bc-47b2-bb0e-3ac0a34ce097"), "Stationsstraat 10", "Torhout", new DateTime(2020, 1, 5, 20, 34, 4, 526, DateTimeKind.Local).AddTicks(5771), new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), "2Fish invites Bordaux pt 2", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) });

            migrationBuilder.CreateIndex(
                name: "IX_EventActs_ActId",
                table: "EventActs",
                column: "ActId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PromotorId",
                table: "Events",
                column: "PromotorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventActs");

            migrationBuilder.DropTable(
                name: "Acts");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Promotors");
        }
    }
}
