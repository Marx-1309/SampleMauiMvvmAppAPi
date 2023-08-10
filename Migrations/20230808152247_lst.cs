using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaterBillingMobileAppAPi.Migrations
{
    /// <inheritdoc />
    public partial class lst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PrintingActive",
                table: "Customer",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "OutstandingLetterActive",
                table: "Customer",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PrintingActive",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "OutstandingLetterActive",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "496a900b-6d56-44e1-acdb-d4847ec00026", "AQAAAAIAAYagAAAAEOm7eMlmB0YYuNc6tn48t4Ga8iN/CrAI7+/RyfF979d40Xx4YKAT1jZP0j7USZkpHg==", "8288a69e-01eb-476b-8706-cb5a1c9ad156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b16b4db-48c3-41a9-bd56-a7c4d809490f", "AQAAAAIAAYagAAAAEP2JUFD9NB8oOBbYd92KpWY1/zUeyM2bZgC0o3ykmHp3m/h+XgP+fQ/dN88ubhB58w==", "d8614310-463a-4475-8e8c-e38a5b753fd2" });
        }
    }
}
