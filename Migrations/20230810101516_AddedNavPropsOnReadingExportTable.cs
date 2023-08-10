using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaterBillingMobileAppAPi.Migrations
{
    /// <inheritdoc />
    public partial class AddedNavPropsOnReadingExportTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dfca399-b575-475f-9623-88835048fe25", "AQAAAAIAAYagAAAAEGWqSFB7/QMcly28ni8qKkc44cI6tZlfHs/RvQ8E0QgciWc6t2+zWU/OXG0ISbAjIg==", "621bc901-4d38-44a9-9246-8eb509025db4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ebb95da-a4be-487b-b7a8-c6a67ca777ba", "AQAAAAIAAYagAAAAEHlggB4EV494yCVMZkHlyqPhqFhxyyKGvluonzuL3IQie5EoEpP5sX50bIaWdOv3hw==", "7203b36f-575f-442b-85d8-87267ec52f1b" });

            migrationBuilder.CreateIndex(
                name: "IX_ReadingExport_MonthID",
                table: "ReadingExport",
                column: "MonthID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingExport_Month_MonthID",
                table: "ReadingExport",
                column: "MonthID",
                principalTable: "Month",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadingExport_Month_MonthID",
                table: "ReadingExport");

            migrationBuilder.DropIndex(
                name: "IX_ReadingExport_MonthID",
                table: "ReadingExport");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53ab65a7-a983-43a7-82e2-e04c2193104d", "AQAAAAIAAYagAAAAEOtVgBUgP1Z7JY7kNb3Yuqlq9qYBlOhf1VqVdQMWvw+EnheWx4QJphL2h3ittW+0bA==", "85173b5a-5707-4733-8a60-e15c788fa448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a321feea-f12b-4b03-b486-c3bce716b6d1", "AQAAAAIAAYagAAAAEI6TaQkzVKyOuUW1/bRUdXNX2wtvfTviubyDn2aKy8A47PmdHI2cexuCB6tROOY6hw==", "b2b22260-5715-4321-be56-8104b5db6f04" });
        }
    }
}
