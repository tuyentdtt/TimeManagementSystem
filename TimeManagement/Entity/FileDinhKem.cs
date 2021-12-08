using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class FileDinhKem
    {
        public string Id { get; set; }
        public string MaFile { get; set; }
        public string TenFile { get; set; }
        public CongViec MaCongViec_Fk { get; set; }
        public string MaCongViec { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string DuongDanFile { get; set; }
        public bool IsDelete { get; set; }

    }
}
