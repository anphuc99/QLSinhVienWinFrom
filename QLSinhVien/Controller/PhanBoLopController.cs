using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSinhVien.Model;

namespace QLSinhVien.Controller
{
    public class PhanBoLopController:ControllerBase
    {
        public string[] phongHoc { get; set; }
        public PhanBoLopController()
        {
            phongHoc = new string[] {"L.101", "L.102", "L.103", "L.104", "L.105", "L.106", "L.107", "L.108", "L.109", "L.201", "L.202", "L.203", "L.204", "L.205", "L.206", "L.207", "L.208", "L.209", "L.301", "L.302", "L.303", "L.304", "L.305", "L.306", "L.307", "L.308", "L.309", "L.401", "L.402", "L.403", "L.404", "L.405", "L.406", "L.407", "L.408", "L.409", "L.501", "L.502", "L.503", "L.504", "L.505", "L.506", "L.507", "L.508", "L.509", "L.601", "L.602", "L.603", "L.604", "L.605", "L.606", "L.607", "L.608", "L.609", "L.701", "L.702", "L.703", "L.704", "L.705", "L.706", "L.707", "L.708", "L.709", "L.801", "L.802", "L.803", "L.804", "L.805", "L.806", "L.807", "L.808", "L.809", "L.901", "L.902", "L.903", "L.904", "L.905", "L.906", "L.907", "L.908", "L.909"};
        }
        public List<vLopHocPhan> getLopHoc(int hocKy, int namHoc)
        {
            db = new QLSinhVienEntities();
            return db.Database.SqlQuery<vLopHocPhan>($"select * from vLopHocPhan where HocKy = {hocKy} and year(NgayBD) = '{namHoc}'").ToList();
        }
        public List<SinhVien> getdsSinhVien(string maLopHP)
        {
            db = new QLSinhVienEntities();
            return db.Database.SqlQuery<SinhVien>($"p_svLopHocPhan '{maLopHP}'").ToList();
        }

        public string[] getPhongHoc(int page)
        {
            return phongHoc.Skip((page - 1) * 45).Take(45).ToArray();
        }

        public void AddLopHocPhan(LopHocPhan lopHocPhan)
        {
            try
            {
                db = new QLSinhVienEntities();
                db.LopHocPhans.Add(lopHocPhan);
                db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException Ex = e.GetBaseException() as SqlException;
                if (Ex?.Number == 2627)
                {
                    throw new InvalidOperationException("Mã học phần đã tồn tại!");
                }
                else
                {
                    throw Ex;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateLopHocPhan(LopHocPhan lopHocPhan)
        {
            try
            {
                db = new QLSinhVienEntities();
                LopHocPhan lopHocPhan1 = db.LopHocPhans.Find(lopHocPhan.MaLopHocPhan);
                if (lopHocPhan1 == null)
                    throw new InvalidOperationException("Mã lớp học phần không tồn tại");
                lopHocPhan1.TenLopHoc = lopHocPhan.TenLopHoc;
                lopHocPhan1.Thu = lopHocPhan.Thu;
                lopHocPhan1.TietBD = lopHocPhan.TietBD;
                lopHocPhan1.TietKT = lopHocPhan.TietKT;
                lopHocPhan1.HocKy = lopHocPhan.HocKy;
                lopHocPhan1.LoaiLop = lopHocPhan.LoaiLop;
                lopHocPhan1.MaGV = lopHocPhan.MaGV;
                lopHocPhan1.MaMon = lopHocPhan.MaMon;
                lopHocPhan1.NgayBD = lopHocPhan.NgayBD;
                lopHocPhan1.NgayKT = lopHocPhan.NgayKT;
                lopHocPhan1.PhongHoc = lopHocPhan.PhongHoc;
                db.SaveChanges();
            }catch(DbUpdateException e)
            {
                SqlException Ex = e.GetBaseException() as SqlException;
                throw Ex;
            }
        }

        public void DeleteLopHocPhan(string maHP)
        {
            try
            {
                db = new QLSinhVienEntities();
                LopHocPhan lopHocPhan = db.LopHocPhans.Find(maHP);
                db.LopHocPhans.Remove(lopHocPhan);
                db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException Ex = e.GetBaseException() as SqlException;
                throw Ex;
            }
        }
    }
}
