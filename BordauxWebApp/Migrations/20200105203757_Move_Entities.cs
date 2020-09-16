using Microsoft.EntityFrameworkCore.Migrations;

namespace BordauxWebApp.Migrations
{
    public partial class Move_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292db4c8-f3fc-484e-960a-56240fbea9cb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "58c580a9-60ef-4c07-89ba-99abbab41711", "0fd7809b-dbfe-4138-b11c-325c133ad9cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7144ac35-8a22-483b-b805-7833b10acf77", "1cc00f5c-d420-4e9c-aebd-ec0d24c91f00" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cc3b6957-0115-4c20-a363-bb86b936283e", "1cc00f5c-d420-4e9c-aebd-ec0d24c91f00" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fd7809b-dbfe-4138-b11c-325c133ad9cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cc00f5c-d420-4e9c-aebd-ec0d24c91f00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58c580a9-60ef-4c07-89ba-99abbab41711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7144ac35-8a22-483b-b805-7833b10acf77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc3b6957-0115-4c20-a363-bb86b936283e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42de65d5-a69d-4bd2-9537-e33dcbc785f4", "96f8c24c-d861-4668-bd73-cdc4ff15f5b8", "Admin", "ADMIN" },
                    { "cc854072-881a-4e1f-9800-cc1d57d42d16", "5277c353-d634-4990-b772-401bbe5fe7b1", "Promotor", "PROMOTOR" },
                    { "15cb2332-0933-4fa0-9f65-4bfc321235f0", "37ba9533-967c-4c2d-80d9-4f096c702bc0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicturePath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a9ff7e8c-50e8-48a2-82fc-800e48ac4b62", 0, "6cf79976-41fe-4dc2-992a-c370988a83ae", "dwight.senaeve@student.howest.be", false, "Dwight", "Senaeve", false, null, "DWIGHT.SENAEVE@STUDENT.HOWEST.BE", "DWIGHT.SENAEVE@STUDENT.HOWEST.BE", "AQAAAAEAACcQAAAAEDyTd4+GvAbjflpigfXVYA9v5aeECyQIwVrLovz97N22kxLSWMtaJZj8/jrbNPFgpw==", null, false, null, "{73a68092-d39d-4d2d-a9e7-30516a725aeb}", false, "dwight.senaeve@student.howest.be" },
                    { "7c4ab2f0-4c4a-4321-bfea-bc4e3156728f", 0, "643dc2ce-2aef-4d35-892c-dc3b1378f451", "robbe.durnez@student.howest.be", false, "Robbe", "Durnez", false, null, "ROBBE.DURNEZ@STUDENT.HOWEST.BE", "ROBBE.DURNEZ@STUDENT.HOWEST.BE", "AQAAAAEAACcQAAAAEJJ8L0hmzDDmELR1Rni+LisPbVMPSvLiITsCSqtxhU/pwOnrp7w24N2U9+kP5wenEQ==", null, false, null, "{527d0020-0a8c-48bd-b6ce-1155f987150f}", false, "robbe.durnez@student.howest.be" },
                    { "0b7077b2-c65d-40e3-a9db-02489c748f29", 0, "081204e1-04ee-4155-b6c1-1bf8b993e74f", "john.doe@student.howest.be", false, "John", "Doe", false, null, "JOHN.DOE@STUDENT.HOWEST.BE", "JOHN.DOE@STUDENT.HOWEST.BE", "AQAAAAEAACcQAAAAELA+TlC1hzAKb4Q6NTe1rWxR2XilC3BwwT0izKMBCmsAvPqQd2NrS6Jw6zlx6VnAiw==", null, false, null, "{84a09f4d-e472-46b4-9153-fef2481f824c}", false, "john.doe@student.howest.be" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a9ff7e8c-50e8-48a2-82fc-800e48ac4b62", "42de65d5-a69d-4bd2-9537-e33dcbc785f4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7c4ab2f0-4c4a-4321-bfea-bc4e3156728f", "42de65d5-a69d-4bd2-9537-e33dcbc785f4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0b7077b2-c65d-40e3-a9db-02489c748f29", "15cb2332-0933-4fa0-9f65-4bfc321235f0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc854072-881a-4e1f-9800-cc1d57d42d16");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0b7077b2-c65d-40e3-a9db-02489c748f29", "15cb2332-0933-4fa0-9f65-4bfc321235f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7c4ab2f0-4c4a-4321-bfea-bc4e3156728f", "42de65d5-a69d-4bd2-9537-e33dcbc785f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a9ff7e8c-50e8-48a2-82fc-800e48ac4b62", "42de65d5-a69d-4bd2-9537-e33dcbc785f4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15cb2332-0933-4fa0-9f65-4bfc321235f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42de65d5-a69d-4bd2-9537-e33dcbc785f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b7077b2-c65d-40e3-a9db-02489c748f29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c4ab2f0-4c4a-4321-bfea-bc4e3156728f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ff7e8c-50e8-48a2-82fc-800e48ac4b62");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1cc00f5c-d420-4e9c-aebd-ec0d24c91f00", "6bda60a7-fa2e-489d-b83c-54a0bc82db7a", "Admin", "ADMIN" },
                    { "292db4c8-f3fc-484e-960a-56240fbea9cb", "d32f2391-3574-4426-ad86-2d1e6d834add", "Promotor", "PROMOTOR" },
                    { "0fd7809b-dbfe-4138-b11c-325c133ad9cc", "062f9bfc-509f-40ee-be50-e9708fa9000a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicturePath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7144ac35-8a22-483b-b805-7833b10acf77", 0, "a7f0291d-1e3a-4d93-8727-29e8e4810952", "dwight.senaeve@student.howest.be", false, "Dwight", "Senaeve", false, null, "DWIGHT.SENAEVE@STUDENT.HOWEST.BE", "DWIGHT.SENAEVE@STUDENT.HOWEST.BE", "AQAAAAEAACcQAAAAEAi4rfs9sPrS8M9wO7slUrkLvPzyFO9obw+sAaL2g78SskHjhnfjelfmOGlFrjrapQ==", null, false, null, "{784f022e-3f70-4434-a40b-8b0a53c3f8e3}", false, "dwight.senaeve@student.howest.be" },
                    { "cc3b6957-0115-4c20-a363-bb86b936283e", 0, "b40779bb-8f2d-4b96-bc87-92fb2167c53c", "robbe.durnez@student.howest.be", false, "Robbe", "Durnez", false, null, "ROBBE.DURNEZ@STUDENT.HOWEST.BE", "ROBBE.DURNEZ@STUDENT.HOWEST.BE", "AQAAAAEAACcQAAAAEAYORwilWFwSj7Fcw3zcR3p5MzsI7EVv7gxP3edsgHjxoK/lKF/9+1uWxQMhacL68w==", null, false, null, "{49ec597d-8591-429e-9ad5-c5566a83c4f5}", false, "robbe.durnez@student.howest.be" },
                    { "58c580a9-60ef-4c07-89ba-99abbab41711", 0, "7935b91a-4c7f-4afa-b04f-7c27d187213b", "john.doe@student.howest.be", false, "John", "Doe", false, null, "JOHN.DOE@STUDENT.HOWEST.BE", "JOHN.DOE@STUDENT.HOWEST.BE", "AQAAAAEAACcQAAAAEGDegBGAe9mwcyr9XvTixH2zbK5xyMk1bXaPCGbDCw9hzklaQb7P8rpYIGFsn78PeQ==", null, false, null, "{76a991cd-a674-429e-b450-8dc47db3d9fd}", false, "john.doe@student.howest.be" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7144ac35-8a22-483b-b805-7833b10acf77", "1cc00f5c-d420-4e9c-aebd-ec0d24c91f00" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "cc3b6957-0115-4c20-a363-bb86b936283e", "1cc00f5c-d420-4e9c-aebd-ec0d24c91f00" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "58c580a9-60ef-4c07-89ba-99abbab41711", "0fd7809b-dbfe-4138-b11c-325c133ad9cc" });
        }
    }
}
