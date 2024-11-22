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
        public DbSet<WaterBillingMobileAppAPi.Models.AspNetUserSites> AspNetUserSites { get; set; } = default!;
        public DbSet<WaterBillingMobileAppAPi.Models.BS_DebtorSMS> BS_DebtorSMS { get; set; } = default!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole
                    {
                        Id = "0cdbaf8d-4c5e-4b52-b997-4268d72f28a4",
                        Name = "Administrator",
                        NormalizedName = "ADMINISTRATOR"
                    },
                    new IdentityRole
                    {
                        Id = "523ee3a2-973f-4f6d-8d79-ac5e4dabb2f5",
                        Name = "User",
                        NormalizedName = "USER"
                    }
                );

            var hasher = new PasswordHasher<IdentityUser>();

            //modelBuilder.Entity<IdentityUser>().HasData(
            //        new IdentityUser
            //        {
            //            Id = "408aa945-3d84-4421-8342-7269ec64d949",
            //            Email = "admin@localhost.com",
            //            NormalizedEmail = "ADMIN@LOCALHOST.COM",
            //            NormalizedUserName = "ADMIN@LOCALHOST.COM",
            //            UserName = "admin@localhost.com",
            //            PasswordHash = hasher.HashPassword(null, "P@ssword1"),
            //            EmailConfirmed = true
            //        },
            //        new IdentityUser
            //        {
            //            Id = "3f4631bd-f907-4409-b416-ba356312e659",
            //            Email = "user@localhost.com",
            //            NormalizedEmail = "USER@LOCALHOST.COM",
            //            NormalizedUserName = "USER@LOCALHOST.COM",
            //            UserName = "user@localhost.com",
            //            PasswordHash = hasher.HashPassword(null, "P@ssword1"),
            //            EmailConfirmed = true
            //        }
            //    );

            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            //         new IdentityUserRole<string>
            //         {
            //             RoleId = "d1b5952a-2162-46c7-b29e-1a2a68922c14",
            //             UserId = "408aa945-3d84-4421-8342-7269ec64d949",
            //         },
            //        new IdentityUserRole<string>
            //        {
            //            RoleId = "42358d3e-3c22-45e1-be81-6caa7ba865ef",
            //            UserId = "3f4631bd-f907-4409-b416-ba356312e659",
            //        }
            //    );

            modelBuilder.Entity<IdentityUser>().HasData(
        new IdentityUser
        {
            Id = "9a5f05c4-3bff-44ec-8629-573ec5310ac4",
            Email = "user@onesi.local",
            NormalizedEmail = "USER@ONESI.LOCAL",
            NormalizedUserName = "USER@ONESI.LOCAL",
            UserName = "user@onesi.local",
            PasswordHash = hasher.HashPassword(null, "P@ssword1"),
            EmailConfirmed = true
        },
        new IdentityUser
        {
            Id = "a8a151c3-2800-4b6b-9799-bef0e48766d1",
            Email = "user@okalongo.local",
            NormalizedEmail = "USER@OKALONGO.LOCAL",
            NormalizedUserName = "USER@OKALONGO.LOCAL",
            UserName = "user@okalongo.local",
            PasswordHash = hasher.HashPassword(null, "P@ssword1"),
            EmailConfirmed = true
        },
                        new IdentityUser
                        {
                            Id = "95535cdc-2502-4eff-b53b-f556107afefd",
                            Email = "user@ogongo.local",
                            NormalizedEmail = "USER@OGONGO.LOCAL",
                            NormalizedUserName = "USER@OGONGO.LOCAL",
                            UserName = "user@ogongo.local",
                            PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                            EmailConfirmed = true
                        }


    );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                     new IdentityUserRole<string>
                     {
                         RoleId = "523ee3a2-973f-4f6d-8d79-ac5e4dabb2f5",
                         UserId = "9a5f05c4-3bff-44ec-8629-573ec5310ac4",
                     },
                    new IdentityUserRole<string>
                    {
                        RoleId = "523ee3a2-973f-4f6d-8d79-ac5e4dabb2f5",
                        UserId = "a8a151c3-2800-4b6b-9799-bef0e48766d1",
                    },
                                        new IdentityUserRole<string>
                                        {
                                            RoleId = "523ee3a2-973f-4f6d-8d79-ac5e4dabb2f5",
                                            UserId = "95535cdc-2502-4eff-b53b-f556107afefd",
                                        }
                );
        }



        public DbSet<WaterBillingMobileAppAPi.Models.BillingLocation> BillingLocation { get; set; } = default!;
    }
}