using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class CongViecSub
    {
        public string Id { get; set; }
        public CongViec MaCongViec_Fk { get; set; }
        public string MaCongViec { get; set; }
        public string MaCongViec_Sub { get; set; }
        public string MaTrangThai { get; set; }
        public string TenCongViec_Sub { get; set; }
        public string MoTa { get; set; }
        public string NguoiThucHien { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int SoGioThucHien { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool IsDelete { get; set; }
        public bool IsView { get; set; }
        public DateTime NgayKetThucCV { get; set; }


    }
}
