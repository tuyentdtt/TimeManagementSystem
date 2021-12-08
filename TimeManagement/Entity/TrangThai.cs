using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeManagement.Entity
{
    public class TrangThai
    {
        public string MaTrangThai { get; set; }
        public string TenTrangThai { get; set; }
        public string MoTa { get; set; }
        public bool IsDelete { get; set; }


        public List<CongViec> CongViec { get; set; }
    }
}
