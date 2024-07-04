using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WaterBillingMobileAppAPi.Models;

namespace WaterBillingMobileAppAPi.Data
{
    public class WaterBillingMobileAppAPiContext : IdentityDbContext
    {
        public WaterBillingMobileAppAPiContext (DbContextOptions<WaterBillingMobileAppAPiContext> options)
            : base(options)
        {
        }



        public DbSet<WaterBillingMobileAppAPi.Models.ReadingExport> ReadingExport { get; set; } = default!;

        public DbSet<WaterBillingMobileAppAPi.Models.User> User { get; set; } = default!;

        public DbSet<WaterBillingMobileAppAPi.Models.Customer> Customer { get; set; } = default!;

        public DbSet<WaterBillingMobileAppAPi.Models.Reading> Reading { get; set; } = default!;


        public DbSet<WaterBillingMobileAppAPi.Models.RM00303> RM00303 { get; set; } = default!;

        public DbSet<WaterBillingMobileAppAPi.Models.Month> Month { get; set; } = default!;

        public DbSet<WaterBillingMobileAppAPi.Models.Device> Device { get; set; } = default!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole
                    {
                        Id = "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                        Name = "Administrator",
                        NormalizedName = "ADMINISTRATOR"
                    },
                    new IdentityRole
                    {
                        Id = "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                        Name = "User",
                        NormalizedName = "USER"
                    }
                );

            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                    new IdentityUser
                    {
                        Id = "408aa945-3d84-4421-8342-7269ec64d949",
                        Email = "admin@localhost.com",
                        NormalizedEmail = "ADMIN@LOCALHOST.COM",
                        NormalizedUserName = "ADMIN@LOCALHOST.COM",
                        UserName = "admin@localhost.com",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    },
                    new IdentityUser
                    {
                        Id = "3f4631bd-f907-4409-b416-ba356312e659",
                        Email = "user@localhost.com",
                        NormalizedEmail = "USER@LOCALHOST.COM",
                        NormalizedUserName = "USER@LOCALHOST.COM",
                        UserName = "user@localhost.com",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                     new IdentityUserRole<string>
                     {
                         RoleId = "d1b5952a-2162-46c7-b29e-1a2a68922c14",
                         UserId = "408aa945-3d84-4421-8342-7269ec64d949",
                     },
                    new IdentityUserRole<string>
                    {
                        RoleId = "42358d3e-3c22-45e1-be81-6caa7ba865ef",
                        UserId = "3f4631bd-f907-4409-b416-ba356312e659",
                    }
                );
        }



        public DbSet<WaterBillingMobileAppAPi.Models.BillingLocation> BillingLocation { get; set; } = default!;
    }
}