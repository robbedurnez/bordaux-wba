using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BordauxWebApp.Migrations.Bordaux
{
    public partial class Move_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("7639f454-a6e5-4c04-b10c-5f44cdac09d1"));

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("c6d6f274-a00d-4428-ad02-ee5144014458"));

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("e7a05533-de1a-4233-bc53-a3bee82acc40"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("76fd0935-62ef-4fc1-ad0f-a88473edc94e"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("8c092154-95bc-47b2-bb0e-3ac0a34ce097"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c453bfbe-bf5a-48fb-9b65-a93fe8aa102d"));

            migrationBuilder.InsertData(
                table: "Acts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a6f92afb-4034-4271-94a3-4535da5681f8"), "Bordaux" },
                    { new Guid("a06bad0d-a155-4d5e-b5b4-71552d75e100"), "Justified" },
                    { new Guid("2f620308-eba3-4113-bb7a-c6cd9a790a27"), "DwightLight" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AddressLine", "City", "DateCreated", "EndDate", "EndTime", "Name", "PostalCode", "PromotorId", "StartDate", "StartTime" },
                values: new object[,]
                {
                    { new Guid("6453958f-32b3-488f-8a28-370224a41717"), "Stationsstraat 19", "Torhout", new DateTime(2020, 1, 5, 21, 37, 35, 765, DateTimeKind.Local).AddTicks(308), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), "2Fish invites Bordaux", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { new Guid("cf4c2d73-093d-4cc3-bfcc-6cdd3821734c"), "Kuipersstraat 13", "Brugge", new DateTime(2020, 1, 5, 21, 37, 35, 767, DateTimeKind.Local).AddTicks(359), new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0), "Club NEO invites Bordaux", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 23, 0, 0, 0) },
                    { new Guid("c2b81227-d487-40f5-ba55-e651e73fa316"), "Stationsstraat 10", "Torhout", new DateTime(2020, 1, 5, 21, 37, 35, 767, DateTimeKind.Local).AddTicks(393), new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), "2Fish invites Bordaux pt 2", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("2f620308-eba3-4113-bb7a-c6cd9a790a27"));

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("a06bad0d-a155-4d5e-b5b4-71552d75e100"));

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("a6f92afb-4034-4271-94a3-4535da5681f8"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("6453958f-32b3-488f-8a28-370224a41717"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c2b81227-d487-40f5-ba55-e651e73fa316"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("cf4c2d73-093d-4cc3-bfcc-6cdd3821734c"));

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
                table: "Events",
                columns: new[] { "Id", "AddressLine", "City", "DateCreated", "EndDate", "EndTime", "Name", "PostalCode", "PromotorId", "StartDate", "StartTime" },
                values: new object[,]
                {
                    { new Guid("76fd0935-62ef-4fc1-ad0f-a88473edc94e"), "Stationsstraat 19", "Torhout", new DateTime(2020, 1, 5, 20, 34, 4, 524, DateTimeKind.Local).AddTicks(5992), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), "2Fish invites Bordaux", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { new Guid("c453bfbe-bf5a-48fb-9b65-a93fe8aa102d"), "Kuipersstraat 13", "Brugge", new DateTime(2020, 1, 5, 20, 34, 4, 526, DateTimeKind.Local).AddTicks(5740), new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0), "Club NEO invites Bordaux", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 23, 0, 0, 0) },
                    { new Guid("8c092154-95bc-47b2-bb0e-3ac0a34ce097"), "Stationsstraat 10", "Torhout", new DateTime(2020, 1, 5, 20, 34, 4, 526, DateTimeKind.Local).AddTicks(5771), new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), "2Fish invites Bordaux pt 2", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) }
                });
        }
    }
}
