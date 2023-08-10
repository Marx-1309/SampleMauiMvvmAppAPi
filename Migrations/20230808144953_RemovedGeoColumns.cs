using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaterBillingMobileAppAPi.Migrations
{
    /// <inheritdoc />
    public partial class RemovedGeoColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GEO_LATITUTE",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "GEO_LONGITUDE",
                table: "Customer");

            migrationBuilder.AlterColumn<string>(
                name: "CUSTOMER_NUMBER",
                table: "Reading",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CUSTOMER_NUMBER",
                table: "Reading",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "GEO_LATITUTE",
                table: "Customer",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GEO_LONGITUDE",
                table: "Customer",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6351d2f1-9370-4ea1-a8ad-464bc71a74d2", "AQAAAAIAAYagAAAAEMeP/zucDsCP3NSQU36m2/1E10gl1MMH4HPPcGX/2pC6Qeo8DRCLfCLWEintncom5Q==", "a693a726-3778-4694-8340-9dab2cd96553" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db1bca79-e65c-4d5e-a4e2-62082513dfa0", "AQAAAAIAAYagAAAAEMDT64E7nOwHWRXnC6u5qDa0siyRExCJBvqNPw296BkkAs+ZOmpErg1M7MmryQbyMQ==", "7c29ba31-8248-4023-94b9-25be362908c3" });
        }
    }
}
