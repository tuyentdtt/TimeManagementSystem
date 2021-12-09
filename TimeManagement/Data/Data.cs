using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeManagement.Entity;

namespace TimeManagement.Data
{
    public static class Data
    {
        public static void Seed(this ModelBuilder builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>().HasData(
               new AppUser()
               {
                   Id = Guid.NewGuid().ToString(),
                   Email = "Tuyen1@gmail.com",
                   PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                   EmailConfirmed = true
               },
               new AppUser()
               {
                   Id = Guid.NewGuid().ToString(),
                   Email = "admin@gmail.com",
                   PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                   EmailConfirmed = true
               },
               new AppUser()
               {
                   Id = Guid.NewGuid().ToString(),
                   Email = "staf@gmail.com",
                   PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                   EmailConfirmed = true
               });


            builder.Entity<AppRole>().HasData(
               new AppRole()
               {
                   Id = Guid.NewGuid().ToString(),
                   Name = "Admin",
                   NormalizedName ="ADMIN"
               },
               new AppRole()
               {
                   Id = Guid.NewGuid().ToString(),
                   Name = "Staff",
                   NormalizedName = "STAFF"
               },
               new AppRole()
               {
                   Id = Guid.NewGuid().ToString(),
                   Name = "Management",
                   NormalizedName = "MANAGEMENT"
               });





        }    
                
               
    }   
}
