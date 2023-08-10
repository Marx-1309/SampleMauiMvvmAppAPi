﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaterBillingMobileAppAPi.Data;

#nullable disable

namespace WaterBillingMobileAppAPi.Migrations
{
    [DbContext(typeof(WaterBillingMobileAppAPiContext))]
    partial class WaterBillingMobileAppAPiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "408aa945-3d84-4421-8342-7269ec64d949",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8ebb95da-a4be-487b-b7a8-c6a67ca777ba",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHlggB4EV494yCVMZkHlyqPhqFhxyyKGvluonzuL3IQie5EoEpP5sX50bIaWdOv3hw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7203b36f-575f-442b-85d8-87267ec52f1b",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "3f4631bd-f907-4409-b416-ba356312e659",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8dfca399-b575-475f-9623-88835048fe25",
                            Email = "user@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@LOCALHOST.COM",
                            NormalizedUserName = "USER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGWqSFB7/QMcly28ni8qKkc44cI6tZlfHs/RvQ8E0QgciWc6t2+zWU/OXG0ISbAjIg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "621bc901-4d38-44a9-9246-8eb509025db4",
                            TwoFactorEnabled = false,
                            UserName = "user@localhost.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                            RoleId = "d1b5952a-2162-46c7-b29e-1a2a68922c14"
                        },
                        new
                        {
                            UserId = "3f4631bd-f907-4409-b416-ba356312e659",
                            RoleId = "42358d3e-3c22-45e1-be81-6caa7ba865ef"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.Customer", b =>
                {
                    b.Property<string>("CUSTMBR")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CUSTMBR");

                    b.Property<string>("ADDRESS1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ADDRESS2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ADDRESS3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ADRSCODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BALNCTYP")
                        .HasColumnType("int");

                    b.Property<string>("BANKNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BNKBRNCH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CBVAT")
                        .HasColumnType("int");

                    b.Property<DateTime>("CCRDXPDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("CCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CHEKBKID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNTCPRSN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COMMENT1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COMMENT2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COUNTRY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPRCSTNM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRCARDID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRCRDNUM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATDDT")
                        .HasColumnType("datetime2");

                    b.Property<double>("CRLMTAMT")
                        .HasColumnType("float");

                    b.Property<double>("CRLMTPAM")
                        .HasColumnType("float");

                    b.Property<int>("CRLMTPER")
                        .HasColumnType("int");

                    b.Property<int>("CRLMTTYP")
                        .HasColumnType("int");

                    b.Property<string>("CURNCYID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUSTCLAS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CUSTDISC")
                        .HasColumnType("int");

                    b.Property<string>("CUSTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CUSTPRIORITY")
                        .HasColumnType("int");

                    b.Property<string>("DECLID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DEFCACTY")
                        .HasColumnType("int");

                    b.Property<int>("DEX_ROW_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DEX_ROW_TS")
                        .HasColumnType("datetime2");

                    b.Property<int>("DISGRPER")
                        .HasColumnType("int");

                    b.Property<string>("DOCFMTID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DUEGRPER")
                        .HasColumnType("int");

                    b.Property<string>("FAX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FINCHDLR")
                        .HasColumnType("float");

                    b.Property<string>("FINCHID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FNCHATYP")
                        .HasColumnType("int");

                    b.Property<int>("FNCHPCNT")
                        .HasColumnType("int");

                    b.Property<DateTime>("FRSTINDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("GOVCRPID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GOVINDID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPSFOINTEGRATIONID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HOLD")
                        .HasColumnType("int");

                    b.Property<int>("INACTIVE")
                        .HasColumnType("int");

                    b.Property<int>("INCLUDEINDP")
                        .HasColumnType("int");

                    b.Property<string>("INTEGRATIONID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("INTEGRATIONSOURCE")
                        .HasColumnType("int");

                    b.Property<int>("KPCALHST")
                        .HasColumnType("int");

                    b.Property<int>("KPDSTHST")
                        .HasColumnType("int");

                    b.Property<int>("KPERHIST")
                        .HasColumnType("int");

                    b.Property<int>("KPTRXHST")
                        .HasColumnType("int");

                    b.Property<double>("MINPYDLR")
                        .HasColumnType("float");

                    b.Property<int>("MINPYPCT")
                        .HasColumnType("int");

                    b.Property<int>("MINPYTYP")
                        .HasColumnType("int");

                    b.Property<DateTime>("MODIFDT")
                        .HasColumnType("datetime2");

                    b.Property<int>("MXWOFTYP")
                        .HasColumnType("int");

                    b.Property<double>("MXWROFAM")
                        .HasColumnType("float");

                    b.Property<double>("NOTEINDX")
                        .HasColumnType("float");

                    b.Property<int>("ORDERFULFILLDEFAULT")
                        .HasColumnType("int");

                    b.Property<bool?>("OutstandingLetterActive")
                        .HasColumnType("bit");

                    b.Property<string>("PHONE1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHONE2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHONE3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRBTADCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRCLEVEL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PRSTADCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PYMTRMID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Post_Results_To")
                        .HasColumnType("int");

                    b.Property<bool?>("PrintingActive")
                        .HasColumnType("bit");

                    b.Property<string>("RATETPID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RMARACC")
                        .HasColumnType("int");

                    b.Property<int>("RMAVACC")
                        .HasColumnType("int");

                    b.Property<int>("RMCOSACC")
                        .HasColumnType("int");

                    b.Property<int>("RMCSHACC")
                        .HasColumnType("int");

                    b.Property<int>("RMFCGACC")
                        .HasColumnType("int");

                    b.Property<int>("RMIVACC")
                        .HasColumnType("int");

                    b.Property<int>("RMOvrpymtWrtoffAcctIdx")
                        .HasColumnType("int");

                    b.Property<int>("RMSLSACC")
                        .HasColumnType("int");

                    b.Property<int>("RMSORACC")
                        .HasColumnType("int");

                    b.Property<int>("RMTAKACC")
                        .HasColumnType("int");

                    b.Property<int>("RMWRACC")
                        .HasColumnType("int");

                    b.Property<int>("Revalue_Customer")
                        .HasColumnType("int");

                    b.Property<string>("SALSTERR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SHIPCOMPLETE")
                        .HasColumnType("int");

                    b.Property<string>("SHIPMTHD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SHRTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SLPRSNID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STADDRCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("STMTCYCL")
                        .HasColumnType("int");

                    b.Property<string>("STMTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Send_Email_Statements")
                        .HasColumnType("int");

                    b.Property<string>("TAXEXMT1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TAXEXMT2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TAXSCHID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TXRGNNUM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UPSZONE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USERDEF1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USERDEF2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("USERLANG")
                        .HasColumnType("int");

                    b.Property<string>("ZIP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CUSTMBR");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.Month", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MonthName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Month");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.RM00303", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("COMSLLYR")
                        .HasColumnType("float");

                    b.Property<double>("COMSLTDT")
                        .HasColumnType("float");

                    b.Property<double>("COSTTODT")
                        .HasColumnType("float");

                    b.Property<string>("COUNTRY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CREATDDT")
                        .HasColumnType("datetime2");

                    b.Property<double>("CSTLSTYR")
                        .HasColumnType("float");

                    b.Property<int>("DEX_ROW_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DEX_ROW_TS")
                        .HasColumnType("datetime2");

                    b.Property<int>("INACTIVE")
                        .HasColumnType("int");

                    b.Property<int>("KPCALHST")
                        .HasColumnType("int");

                    b.Property<int>("KPERHIST")
                        .HasColumnType("int");

                    b.Property<DateTime>("MODIFDT")
                        .HasColumnType("datetime2");

                    b.Property<double>("NCOMSLTD")
                        .HasColumnType("float");

                    b.Property<double>("NCOMSLYR")
                        .HasColumnType("float");

                    b.Property<double>("NOTEINDX")
                        .HasColumnType("float");

                    b.Property<string>("SLPRSNID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SLTERDSC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STMGRFNM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STMGRLNM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STMGRMNM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TTLCOMLY")
                        .HasColumnType("float");

                    b.Property<double>("TTLCOMTD")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("RM00303");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.Reading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AREA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CURRENT_READING")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CUSTOMER_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUSTOMER_NUMBER")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUSTOMER_ZONING")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ERF_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("METER_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meter_Reader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthID")
                        .HasColumnType("int");

                    b.Property<decimal>("PREVIOUS_READING")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("READING_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReadingExportId")
                        .HasColumnType("int");

                    b.Property<bool?>("ReadingSync")
                        .HasColumnType("bit");

                    b.Property<bool?>("ReadingTaken")
                        .HasColumnType("bit");

                    b.Property<string>("RouteNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WaterReadingExportID")
                        .HasColumnType("int");

                    b.Property<int?>("WaterReadingTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReadingExportId");

                    b.ToTable("Reading");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.ReadingExport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MonthID")
                        .HasColumnType("int");

                    b.Property<int>("RM00303Id")
                        .HasColumnType("int");

                    b.Property<string>("RM00303Id1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MonthID");

                    b.HasIndex("RM00303Id1");

                    b.ToTable("ReadingExport");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.Reading", b =>
                {
                    b.HasOne("WaterBillingMobileAppAPi.Models.ReadingExport", null)
                        .WithMany("Readings")
                        .HasForeignKey("ReadingExportId");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.ReadingExport", b =>
                {
                    b.HasOne("WaterBillingMobileAppAPi.Models.Month", "Month")
                        .WithMany()
                        .HasForeignKey("MonthID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WaterBillingMobileAppAPi.Models.RM00303", "RM00303")
                        .WithMany("ReadingExport")
                        .HasForeignKey("RM00303Id1");

                    b.Navigation("Month");

                    b.Navigation("RM00303");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.RM00303", b =>
                {
                    b.Navigation("ReadingExport");
                });

            modelBuilder.Entity("WaterBillingMobileAppAPi.Models.ReadingExport", b =>
                {
                    b.Navigation("Readings");
                });
#pragma warning restore 612, 618
        }
    }
}
