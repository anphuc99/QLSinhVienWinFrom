using QLSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.Controller
{
    public class QLDiemController : ControllerBase
    {
        public List<vDiemTheoSV> dsDiemTheoSV()
        {
            db = new QLSinhVienEntities();
            return db.vDiemTheoSVs.ToList();
        }
        public List<vDiemTheoMon> dsDiemTheoMon()
        {
            db = new QLSinhVienEntities();
            return db.vDiemTheoMons.ToList();
        }

        public List<vDiemTheoMon> findTheoMon(string find)
        {
            db = new QLSinhVienEntities();
            string likestr = $"%{find}%";
            return db.vDiemTheoMons.Where(x => DbFunctions.Like(x.MaMon + "", likestr) || DbFunctions.Like(x.TenMon, likestr)).ToList();
        }
        public List<vDiemTheoSV> findTheoSV(string find)
        {
            db = new QLSinhVienEntities();
            string likestr = $"%{find}%";
            return db.vDiemTheoSVs.Where(x => DbFunctions.Like(x.MaSV + "", likestr) || DbFunctions.Like(x.HoTenSV, likestr)).ToList();
        }

        public void soNguoiDau(out string dau, out int tyLe)
        {
            db = new QLSinhVienEntities();
            p_DauRot_Result p_DauRot = db.p_DauRot().First();
            dau = p_DauRot.soLuongDau + "/" + p_DauRot.tongSo;
            tyLe = p_DauRot.tyLe??0;
        }
        public void chiTietDiemSV(string maSV, out SinhVien sinhVien, out List<vDiem> vDiems)
        {
            db = new QLSinhVienEntities();
            sinhVien = db.SinhViens.Find(maSV);
            vDiems = db.vDiems.Where(x => x.MaSV == maSV).ToList();
        }
        public void chiTietDiemMon(int maSV, out MonHoc monHoc, out List<vDiem> vDiems)
        {
            db = new QLSinhVienEntities();
            monHoc = db.MonHocs.Find(maSV);
            vDiems = db.vDiems.Where(x => x.MaMon == maSV).ToList();
        }
        public void suaDiemSV(vDiem diem)
        {
            try
            {
                db = new QLSinhVienEntities();
                DiemSV diemSV = db.DiemSVs.Where(x => x.MaSV == diem.MaSV && x.MaMon == diem.MaMon).Single();
                if (diemSV == null)
                {
                    throw new InvalidOperationException("Mã sinh viên hoặc mã môn học không tồn tại");
                }
                diemSV.DiemTK = diem.DiemTK;
                diemSV.DiemGK = diem.DiemGK;
                diemSV.DiemCK = diem.DiemCK;
                diemSV.DiemTB = diem.DiemTB;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public List<vDiem> findChiTiet(string find, int loai, string MaSo)
        {
            string likestr = $"%{find}%";
            db = new QLSinhVienEntities();
            if (loai == 1)
                return db.vDiems.Where(x => x.MaSV == MaSo && (DbFunctions.Like(x.MaMon + "", likestr) || DbFunctions.Like(x.TenMon, likestr))).ToList();
            int MaMon = int.Parse(MaSo);
            return db.vDiems.Where(x => x.MaMon == MaMon && (DbFunctions.Like(x.MaSV + "", likestr) || DbFunctions.Like(x.HoTenSV, likestr))).ToList();

        }
    }
}
