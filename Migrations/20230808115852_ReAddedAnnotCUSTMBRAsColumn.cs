using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaterBillingMobileAppAPi.Migrations
{
    /// <inheritdoc />
    public partial class ReAddedAnnotCUSTMBRAsColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "CUSTMBR");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CUSTMBR",
                table: "Customer",
                newName: "Id");

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
    }
}
