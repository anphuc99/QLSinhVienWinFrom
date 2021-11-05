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
    public class QLGiangVienController : ControllerBase
    {
        public List<p_findGiangVien_Result> dsGiangVien()
        {
            db = new QLSinhVienEntities();
            return db.p_findGiangVien("").ToList();
        }
        public void AddGiangVien(GiangVien giangVien)
        {
            try
            {
                db = new QLSinhVienEntities();
                db.GiangViens.Add(giangVien);
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException Ex = ex.GetBaseException() as SqlException;
                if (Ex?.Number == 2627)
                {
                    throw new InvalidOperationException("Mã Giảng Viên Đã Tồn Tại!");
                }
                else
                {
                    throw;
                }
            }
        }

        public void RemoveGiangVien(string maGiangVien)
        {
            try
            {
                db = new QLSinhVienEntities();
                GiangVien giangVien = db.GiangViens.Find(maGiangVien);
                db.GiangViens.Remove(giangVien);
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
        public void UpdateGiangVien(p_findGiangVien_Result giangVien)
        {
            try
            {
                db = new QLSinhVienEntities();
                GiangVien giangVien1 = db.GiangViens.Find(giangVien.MaGV);
                if (giangVien1 == null)
                {
                    throw new InvalidOperationException("Mã Giảng Viên Không Tồn Tại!");
                }
                giangVien1.TenGV = giangVien.TenGV;
                giangVien1.SDT = giangVien.SDT;
                giangVien1.DiaChi = giangVien.DiaChi;
                db.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                SqlException Ex = e.GetBaseException() as SqlException;
                if (Ex?.Number == 2627)
                {
                    throw new InvalidOperationException("Mã Giảng Viên Đã Tồn Tại!");
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

        public List<p_findGiangVien_Result> findGiangVien(string find)
        {
            db = new QLSinhVienEntities();
            return db.p_findGiangVien(find).ToList();
        }
    }
}
