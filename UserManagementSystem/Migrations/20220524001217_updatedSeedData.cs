using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementSystem.Migrations
{
    public partial class updatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "105711a5-bcbd-4c40-a7ea-105c9eb9ebab", "marko@marko1.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "1b694df5-adc0-4ef2-9772-45da80cff0cc", "marko@marko2.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "47707a04-36c7-4cb9-ad94-43a182c57d5c", "marko@mar3ko.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "3910d2f4-8403-4ac0-81c1-a976a9a96402", "marko@mark4o.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "20cd0f25-77a8-40dc-99b8-e6cd2be72ee9", "marko@marko4.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "c6278785-be4d-417b-b43c-3f8ff66cb0b8", "marko@m6arko.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "8122e3e7-d8ef-43e0-826b-4ac84aba72c0", "marko@ma6rko.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "df84bce9-ddf1-48e4-9cec-71c9a4807524", "marko@mar6ko.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "7e016185-f3cd-4d4e-86e9-508b79e4f37a", "arko@mark6o.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "4e2a9240-83ea-4473-afce-b4edb3b14eb8", "marko@marko6.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "9f3361c7-474e-464b-9f9c-fb066687cbe9", "marko@m7arko.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "b4af3758-2d49-470e-af8d-6917f89aa6d2", "marko@ma7rko.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "76e82d09-bb65-4a8d-8734-5440978e968c", "marko@mar7ko.com" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "User opis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "14aa54f5-7604-41f1-b228-843bad46b407", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "a635760b-8196-48a3-9ec6-3da47e3143a5", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "e6a87ea4-327a-46ec-9a72-f6cab5bb86e7", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "55a19c49-cd7f-4eaa-97e4-84cb0692a9c4", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "2a0f49a8-f623-489d-b87f-ae91ad1297dd", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "7368fc4a-4125-4671-b9a3-2ed179c4d68c", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "2f7f12e9-36e6-448b-bf29-5f4762f9cbce", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "bf9f1d9c-4862-44cd-9cb3-265736a98859", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "ac1edcdc-b1fe-48f1-bbd4-d77db13f92e5", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "c25b1aea-181a-453a-9458-2469819b5bfa", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "70468c0d-e467-450e-8e8c-f707c07bde2b", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "e6f447ea-5525-4163-871d-d76c9496bed3", "usernm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "UserName" },
                values: new object[] { "7a57ad3e-521b-436c-8774-f871608f9cf3", "usernm" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "User opsi");
        }
    }
}
