using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class LichSu
    {
        public string Id { get; set; }
        public CongViec MaCongViec_Fk{ get; set; }
        public string MaCongViec { get; set; }
        public string TieuDe { get; set; }
        public string NoDung { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public bool IsDelete { get; set; }

    }
}
