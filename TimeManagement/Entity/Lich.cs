using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class Lich
    {
        public string Id { get; set; }

        public AppUser AppUser_Fk { get; set; }
        public string UserId { get; set; }
        public string Slot { get; set; }

        public CongViec CongViec_Fk { get; set; }
        public string CongViecId { get; set; }




    }
}
