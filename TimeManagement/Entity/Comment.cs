using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class Comment
    {
        public string Id { get; set; }
        public CongViec MaCongViec_Fk { get; set; }
        public string MaCongViec { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string MoTap { get; set; }
        public bool IsDelete { get; set; }
        public bool IsModifile { get; set; }

    }
}
