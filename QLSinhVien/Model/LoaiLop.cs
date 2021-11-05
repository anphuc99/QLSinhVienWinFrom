using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.Model
{
    public class LoaiLop
    {
        public int MaLoai {get;set;}
        public string TenLoai { get; set; }
        public static List<LoaiLop> getLoaiLop()
        {
            List<LoaiLop> loaiLops = new List<LoaiLop>();
            loaiLops.Add(new LoaiLop() { MaLoai = 1, TenLoai = "Lý thuyết" });
            loaiLops.Add(new LoaiLop() { MaLoai = 2, TenLoai = "Thực hành" });
            loaiLops.Add(new LoaiLop() { MaLoai = 3, TenLoai = "Đồ án" });
            loaiLops.Add(new LoaiLop() { MaLoai = 4, TenLoai = "Khóa luận" });
            return loaiLops;
        }
    }
}
