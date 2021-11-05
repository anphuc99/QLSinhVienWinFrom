using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSinhVien.Controller;
using QLSinhVien.Model;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace QLSinhVien
{
    public partial class frm_QLSinhVien : Form
    {
        public QLSinhVienController qLSinhVienController { get; set; }
        private int Index = 0;
        public frm_QLSinhVien()
        {
            InitializeComponent();
        }

        private void frm_QLSinhVien_Load(object sender, EventArgs e)
        {
            QLSinhVienEntities db = new QLSinhVienEntities();
            rd_nam.Checked = true;
            cb_lop.DataSource = (from sv in db.SinhViens group sv by sv.Lop).Select(x => x.Key).ToList();            
            cb_khoa.DataSource = new int[] {17,18,19};
            grid_dsSinhVien.DataSource = qLSinhVienController.getdsSinhVien();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            grid_dsSinhVien.DataSource = qLSinhVienController.findSinhVien(tb_timKiem.Text);
        }
        private void reset()
        {
            tb_HoTen.Text = "";
            tb_maSV.Text = "";
            tb_ngaySinh.Text = "";
            tb_Lop.Text = "";
            rd_nam.Checked = true;
            tb_SDT.Text = "";
            tb_DiaChi.Text = "";
            tb_maSV.Focus();
            grid_dsSinhVien.DataSource = qLSinhVienController.getdsSinhVien();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                bool isBreak = false;
                if (tb_maSV.Text == "")
                {
                    error_MaSV.SetError(tb_maSV, "Mã sinh viên không được để trống");
                    tb_maSV.Focus();
                    isBreak = true;
                }
                if (tb_HoTen.Text == "")
                {
                    error_HoTen.SetError(tb_HoTen, "Họ tên không được để trống");
                    tb_HoTen.Focus();
                    isBreak = true;
                }
                if (tb_Lop.Text == "")
                {
                    error_Lop.SetError(tb_Lop, "Lớp không được để trống");
                    tb_Lop.Focus();
                    isBreak = true;
                }
                if (tb_SDT.Text == "")
                {
                    error_SDT.SetError(tb_SDT, "Số điện thoại không được để trống");
                    tb_SDT.Focus();
                    isBreak = true;
                }
                if (tb_DiaChi.Text == "")
                {
                    error_DiaChi.SetError(tb_DiaChi, "Địa chỉ không được để trống");
                    tb_DiaChi.Focus();
                    isBreak = true;
                }
                if (isBreak) return;
                SinhVien sinhVien = new SinhVien();
                sinhVien.HoTenSV = tb_HoTen.Text;
                sinhVien.MaSV = tb_maSV.Text;
                sinhVien.NgaySinh = Convert.ToDateTime(tb_ngaySinh.Text);
                sinhVien.Lop = tb_Lop.Text;
                sinhVien.GioiTinh = rd_nam.Checked;
                sinhVien.SDT = tb_SDT.Text;
                sinhVien.NgayNhapHoc = DateTime.Now;
                sinhVien.DiaChi = tb_DiaChi.Text;
                qLSinhVienController.AddSinhVien(sinhVien);
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sinh viên này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<SinhVien> sinhViens = grid_dsSinhVien.DataSource as List<SinhVien>;
                    qLSinhVienController.RemoveSinhVien(sinhViens[Index].MaSV);
                    reset();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                       
        }

        private void grid_dsSinhVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        private void grid_dsSinhVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<SinhVien> sinhViens = grid_dsSinhVien.DataSource as List<SinhVien>;
                qLSinhVienController.UpdateSinhVien(sinhViens[Index]);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid_dsSinhVien.DataSource = qLSinhVienController.findTheoLop(cb_lop.Text);
        }

        private void cb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid_dsSinhVien.DataSource = qLSinhVienController.findTheoKhoa(cb_khoa.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_HoTen.Text = "";
            tb_maSV.Text = "";
            tb_ngaySinh.Text = "";
            tb_Lop.Text = "";
            rd_nam.Checked = true;
            tb_SDT.Text = "";
            tb_DiaChi.Text = "";
            tb_maSV.Focus();
        }

        private void rd_nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void xuat_ds_word_Click(object sender, EventArgs e)
        {
            try
            {                
                string pathSource = Path.GetFullPath("./data/xuat_ds_word.docx");
                string gui = Guid.NewGuid().ToString();
                string pathRp = Path.GetFullPath($"./report/{gui}_danh_sach_sv.docx");
                File.Copy(pathSource, pathRp);
                Microsoft.Office.Interop.Word.Application opWord = new Microsoft.Office.Interop.Word.Application();
                Word.Document openFile = opWord.Documents.Open(pathRp);
                try
                {
                    Word.Table table = openFile.Tables[1];
                    List<SinhVien> sinhViens = grid_dsSinhVien.DataSource as List<SinhVien>;
                    for(int i = 2; i < sinhViens.Count; i++)
                    {
                        table.Rows.Add(table.Rows[i]);
                    }
                    for(int i = 1; i <= sinhViens.Count; i++)
                    {
                        table.Cell(i + 1, 1).Range.Text = i + "";
                        table.Cell(i + 1, 2).Range.Text = sinhViens[i-1].MaSV;
                        table.Cell(i + 1, 3).Range.Text = sinhViens[i-1].HoTenSV;
                        table.Cell(i + 1, 4).Range.Text = sinhViens[i-1].Lop;
                        table.Cell(i + 1, 5).Range.Text = sinhViens[i-1].NgaySinh.ToString("dd/MM/yyyy");
                        table.Cell(i + 1, 6).Range.Text = sinhViens[i-1].SDT;
                        table.Cell(i + 1, 7).Range.Text = sinhViens[i-1].DiaChi;
                        table.Cell(i + 1, 8).Range.Text = sinhViens[i-1].NgayNhapHoc.ToString("dd/MM/yyyy");
                        table.Cell(i + 1, 9).Range.Text = sinhViens[i-1].GioiTinh?"Nam":"Nữ";
                    }
                    Hepler.Commons.FindAndReplaceText("{ngay}", DateTime.Now.Day.ToString(), openFile.Range().Find);
                    Hepler.Commons.FindAndReplaceText("{thang}", DateTime.Now.Month.ToString(), openFile.Range().Find);
                    Hepler.Commons.FindAndReplaceText("{nam}", DateTime.Now.Year.ToString(), openFile.Range().Find);
                    openFile.Save();
                    MessageBox.Show("Lưu thành công tại:\n" + pathRp);
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    openFile.Close();
                    opWord.Quit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void xuat_ds_excel_Click(object sender, EventArgs e)
        {
            try
            {
                string pathSource = Path.GetFullPath("./data/xuat_ds_excel.xlsx");
                string gui = Guid.NewGuid().ToString();
                string pathRp = Path.GetFullPath($"./report/{gui}_danh_sach_sv.xlsx");
                File.Copy(pathSource, pathRp);
                Microsoft.Office.Interop.Excel.Application opExcel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(pathRp);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                try
                {
                    Excel.Range xlRange = xlWorksheet.UsedRange;                    
                    List<SinhVien> sinhViens = grid_dsSinhVien.DataSource as List<SinhVien>;
                    for (int i = 1; i <= sinhViens.Count; i++)
                    {
                        xlRange[i + 8, "A"] = i + "";
                        xlRange[i + 8, "B"] = sinhViens[i - 1].MaSV;
                        xlRange[i + 8, "C"] = sinhViens[i - 1].HoTenSV;
                        xlRange[i + 8, "D"] = sinhViens[i - 1].Lop;
                        xlRange[i + 8, "E"] = sinhViens[i - 1].NgaySinh.ToString("dd/MM/yyyy");
                        xlRange[i + 8, "F"] = sinhViens[i - 1].SDT;
                        xlRange[i + 8, "G"] = sinhViens[i - 1].DiaChi;
                        xlRange[i + 8, "H"] = sinhViens[i - 1].NgayNhapHoc.ToString("dd/MM/yyyy");
                        xlRange[i + 8, "I"] = sinhViens[i - 1].GioiTinh ? "Nam" : "Nữ";
                        Excel.Range boder1 = xlRange.Cells[i+8, "A"];
                        Excel.Range boder2 = xlRange.Cells[i+8, "B"];
                        Excel.Range boder3 = xlRange.Cells[i+8, "C"];
                        Excel.Range boder4 = xlRange.Cells[i+8, "D"];
                        Excel.Range boder5 = xlRange.Cells[i+8, "E"];
                        Excel.Range boder6 = xlRange.Cells[i+8, "F"];
                        Excel.Range boder7 = xlRange.Cells[i+8, "G"];
                        Excel.Range boder8 = xlRange.Cells[i+8, "H"];
                        Excel.Range boder9 = xlRange.Cells[i+8, "I"];
                        boder1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        boder2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        boder3.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        boder4.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        boder5.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        boder6.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        boder7.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        boder8.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        boder9.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    }                    
                    xlWorkbook.Save();
                    MessageBox.Show("Lưu thành công tại\n" + pathRp);
                }
                catch(Exception ex)
                {
                    throw;
                }
                finally
                {
                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Report_dsSinhVien frm_Report_DsSinhVien = new frm_Report_dsSinhVien();
            List<SinhVien> sinhViens = grid_dsSinhVien.DataSource as List<SinhVien>;
            List<vSinhVien> vSinhViens = (from sv in sinhViens
                                          select new vSinhVien() { MaSV = sv.MaSV,
                                              HoTenSV = sv.HoTenSV,
                                              Lop = sv.Lop, SDT = sv.SDT, DiaChi = sv.DiaChi,
                                              NgaySinh = sv.NgaySinh, NgayNhapHoc = sv.NgayNhapHoc, GioiTinh = sv.GioiTinh ? "Nam" : "Nữ" }).ToList();
            frm_Report_DsSinhVien.sinhViens = vSinhViens;
            frm_Report_DsSinhVien.ShowDialog();
        }
    }
}
