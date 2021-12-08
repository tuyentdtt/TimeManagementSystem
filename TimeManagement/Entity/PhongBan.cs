using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class PhongBan
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }

        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public bool IsDelete { get; set; }


        public List<CongViec> CongViec { get; set; }
        public List<AppUser> AppUser { get; set; }
    }
}
