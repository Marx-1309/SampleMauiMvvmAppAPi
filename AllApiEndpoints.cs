using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using WaterBillingMobileAppAPi.Data;
using WaterBillingMobileAppAPi.Models;
namespace WaterBillingMobileAppAPi;

public static class AllApiEndpoints
{
    public static void MapCustomerEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Customer").WithTags(nameof(Customer));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Customer.ToListAsync();
        })
        .WithName("GetAllCustomers").AllowAnonymous()
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Customer>, NotFound>> (string id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Customer.AsNoTracking()
                .FirstOrDefaultAsync(model => model.CUSTMBR == id)
                is Customer model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetCustomerById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (string id, Customer customer, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Customer
                .Where(model => model.CUSTMBR == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.CUSTMBR, customer.CUSTMBR)
                  .SetProperty(m => m.CUSTNAME, customer.CUSTNAME)
                  .SetProperty(m => m.CUSTCLAS, customer.CUSTCLAS)
                  .SetProperty(m => m.CPRCSTNM, customer.CPRCSTNM)
                  .SetProperty(m => m.CNTCPRSN, customer.CNTCPRSN)
                  .SetProperty(m => m.STMTNAME, customer.STMTNAME)
                  .SetProperty(m => m.SHRTNAME, customer.SHRTNAME)
                  .SetProperty(m => m.ADRSCODE, customer.ADRSCODE)
                  .SetProperty(m => m.UPSZONE, customer.UPSZONE)
                  .SetProperty(m => m.SHIPMTHD, customer.SHIPMTHD)
                  .SetProperty(m => m.TAXSCHID, customer.TAXSCHID)
                  .SetProperty(m => m.ADDRESS1, customer.ADDRESS1)
                  .SetProperty(m => m.ADDRESS2, customer.ADDRESS2)
                  .SetProperty(m => m.ADDRESS3, customer.ADDRESS3)
                  .SetProperty(m => m.COUNTRY, customer.COUNTRY)
                  .SetProperty(m => m.CITY, customer.CITY)
                  .SetProperty(m => m.STATE, customer.STATE)
                  .SetProperty(m => m.ZIP, customer.ZIP)
                  .SetProperty(m => m.PHONE1, customer.PHONE1)
                  .SetProperty(m => m.PHONE2, customer.PHONE2)
                  .SetProperty(m => m.PHONE3, customer.PHONE3)
                  .SetProperty(m => m.FAX, customer.FAX)
                  .SetProperty(m => m.PRBTADCD, customer.PRBTADCD)
                  .SetProperty(m => m.PRSTADCD, customer.PRSTADCD)
                  .SetProperty(m => m.STADDRCD, customer.STADDRCD)
                  .SetProperty(m => m.SLPRSNID, customer.SLPRSNID)
                  .SetProperty(m => m.CHEKBKID, customer.CHEKBKID)
                  .SetProperty(m => m.PYMTRMID, customer.PYMTRMID)
                  .SetProperty(m => m.CRLMTTYP, customer.CRLMTTYP)
                  .SetProperty(m => m.CRLMTAMT, customer.CRLMTAMT)
                  .SetProperty(m => m.CRLMTPER, customer.CRLMTPER)
                  .SetProperty(m => m.CRLMTPAM, customer.CRLMTPAM)
                  .SetProperty(m => m.CURNCYID, customer.CURNCYID)
                  .SetProperty(m => m.RATETPID, customer.RATETPID)
                  .SetProperty(m => m.CUSTDISC, customer.CUSTDISC)
                  .SetProperty(m => m.PRCLEVEL, customer.PRCLEVEL)
                  .SetProperty(m => m.MINPYTYP, customer.MINPYTYP)
                  .SetProperty(m => m.MINPYDLR, customer.MINPYDLR)
                  .SetProperty(m => m.MINPYPCT, customer.MINPYPCT)
                  .SetProperty(m => m.FNCHATYP, customer.FNCHATYP)
                  .SetProperty(m => m.FNCHPCNT, customer.FNCHPCNT)
                  .SetProperty(m => m.FINCHDLR, customer.FINCHDLR)
                  .SetProperty(m => m.MXWOFTYP, customer.MXWOFTYP)
                  .SetProperty(m => m.MXWROFAM, customer.MXWROFAM)
                  .SetProperty(m => m.COMMENT1, customer.COMMENT1)
                  .SetProperty(m => m.COMMENT2, customer.COMMENT2)
                  .SetProperty(m => m.USERDEF1, customer.USERDEF1)
                  .SetProperty(m => m.USERDEF2, customer.USERDEF2)
                  .SetProperty(m => m.TAXEXMT1, customer.TAXEXMT1)
                  .SetProperty(m => m.TAXEXMT2, customer.TAXEXMT2)
                  .SetProperty(m => m.TXRGNNUM, customer.TXRGNNUM)
                  .SetProperty(m => m.BALNCTYP, customer.BALNCTYP)
                  .SetProperty(m => m.STMTCYCL, customer.STMTCYCL)
                  .SetProperty(m => m.BANKNAME, customer.BANKNAME)
                  .SetProperty(m => m.BNKBRNCH, customer.BNKBRNCH)
                  .SetProperty(m => m.SALSTERR, customer.SALSTERR)
                  .SetProperty(m => m.DEFCACTY, customer.DEFCACTY)
                  .SetProperty(m => m.RMCSHACC, customer.RMCSHACC)
                  .SetProperty(m => m.RMARACC, customer.RMARACC)
                  .SetProperty(m => m.RMSLSACC, customer.RMSLSACC)
                  .SetProperty(m => m.RMIVACC, customer.RMIVACC)
                  .SetProperty(m => m.RMCOSACC, customer.RMCOSACC)
                  .SetProperty(m => m.RMTAKACC, customer.RMTAKACC)
                  .SetProperty(m => m.RMAVACC, customer.RMAVACC)
                  .SetProperty(m => m.RMFCGACC, customer.RMFCGACC)
                  .SetProperty(m => m.RMWRACC, customer.RMWRACC)
                  .SetProperty(m => m.RMSORACC, customer.RMSORACC)
                  .SetProperty(m => m.FRSTINDT, customer.FRSTINDT)
                  .SetProperty(m => m.INACTIVE, customer.INACTIVE)
                  .SetProperty(m => m.HOLD, customer.HOLD)
                  .SetProperty(m => m.CRCARDID, customer.CRCARDID)
                  .SetProperty(m => m.CRCRDNUM, customer.CRCRDNUM)
                  .SetProperty(m => m.CCRDXPDT, customer.CCRDXPDT)
                  .SetProperty(m => m.KPDSTHST, customer.KPDSTHST)
                  .SetProperty(m => m.KPCALHST, customer.KPCALHST)
                  .SetProperty(m => m.KPERHIST, customer.KPERHIST)
                  .SetProperty(m => m.KPTRXHST, customer.KPTRXHST)
                  .SetProperty(m => m.NOTEINDX, customer.NOTEINDX)
                  .SetProperty(m => m.CREATDDT, customer.CREATDDT)
                  .SetProperty(m => m.MODIFDT, customer.MODIFDT)
                  .SetProperty(m => m.Revalue_Customer, customer.Revalue_Customer)
                  .SetProperty(m => m.Post_Results_To, customer.Post_Results_To)
                  .SetProperty(m => m.FINCHID, customer.FINCHID)
                  .SetProperty(m => m.GOVCRPID, customer.GOVCRPID)
                  .SetProperty(m => m.GOVINDID, customer.GOVINDID)
                  .SetProperty(m => m.DISGRPER, customer.DISGRPER)
                  .SetProperty(m => m.DUEGRPER, customer.DUEGRPER)
                  .SetProperty(m => m.DOCFMTID, customer.DOCFMTID)
                  .SetProperty(m => m.Send_Email_Statements, customer.Send_Email_Statements)
                  .SetProperty(m => m.USERLANG, customer.USERLANG)
                  .SetProperty(m => m.GPSFOINTEGRATIONID, customer.GPSFOINTEGRATIONID)
                  .SetProperty(m => m.INTEGRATIONSOURCE, customer.INTEGRATIONSOURCE)
                  .SetProperty(m => m.INTEGRATIONID, customer.INTEGRATIONID)
                  .SetProperty(m => m.ORDERFULFILLDEFAULT, customer.ORDERFULFILLDEFAULT)
                  .SetProperty(m => m.CUSTPRIORITY, customer.CUSTPRIORITY)
                  .SetProperty(m => m.CCode, customer.CCode)
                  .SetProperty(m => m.DECLID, customer.DECLID)
                  .SetProperty(m => m.RMOvrpymtWrtoffAcctIdx, customer.RMOvrpymtWrtoffAcctIdx)
                  .SetProperty(m => m.SHIPCOMPLETE, customer.SHIPCOMPLETE)
                  .SetProperty(m => m.CBVAT, customer.CBVAT)
                  .SetProperty(m => m.INCLUDEINDP, customer.INCLUDEINDP)
                  .SetProperty(m => m.DEX_ROW_TS, customer.DEX_ROW_TS)
                  .SetProperty(m => m.DEX_ROW_ID, customer.DEX_ROW_ID)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateCustomer").AllowAnonymous()
        .WithOpenApi();

        group.MapPost("/", async (Customer customer, WaterBillingMobileAppAPiContext db) =>
        {
            db.Customer.Add(customer);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Customer/{customer.CUSTMBR}",customer);
        })
        .WithName("CreateCustomer").AllowAnonymous()
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (string id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Customer
                .Where(model => model.CUSTMBR == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteCustomer").AllowAnonymous()
        .WithOpenApi();
    }
	public static void MapDeviceEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Device").WithTags(nameof(Device));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Device.ToListAsync();
        })
        .WithName("GetAllDevices").AllowAnonymous()
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Device>, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Device.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Device model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetDeviceById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Device device, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Device
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.Id, device.Id)
                  .SetProperty(m => m.SerialNumber, device.SerialNumber)
                  .SetProperty(m => m.UserId, device.UserId)
                  .SetProperty(m => m.LastActive, device.LastActive)
                  .SetProperty(m => m.Active, device.Active)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateDevice")
        .WithOpenApi();

        group.MapPost("/", async (Device device, WaterBillingMobileAppAPiContext db) =>
        {
            db.Device.Add(device);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Device/{device.Id}",device);
        })
        .WithName("CreateDevice")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Device
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteDevice")
        .WithOpenApi();
    }
	public static void MapMonthEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Month").WithTags(nameof(Month));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Month.ToListAsync();
        })
        .WithName("GetAllMonths").AllowAnonymous()
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Month>, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Month.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Month model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetMonthById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Month month, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Month
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.Id, month.Id)
                  .SetProperty(m => m.MonthName, month.MonthName)
                  .SetProperty(m => m.Year, month.Year)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateMonth")
        .WithOpenApi();

        group.MapPost("/", async (Month month, WaterBillingMobileAppAPiContext db) =>
        {
            db.Month.Add(month);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Month/{month.Id}",month);
        })
        .WithName("CreateMonth").AllowAnonymous()
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Month
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteMonth").AllowAnonymous()
        .WithOpenApi();
    }
	public static void MapReadingEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Reading").WithTags(nameof(Reading));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Reading.ToListAsync();
        })
        .WithName("GetAllReadings").AllowAnonymous()
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Reading>, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Reading.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Reading model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetReadingById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Reading reading, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Reading
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.Id, reading.Id)
                  .SetProperty(m => m.WaterReadingExportID, reading.WaterReadingExportID)
                  .SetProperty(m => m.CUSTOMER_NUMBER, reading.CUSTOMER_NUMBER)
                  .SetProperty(m => m.CUSTOMER_NAME, reading.CUSTOMER_NAME)
                  .SetProperty(m => m.AREA, reading.AREA)
                  .SetProperty(m => m.ERF_NUMBER, reading.ERF_NUMBER)
                  .SetProperty(m => m.METER_NUMBER, reading.METER_NUMBER)
                  .SetProperty(m => m.CURRENT_READING, reading.CURRENT_READING)
                  .SetProperty(m => m.PREVIOUS_READING, reading.PREVIOUS_READING)
                  .SetProperty(m => m.MonthID, reading.MonthID)
                  .SetProperty(m => m.Year, reading.Year)
                  .SetProperty(m => m.CUSTOMER_ZONING, reading.CUSTOMER_ZONING)
                  .SetProperty(m => m.RouteNumber, reading.RouteNumber)
                  .SetProperty(m => m.Comment, reading.Comment)
                  .SetProperty(m => m.WaterReadingTypeId, reading.WaterReadingTypeId)
                  .SetProperty(m => m.Meter_Reader, reading.Meter_Reader)
                  .SetProperty(m => m.READING_DATE, reading.READING_DATE)
                  .SetProperty(m => m.ReadingTaken, reading.ReadingTaken)
                  .SetProperty(m => m.ReadingSync, reading.ReadingSync)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateReading").AllowAnonymous()
        .WithOpenApi();

        group.MapPost("/", async (Reading reading, WaterBillingMobileAppAPiContext db) =>
        {
            db.Reading.Add(reading);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Reading/{reading.Id}",reading);
        })
        .WithName("CreateReading").AllowAnonymous()
        .WithOpenApi();

        group.MapPost("/list", async (List<Reading> readings, WaterBillingMobileAppAPiContext db) =>
        {
            db.Reading.AddRange(readings);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Reading/list", readings);
        })
       .WithName("CreateReadingList").AllowAnonymous()
       .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Reading
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteReading").AllowAnonymous()
        .WithOpenApi();
    }
	public static void MapReadingExportEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/ReadingExport").WithTags(nameof(ReadingExport));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.ReadingExport.ToListAsync();
        })
        .WithName("GetAllReadingExports").AllowAnonymous()
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<ReadingExport>, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.ReadingExport.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is ReadingExport model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetReadingExportById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, ReadingExport readingExport, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.ReadingExport
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.Id, readingExport.Id)
                  .SetProperty(m => m.MonthID, readingExport.MonthID)
                  .SetProperty(m => m.Year, readingExport.Year)
                  .SetProperty(m => m.RM00303Id, readingExport.RM00303Id)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateReadingExport")
        .WithOpenApi();

        group.MapPost("/", async (ReadingExport readingExport, WaterBillingMobileAppAPiContext db) =>
        {
            db.ReadingExport.Add(readingExport);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/ReadingExport/{readingExport.Id}",readingExport);
        })
        .WithName("CreateReadingExport").AllowAnonymous()
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.ReadingExport
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteReadingExport")
        .WithOpenApi();
    }
	public static void MapRM00303Endpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/RM00303").WithTags(nameof(RM00303));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.RM00303.ToListAsync();
        })
        .WithName("GetAllRM00303s")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<RM00303>, NotFound>> (string id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.RM00303.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is RM00303 model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetRM00303ById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (string id, RM00303 rM00303, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.RM00303
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.Id, rM00303.Id)
                  .SetProperty(m => m.SLTERDSC, rM00303.SLTERDSC)
                  .SetProperty(m => m.INACTIVE, rM00303.INACTIVE)
                  .SetProperty(m => m.SLPRSNID, rM00303.SLPRSNID)
                  .SetProperty(m => m.STMGRFNM, rM00303.STMGRFNM)
                  .SetProperty(m => m.STMGRMNM, rM00303.STMGRMNM)
                  .SetProperty(m => m.STMGRLNM, rM00303.STMGRLNM)
                  .SetProperty(m => m.COUNTRY, rM00303.COUNTRY)
                  .SetProperty(m => m.COSTTODT, rM00303.COSTTODT)
                  .SetProperty(m => m.TTLCOMTD, rM00303.TTLCOMTD)
                  .SetProperty(m => m.TTLCOMLY, rM00303.TTLCOMLY)
                  .SetProperty(m => m.NCOMSLYR, rM00303.NCOMSLYR)
                  .SetProperty(m => m.COMSLLYR, rM00303.COMSLLYR)
                  .SetProperty(m => m.CSTLSTYR, rM00303.CSTLSTYR)
                  .SetProperty(m => m.COMSLTDT, rM00303.COMSLTDT)
                  .SetProperty(m => m.NCOMSLTD, rM00303.NCOMSLTD)
                  .SetProperty(m => m.KPCALHST, rM00303.KPCALHST)
                  .SetProperty(m => m.KPERHIST, rM00303.KPERHIST)
                  .SetProperty(m => m.NOTEINDX, rM00303.NOTEINDX)
                  .SetProperty(m => m.MODIFDT, rM00303.MODIFDT)
                  .SetProperty(m => m.CREATDDT, rM00303.CREATDDT)
                  .SetProperty(m => m.DEX_ROW_TS, rM00303.DEX_ROW_TS)
                  .SetProperty(m => m.DEX_ROW_ID, rM00303.DEX_ROW_ID)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateRM00303")
        .WithOpenApi();

        group.MapPost("/", async (RM00303 rM00303, WaterBillingMobileAppAPiContext db) =>
        {
            db.RM00303.Add(rM00303);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/RM00303/{rM00303.Id}",rM00303);
        })
        .WithName("CreateRM00303")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (string id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.RM00303
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteRM00303")
        .WithOpenApi();
    }
	public static void MapUserEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/User").WithTags(nameof(User));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.User.ToListAsync();
        })
        .WithName("GetAllUsers")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<User>, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.User.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is User model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetUserById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, User user, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.User
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.Id, user.Id)
                  .SetProperty(m => m.Name, user.Name)
                  .SetProperty(m => m.Email, user.Email)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateUser")
        .WithOpenApi();

        group.MapPost("/", async (User user, WaterBillingMobileAppAPiContext db) =>
        {
            db.User.Add(user);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/User/{user.Id}",user);
        })
        .WithName("CreateUser")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.User
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteUser")
        .WithOpenApi();
    }
}
