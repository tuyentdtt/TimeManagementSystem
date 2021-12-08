using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class DuAn
    {
        public string MaDuAn { get; set; }
        public string TenDuAn { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool IsDelete { get; set; }

        public List<CongViec> CongViec { get; set; }

    }
}
