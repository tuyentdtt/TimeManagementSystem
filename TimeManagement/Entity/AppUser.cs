using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TimeManagement.Entity
{
    public class AppUser :IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DoB { set; get; }

        public PhongBan PhongBan_Fk { get; set; }
        public string MaPhong { set; get; }






    }
}
