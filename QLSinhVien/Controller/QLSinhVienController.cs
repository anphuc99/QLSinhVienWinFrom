using QLSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.Controller
{
    public class QLSinhVienController : ControllerBase
    {
        public List<SinhVien> getdsSinhVien()
        {
            db = new QLSinhVienEntities();
            return db.Database.SqlQuery<SinhVien>("p_findSinhVien ''").ToList();
        }

        public void AddSinhVien(SinhVien sinhVien)
        {
            try
            {
                db = new QLSinhVienEntities();
                db.SinhViens.Add(sinhVien);
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException Ex = ex.GetBaseException() as SqlException;
                if (Ex?.Number == 2627)
                {
                    throw new InvalidOperationException("Mã Sinh Viên Đã Tồn Tại!");
                }
                else
                {
                    throw Ex;
                }
            }
        }

        public void RemoveSinhVien(string maSinhVien)
        {
            try
            {
                db = new QLSinhVienEntities();
                SinhVien sinhVien = db.SinhViens.Find(maSinhVien);
                db.SinhViens.Remove(sinhVien);
                db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException Ex = e.GetBaseException() as SqlException;
                throw Ex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void UpdateSinhVien(SinhVien sinhVien)
        {
            try
            {
                db = new QLSinhVienEntities();
                SinhVien sinhVien1 = db.SinhViens.Find(sinhVien.MaSV);
                if (sinhVien1 == null)
                {
                    throw new InvalidOperationException("Mã Sinh Viên Không Tồn Tại!");
                }
                sinhVien1.HoTenSV = sinhVien.HoTenSV;
                sinhVien1.NgaySinh = sinhVien.NgaySinh;
                sinhVien1.SDT = sinhVien.SDT;
                sinhVien1.DiaChi = sinhVien.DiaChi;
                sinhVien1.GioiTinh = sinhVien.GioiTinh;
                db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException Ex = e.GetBaseException() as SqlException;
                if (Ex?.Number == 2627)
                {
                    throw new InvalidOperationException("Mã Sinh Viên Đã Tồn Tại!");
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

        public List<SinhVien> findSinhVien(string find)
        {
            db = new QLSinhVienEntities();
            return db.Database.SqlQuery<SinhVien>($"p_findSinhVien N'{find}'").ToList();
        }

        public List<SinhVien> findTheoLop(string lop)
        {
            db = new QLSinhVienEntities();
            return db.SinhViens.Where(x => x.Lop == lop).ToList();
        }

        public List<SinhVien> findTheoKhoa(string khoa)
        {
            db = new QLSinhVienEntities();
            return db.Database.SqlQuery<SinhVien>($"p_findTheoKhoa '{khoa}'").ToList();
        }
    }
}
