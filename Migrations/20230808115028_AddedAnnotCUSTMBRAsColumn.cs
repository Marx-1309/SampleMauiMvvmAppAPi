using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaterBillingMobileAppAPi.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnnotCUSTMBRAsColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4b8e9624-1f68-431c-a21b-fdd5532b9dbb", "AQAAAAIAAYagAAAAEAoW8TrRm3haALf1EhpOvFDzES8uXE7NHbDrE9ckpymwL5dVlMzjkxTu3/O4RaF1Tw==", "e81cf93d-754f-40a5-88fd-09343938dbb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0a090a1-3583-4140-a6d4-d3d63c6e1e34", "AQAAAAIAAYagAAAAEM0jpTSz39hrIjpO8l+afqVupecHq8Z+69wm2BtrMEBVfvAHi6I3+rRRhN0Vl4aiCg==", "75e52b7d-d263-4500-99cb-3e355a16edf3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
