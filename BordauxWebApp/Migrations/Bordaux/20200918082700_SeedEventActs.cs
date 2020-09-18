using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BordauxWebApp.Migrations.Bordaux
{
    public partial class SeedEventActs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393"), "Bordaux" },
                    { new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072"), "Justified" },
                    { new Guid("b19274b5-6d5d-435c-a508-5cd46e74efc7"), "DwightLight" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AddressLine", "City", "DateCreated", "EndDate", "EndTime", "Name", "PostalCode", "PromotorId", "StartDate", "StartTime" },
                values: new object[,]
                {
                    { new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"), "Stationsstraat 19", "Torhout", new DateTime(2020, 9, 18, 10, 27, 0, 147, DateTimeKind.Local).AddTicks(7310), new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), "2Fish invites Bordaux", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) },
                    { new Guid("4ef55508-b915-4da1-828a-dc54aa848e2a"), "Kuipersstraat 13", "Brugge", new DateTime(2020, 9, 18, 10, 27, 0, 152, DateTimeKind.Local).AddTicks(8020), new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 0, 0, 0), "Club NEO invites Bordaux", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 23, 0, 0, 0) },
                    { new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"), "Stationsstraat 10", "Torhout", new DateTime(2020, 9, 18, 10, 27, 0, 152, DateTimeKind.Local).AddTicks(8050), new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 0, 0, 0), "2Fish invites Bordaux pt 2", 8840, "a11f645a-a580-47c4-87fb-6a57b8e16f68", new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 18, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "EventActs",
                columns: new[] { "EventId", "ActId" },
                values: new object[,]
                {
                    { new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"), new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072") },
                    { new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"), new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393") },
                    { new Guid("4ef55508-b915-4da1-828a-dc54aa848e2a"), new Guid("b19274b5-6d5d-435c-a508-5cd46e74efc7") },
                    { new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"), new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393") },
                    { new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"), new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventActs",
                keyColumns: new[] { "EventId", "ActId" },
                keyValues: new object[] { new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"), new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072") });

            migrationBuilder.DeleteData(
                table: "EventActs",
                keyColumns: new[] { "EventId", "ActId" },
                keyValues: new object[] { new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"), new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393") });

            migrationBuilder.DeleteData(
                table: "EventActs",
                keyColumns: new[] { "EventId", "ActId" },
                keyValues: new object[] { new Guid("4ef55508-b915-4da1-828a-dc54aa848e2a"), new Guid("b19274b5-6d5d-435c-a508-5cd46e74efc7") });

            migrationBuilder.DeleteData(
                table: "EventActs",
                keyColumns: new[] { "EventId", "ActId" },
                keyValues: new object[] { new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"), new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072") });

            migrationBuilder.DeleteData(
                table: "EventActs",
                keyColumns: new[] { "EventId", "ActId" },
                keyValues: new object[] { new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"), new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393") });

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("4bbc7c85-f3d4-4727-939f-e4244c894072"));

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("8d2ac1e7-2e7c-4b88-a4e7-b73339c3a393"));

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "Id",
                keyValue: new Guid("b19274b5-6d5d-435c-a508-5cd46e74efc7"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("26cc2bff-8fc2-44a8-83a3-8b84efa28a0c"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("4ef55508-b915-4da1-828a-dc54aa848e2a"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("f040a0ba-5117-45be-9687-581d7e8d3ece"));

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
    }
}
