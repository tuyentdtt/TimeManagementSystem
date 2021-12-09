using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class CongViec
    {
        public string Id { get; set; }
        public string MaCongViec { get; set; }
        public TrangThai TrangThai_Fk { get; set; }
        public string MaTrangThai { get; set; }
        public DuAn MaDuAn_Fk { get; set; }
        public string MaDuAn { get; set; }
        public PhongBan MaPhongn_Fk { get; set; }
        public string MaPhong { get; set; }
        public string NguoiThucHien { get; set; }
        public int SoGioThucHien { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool IsDelete { get; set; }
        public bool IsView { get; set; }
        public DateTime NgayKetThucCV { get; set; }



        public List<CongViecSub> CongViecSub { get; set; }

        public List<Comment> Comment { get; set; }

        public List<LichSu> LichSu { get; set; }

        public List<FileDinhKem> FileDinhKem { get; set; }

        public List<Lich> Lich { get; set; }

    }
}
