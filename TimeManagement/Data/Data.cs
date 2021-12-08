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

            builder.Entity<AppUser>().HasData(
               new AppUser()
               {
                   Id = Guid.NewGuid().ToString(),
                   FirstName = "Tuyen"
               });


        }    
                
               
    }   
}
