using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementSystem.Migrations
{
    public partial class updatedSeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4cae5d23-f61f-4cdc-9c0d-c47fe3dd1fcb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0b3d9885-0981-4466-83b3-21625a28183a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "c50a8286-e23e-4e97-8ae1-d4fbe60db6af", "Ivan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "4d06e0ac-6b5a-4c3b-8336-f970cde2b520", "Jovan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "4be6cb4a-ab1b-4903-9482-17137158fdea", "Mirko" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "e61f16f6-97e3-425f-b559-389110baa064", "Slavko" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "ffbf1e79-b903-4fa8-a53e-9211eb6290ea", "Simo" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "b3c81961-58b0-43d4-a5dc-db8cebff4183", "Luka" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "20dbffd8-fdf7-4188-8067-7d2432780f48", "Ante" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "83b7e864-97b9-4058-90f8-3eeb545ce3d3", "Filip" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "69646b25-50cb-482e-82ec-526637333a57", "Djuro" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "4cf7be92-6443-4328-94c7-f51c39facf9b", "Ivica" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "a56daf66-3b2e-4fc3-9eec-73fd3bfa39c4", "Marica" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "105711a5-bcbd-4c40-a7ea-105c9eb9ebab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1b694df5-adc0-4ef2-9772-45da80cff0cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "47707a04-36c7-4cb9-ad94-43a182c57d5c", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "3910d2f4-8403-4ac0-81c1-a976a9a96402", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "20cd0f25-77a8-40dc-99b8-e6cd2be72ee9", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "c6278785-be4d-417b-b43c-3f8ff66cb0b8", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "8122e3e7-d8ef-43e0-826b-4ac84aba72c0", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "df84bce9-ddf1-48e4-9cec-71c9a4807524", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "7e016185-f3cd-4d4e-86e9-508b79e4f37a", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "4e2a9240-83ea-4473-afce-b4edb3b14eb8", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "9f3361c7-474e-464b-9f9c-fb066687cbe9", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "b4af3758-2d49-470e-af8d-6917f89aa6d2", "Mark" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "FirstName" },
                values: new object[] { "76e82d09-bb65-4a8d-8734-5440978e968c", "Mark" });
        }
    }
}
