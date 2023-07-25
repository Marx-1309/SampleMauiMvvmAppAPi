using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WaterBillingMobileAppAPi.Migrations
{
    /// <inheritdoc />
    public partial class _1st_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CUSTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSTCLAS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPRCSTNM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNTCPRSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STMTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SHRTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADRSCODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPSZONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SHIPMTHD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAXSCHID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADDRESS1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADDRESS2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADDRESS3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COUNTRY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONE1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONE2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHONE3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRBTADCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRSTADCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STADDRCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLPRSNID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHEKBKID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PYMTRMID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRLMTTYP = table.Column<int>(type: "int", nullable: false),
                    CRLMTAMT = table.Column<double>(type: "float", nullable: false),
                    CRLMTPER = table.Column<int>(type: "int", nullable: false),
                    CRLMTPAM = table.Column<double>(type: "float", nullable: false),
                    CURNCYID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RATETPID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUSTDISC = table.Column<int>(type: "int", nullable: false),
                    PRCLEVEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MINPYTYP = table.Column<int>(type: "int", nullable: false),
                    MINPYDLR = table.Column<double>(type: "float", nullable: false),
                    MINPYPCT = table.Column<int>(type: "int", nullable: false),
                    FNCHATYP = table.Column<int>(type: "int", nullable: false),
                    FNCHPCNT = table.Column<int>(type: "int", nullable: false),
                    FINCHDLR = table.Column<double>(type: "float", nullable: false),
                    MXWOFTYP = table.Column<int>(type: "int", nullable: false),
                    MXWROFAM = table.Column<double>(type: "float", nullable: false),
                    COMMENT1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMMENT2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USERDEF1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USERDEF2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAXEXMT1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAXEXMT2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TXRGNNUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BALNCTYP = table.Column<int>(type: "int", nullable: false),
                    STMTCYCL = table.Column<int>(type: "int", nullable: false),
                    BANKNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BNKBRNCH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SALSTERR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEFCACTY = table.Column<int>(type: "int", nullable: false),
                    RMCSHACC = table.Column<int>(type: "int", nullable: false),
                    RMARACC = table.Column<int>(type: "int", nullable: false),
                    RMSLSACC = table.Column<int>(type: "int", nullable: false),
                    RMIVACC = table.Column<int>(type: "int", nullable: false),
                    RMCOSACC = table.Column<int>(type: "int", nullable: false),
                    RMTAKACC = table.Column<int>(type: "int", nullable: false),
                    RMAVACC = table.Column<int>(type: "int", nullable: false),
                    RMFCGACC = table.Column<int>(type: "int", nullable: false),
                    RMWRACC = table.Column<int>(type: "int", nullable: false),
                    RMSORACC = table.Column<int>(type: "int", nullable: false),
                    FRSTINDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    INACTIVE = table.Column<int>(type: "int", nullable: false),
                    HOLD = table.Column<int>(type: "int", nullable: false),
                    CRCARDID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRCRDNUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCRDXPDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KPDSTHST = table.Column<int>(type: "int", nullable: false),
                    KPCALHST = table.Column<int>(type: "int", nullable: false),
                    KPERHIST = table.Column<int>(type: "int", nullable: false),
                    KPTRXHST = table.Column<int>(type: "int", nullable: false),
                    NOTEINDX = table.Column<double>(type: "float", nullable: false),
                    CREATDDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revalue_Customer = table.Column<int>(type: "int", nullable: false),
                    Post_Results_To = table.Column<int>(type: "int", nullable: false),
                    FINCHID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GOVCRPID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GOVINDID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DISGRPER = table.Column<int>(type: "int", nullable: false),
                    DUEGRPER = table.Column<int>(type: "int", nullable: false),
                    DOCFMTID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Send_Email_Statements = table.Column<int>(type: "int", nullable: false),
                    USERLANG = table.Column<int>(type: "int", nullable: false),
                    GPSFOINTEGRATIONID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INTEGRATIONSOURCE = table.Column<int>(type: "int", nullable: false),
                    INTEGRATIONID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ORDERFULFILLDEFAULT = table.Column<int>(type: "int", nullable: false),
                    CUSTPRIORITY = table.Column<int>(type: "int", nullable: false),
                    CCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DECLID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RMOvrpymtWrtoffAcctIdx = table.Column<int>(type: "int", nullable: false),
                    SHIPCOMPLETE = table.Column<int>(type: "int", nullable: false),
                    CBVAT = table.Column<int>(type: "int", nullable: false),
                    INCLUDEINDP = table.Column<int>(type: "int", nullable: false),
                    DEX_ROW_TS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DEX_ROW_ID = table.Column<int>(type: "int", nullable: false),
                    GEO_LATITUTE = table.Column<double>(type: "float", nullable: false),
                    GEO_LONGITUDE = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Month",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Month", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RM00303",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SLTERDSC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INACTIVE = table.Column<int>(type: "int", nullable: false),
                    SLPRSNID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STMGRFNM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STMGRMNM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STMGRLNM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTRY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COSTTODT = table.Column<double>(type: "float", nullable: false),
                    TTLCOMTD = table.Column<double>(type: "float", nullable: false),
                    TTLCOMLY = table.Column<double>(type: "float", nullable: false),
                    NCOMSLYR = table.Column<double>(type: "float", nullable: false),
                    COMSLLYR = table.Column<double>(type: "float", nullable: false),
                    CSTLSTYR = table.Column<double>(type: "float", nullable: false),
                    COMSLTDT = table.Column<double>(type: "float", nullable: false),
                    NCOMSLTD = table.Column<double>(type: "float", nullable: false),
                    KPCALHST = table.Column<int>(type: "int", nullable: false),
                    KPERHIST = table.Column<int>(type: "int", nullable: false),
                    NOTEINDX = table.Column<double>(type: "float", nullable: false),
                    MODIFDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATDDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DEX_ROW_TS = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DEX_ROW_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RM00303", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReadingExport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthID = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    RM00303Id = table.Column<int>(type: "int", nullable: false),
                    RM00303Id1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingExport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReadingExport_RM00303_RM00303Id1",
                        column: x => x.RM00303Id1,
                        principalTable: "RM00303",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reading",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaterReadingExportID = table.Column<int>(type: "int", nullable: false),
                    CUSTOMER_NUMBER = table.Column<int>(type: "int", nullable: false),
                    CUSTOMER_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AREA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERF_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    METER_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CURRENT_READING = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PREVIOUS_READING = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthID = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CUSTOMER_ZONING = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterReadingTypeId = table.Column<int>(type: "int", nullable: true),
                    Meter_Reader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    READING_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReadingTaken = table.Column<bool>(type: "bit", nullable: true),
                    ReadingSync = table.Column<bool>(type: "bit", nullable: true),
                    ReadingExportId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reading", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reading_ReadingExport_ReadingExportId",
                        column: x => x.ReadingExportId,
                        principalTable: "ReadingExport",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42358d3e-3c22-45e1-be81-6caa7ba865ef", null, "User", "USER" },
                    { "d1b5952a-2162-46c7-b29e-1a2a68922c14", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f4631bd-f907-4409-b416-ba356312e659", 0, "2877614f-2f77-460a-8518-907a7b8ca881", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEN04/Y5JrWdbcqDmFGGUzdETaS1ln9gvFdM+We28N25VGo70a/CVWZkDLJi1SMKCGw==", null, false, "e8604866-c61b-4bda-8ea6-af4d244cb885", false, "user@localhost.com" },
                    { "408aa945-3d84-4421-8342-7269ec64d949", 0, "dacf39d6-3621-43a1-a273-7e52719a10b9", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEE79jNgfMoXk1rUke6bOHtzN4h783Nk6J1rxR+F9G3T3uI++n6k6SZqIFnInkc252A==", null, false, "8b090356-2409-4711-8c2b-fdcbd1d7278c", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "42358d3e-3c22-45e1-be81-6caa7ba865ef", "3f4631bd-f907-4409-b416-ba356312e659" },
                    { "d1b5952a-2162-46c7-b29e-1a2a68922c14", "408aa945-3d84-4421-8342-7269ec64d949" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reading_ReadingExportId",
                table: "Reading",
                column: "ReadingExportId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingExport_RM00303Id1",
                table: "ReadingExport",
                column: "RM00303Id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Month");

            migrationBuilder.DropTable(
                name: "Reading");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ReadingExport");

            migrationBuilder.DropTable(
                name: "RM00303");
        }
    }
}
