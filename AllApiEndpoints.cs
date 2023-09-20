using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using WaterBillingMobileAppAPi.Data;
using WaterBillingMobileAppAPi.Models;
using WaterBillingMobileAppAPi.Mappings.Dto_s;

namespace WaterBillingMobileAppAPi;

public static class AllApiEndpoints
{
    public static void MapCustomerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Customer").WithTags(nameof(CustomerDto));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Customer.ToListAsync();
        })
        .WithName("GetAllCustomers").AllowAnonymous()
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Customer>, NotFound>> (string id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.Customer.AsNoTracking()
                .FirstOrDefaultAsync(model => model.CUSTNMBR == id)
                is Customer model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetCustomerById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (string id, CustomerDto customer, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Customer
                .Where(model => model.CUSTNMBR == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.CUSTNMBR, customer.CUSTMBR)
                  .SetProperty(m => m.CUSTNAME, customer.CUSTNAME)
                  .SetProperty(m => m.CUSTCLAS, customer.CUSTCLAS)
                  .SetProperty(m => m.STATE, customer.STATE)
                  .SetProperty(m => m.ZIP, customer.ZIP)

                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateCustomer").AllowAnonymous()
        .WithOpenApi();

        group.MapPost("/", async (Customer customer, WaterBillingMobileAppAPiContext db) =>
        {
            db.Customer.Add(customer);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Customer/{customer.CUSTNMBR}", customer);
        })
        .WithName("CreateCustomer").AllowAnonymous()
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (string id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Customer
                .Where(model => model.CUSTNMBR == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteCustomer").AllowAnonymous()
        .WithOpenApi();
    }
    public static void MapDeviceEndpoints(this IEndpointRouteBuilder routes)
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
            return TypedResults.Created($"/api/Device/{device.Id}", device);
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
    public static void MapMonthEndpoints(this IEndpointRouteBuilder routes)
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
                .FirstOrDefaultAsync(model => model.MonthID == id)
                is Month model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetMonthById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Month month, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Month
                .Where(model => model.MonthID == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.MonthID, month.MonthID)
                  .SetProperty(m => m.MonthName, month.MonthName)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateMonth")
        .WithOpenApi();

        group.MapPost("/", async (Month month, WaterBillingMobileAppAPiContext db) =>
        {
            db.Month.Add(month);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Month/{month.MonthID}", month);
        })
        .WithName("CreateMonth").AllowAnonymous()
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Month
                .Where(model => model.MonthID == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteMonth").AllowAnonymous()
        .WithOpenApi();
    }

    public static void MapReadingExportEndpoints(this IEndpointRouteBuilder routes)
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
                .FirstOrDefaultAsync(model => model.WaterReadingExportID == id)
                is ReadingExport model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetReadingExportById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, ReadingExport readingExport, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.ReadingExport
                .Where(model => model.WaterReadingExportID == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.WaterReadingExportID, readingExport.WaterReadingExportID)
                  .SetProperty(m => m.MonthID, readingExport.MonthID)
                  .SetProperty(m => m.Year, readingExport.Year)
                  .SetProperty(m => m.SALSTERR, readingExport.SALSTERR)
                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateReadingExport")
        .WithOpenApi();

        group.MapPost("/", async (ReadingExport readingExport, WaterBillingMobileAppAPiContext db) =>
        {
            db.ReadingExport.Add(readingExport);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/ReadingExport/{readingExport.WaterReadingExportID}", readingExport);
        })
        .WithName("CreateReadingExport").AllowAnonymous()
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.ReadingExport
                .Where(model => model.WaterReadingExportID == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteReadingExport")
        .WithOpenApi();
    }
    public static void MapRM00303Endpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/RM00303").WithTags(nameof(RM00303));

        group.MapGet("/", async (WaterBillingMobileAppAPiContext db) =>
        {
            return await db.RM00303.ToListAsync();
        })
        .WithName("GetAllRM00303s").AllowAnonymous()
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<RM00303>, NotFound>> (string id, WaterBillingMobileAppAPiContext db) =>
        {
            return await db.RM00303.AsNoTracking()
                .FirstOrDefaultAsync(model => model.SALSTERR == id)
                is RM00303 model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetRM00303ById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (string id, RM00303 rM00303, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.RM00303
                .Where(model => model.SALSTERR == id)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.SALSTERR, rM00303.SALSTERR)

                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateRM00303").AllowAnonymous()
        .WithOpenApi();

        group.MapPost("/", async (RM00303 rM00303, WaterBillingMobileAppAPiContext db) =>
        {
            db.RM00303.Add(rM00303);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/RM00303/{rM00303.SALSTERR}", rM00303);
        })
        .WithName("CreateRM00303").AllowAnonymous()
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (string id, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.RM00303
                .Where(model => model.SALSTERR == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteRM00303").AllowAnonymous()
        .WithOpenApi();
    }
    public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
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
            return TypedResults.Created($"/api/User/{user.Id}", user);
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
    public static void MapReadingEndpoints(this IEndpointRouteBuilder routes)
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
                .FirstOrDefaultAsync(model => model.WaterReadingExportDataID == id)
                is Reading model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetReadingById").AllowAnonymous()
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (UpdateReadingDto reading, WaterBillingMobileAppAPiContext db) =>
        {
            var affected = await db.Reading
                .Where(model => model.WaterReadingExportDataID == reading.WaterReadingExportDataID)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.CURRENT_READING, reading.CURRENT_READING)
                    .SetProperty(m => m.Comment, reading.Comment)
                    .SetProperty(m => m.METER_READER, reading.METER_READER)

                );

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
     .WithName("UpdateReading").AllowAnonymous()
     .WithOpenApi();


        group.MapPost("/", async (Reading reading, WaterBillingMobileAppAPiContext db) =>
        {
            db.Reading.Add(reading);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Reading/{reading.WaterReadingExportDataID}", reading);
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
                .Where(model => model.WaterReadingExportDataID == id)
                .ExecuteDeleteAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteReading").AllowAnonymous()
        .WithOpenApi();
    }
}