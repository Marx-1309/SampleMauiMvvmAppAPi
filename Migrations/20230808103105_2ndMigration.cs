using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaterBillingMobileAppAPi.Migrations
{
    /// <inheritdoc />
    public partial class _2ndMigration : Migration
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c770190d-1d93-4ecd-b440-b8fde133b5c2", "AQAAAAIAAYagAAAAEFgUDQQSTg9C91oJFSFJEC3GC5cbdQ4eI/1n8StO5dVfx30dvTY2Uwlpgqq1E9Uizw==", "3b075e49-c4e1-4e6a-88d6-4eef14517714" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b0e38a1-6ad1-4a73-b647-c3599fd860c0", "AQAAAAIAAYagAAAAEPvdvKO17WmbdSaePJciTr6fupfTicHXdRbHJOnzECF84gZt1DPQbmJd+Rdxd47Kxg==", "d0210bd4-6ba0-42f2-a44c-41c34a0fd9a0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "08608d29-744f-4087-aa32-20ad591788e8", "AQAAAAIAAYagAAAAEOXOyXQL2k+bAkhgYhixslpoIqj1lrancuBHAnnBCyYhgHVsMhjiIOonACMwbH/h/A==", "acfacc94-8804-4ea9-92c7-db8c33ce9ea4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00e53b31-dd8e-482d-a506-3dc7df53ca53", "AQAAAAIAAYagAAAAEPy8FdDrwXzVuzv/BACcUA17Tfc3vNUDNkw9GqLIRWCbysnMoVdQfPpo87ybcv8RxQ==", "c3cbba3a-7eed-48cc-8b3d-f39c3a0dc106" });
        }
    }
}
