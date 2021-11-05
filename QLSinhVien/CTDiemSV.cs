using QLSinhVien.Controller;
using QLSinhVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class CTDiemSV : Form
    {
        public QLDiemController QLDiemController { get; set; }
        public string MaSV { get; set; }
        public CTDiemSV()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CTDiemSV_Load(object sender, EventArgs e)
        {
            SinhVien sinhVien;
            List<vDiem> diems;
            QLDiemController.chiTietDiemSV(MaSV, out sinhVien, out diems);
            lb_MaSV.Text = sinhVien.MaSV;
            lb_HoTen.Text = sinhVien.HoTenSV;
            lb_Lop.Text = sinhVien.Lop;
            lb_NgaySinh.Text = sinhVien.NgaySinh.ToString("dd/MM/yyyy");
            lb_NgayNH.Text = sinhVien.NgayNhapHoc.ToString("dd/MM/yyyy");
            lb_SDT.Text = sinhVien.SDT;
            lb_DiaChi.Text = sinhVien.DiaChi;
            lb_GioTinh.Text = sinhVien.GioiTinh ? "Nam" : "Nữ";
            grid_dsDiem.DataSource = diems;
            grid_dsDiem.Columns[0].Visible = false;
            grid_dsDiem.Columns[1].Visible = false;
            int rot = diems.Where(x => x.DiemHe4 == 0).ToList().Count;
            int daHoc = diems.Count;
            int tyLe = (int)Math.Round(((double)rot / (double)daHoc) * 100);
            lb_Rot.Text = rot + "";
            lb_tyLe.Text = tyLe + "%";
        }

        private void tb_timKiem_KeyUp(object sender, KeyEventArgs e)
        {
            grid_dsDiem.DataSource = QLDiemController.findChiTiet(tb_timKiem.Text, 1, MaSV.ToString());
        }

        private void grid_dsDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            List<vDiem> diems = grid_dsDiem.DataSource as List<vDiem>;
            QLDiemController.suaDiemSV(diems[e.RowIndex]);
        }
    }
}
