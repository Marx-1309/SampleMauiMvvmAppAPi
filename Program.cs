using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WaterBillingMobileAppAPi;
using WaterBillingMobileAppAPi.Data;
using WaterBillingMobileAppAPi.Models;

namespace WaterBillingMobileAppAP
{

    public class Program
    {
        public WaterBillingMobileAppAPiContext context;

        public Program(WaterBillingMobileAppAPiContext _context)
        {
            context = _context;
        }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", a => a.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            });

            builder.Services.AddIdentityCore<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<WaterBillingMobileAppAPiContext>();

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
                    ValidateAudience = true,
                    ValidAudience = builder.Configuration["JwtSettings:Audience"],
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
                };
            });

            builder.Services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                .RequireAuthenticatedUser()
                .Build();
            });

            builder.Host.UseSerilog((ctx, lc) =>
                lc.WriteTo.Console()
                .ReadFrom.Configuration(ctx.Configuration));

            builder.Services.AddDbContext<WaterBillingMobileAppAPiContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("WaterBillingMobileAppAPiContext") ?? throw new InvalidOperationException("Connection string 'WaterBillingMobileAppAPiContext' not found.")));

            // Add services to the container.
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            //app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors("AllowAll");

            app.MapCustomerEndpoints();
            app.MapDeviceEndpoints();
            app.MapMonthEndpoints();
            app.MapReadingExportEndpoints();
            app.MapRM00303Endpoints();
            app.MapUserEndpoints();
            app.MapLoginEndpoints();

            app.MapReadingEndpoints();
            app.MapBillingLocationEndpoints();
            //var dbContext = app.Services.GetRequiredService<WaterBillingMobileAppAPiContext>();
            //AllApiEndpoints.Initialize(dbContext);
            app.Run();
        }

        // Supporting DTO classes
        //internal class LoginDto
        //{
        //    public string Username { get; set; }
        //    public string Password { get; set; }
        //}

        //internal class AuthResponseDto
        //{
        //    public string UserId { get; set; }
        //    public string Username { get; set; }
        //    public string Site { get; set; }
        //    public string Token { get; set; }
        //}
    }
}
