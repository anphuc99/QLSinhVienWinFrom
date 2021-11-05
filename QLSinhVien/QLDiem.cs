using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSinhVien.Controller;
using QLSinhVien.Model;

namespace QLSinhVien
{
    public partial class QLDiem : Form
    {
        public QLDiemController QLDiemController { get; set; }        
        public QLDiem()
        {
            InitializeComponent();
        }

        private void QLDiem_Load(object sender, EventArgs e)
        {
            grid_BangDiem.DataSource = QLDiemController.dsDiemTheoSV();
            grid_BangDiem.Columns[0].HeaderText = "Mã Sinh Viên";
            grid_BangDiem.Columns[1].HeaderText = "Họ Và Tên";
            grid_BangDiem.Columns[2].HeaderText = "Điểm Thường Kỳ";
            grid_BangDiem.Columns[3].HeaderText = "Điểm Giữa Kỳ";
            grid_BangDiem.Columns[4].HeaderText = "Điểm Cuối Kỳ";
            grid_BangDiem.Columns[5].HeaderText = "Điểm Trung Bình";
            grid_BangDiem.Columns[6].HeaderText = "Điểm Hệ 4";
            string dau;
            int tyLe;
            QLDiemController.soNguoiDau(out dau, out tyLe);
            lb_soDau.Text = dau;
            lb_tyLe.Text = tyLe + "%";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (rd_SV.Checked)
            {
                grid_BangDiem.DataSource = QLDiemController.findTheoSV(tb_timKiem.Text);
            }
            else
            {
                grid_BangDiem.DataSource = QLDiemController.findTheoMon(tb_timKiem.Text);
            }
            
        }

        private void rd_SV_CheckedChanged(object sender, EventArgs e)
        {
            grid_BangDiem.DataSource = QLDiemController.dsDiemTheoSV();
            grid_BangDiem.Columns[0].HeaderText = "Mã Sinh Viên";
            grid_BangDiem.Columns[1].HeaderText = "Họ Và Tên";
            grid_BangDiem.Columns[2].HeaderText = "Điểm Thường Kỳ";
            grid_BangDiem.Columns[3].HeaderText = "Điểm Giữa Kỳ";
            grid_BangDiem.Columns[4].HeaderText = "Điểm Cuối Kỳ";
            grid_BangDiem.Columns[5].HeaderText = "Điểm Trung Bình";
            grid_BangDiem.Columns[6].HeaderText = "Điểm Hệ 4";
        }

        private void rd_mon_CheckedChanged(object sender, EventArgs e)
        {
            grid_BangDiem.DataSource = QLDiemController.dsDiemTheoMon();
            grid_BangDiem.Columns[0].HeaderText = "Mã Môn";
            grid_BangDiem.Columns[1].HeaderText = "Tên Môn";
            grid_BangDiem.Columns[2].HeaderText = "Điểm Thường Kỳ";
            grid_BangDiem.Columns[3].HeaderText = "Điểm Giữa Kỳ";
            grid_BangDiem.Columns[4].HeaderText = "Điểm Cuối Kỳ";
            grid_BangDiem.Columns[5].HeaderText = "Điểm Trung Bình";
            grid_BangDiem.Columns[6].HeaderText = "Điểm Hệ 4";
        }

        private void grid_BangDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rd_SV.Checked)
            {
                List<vDiemTheoSV> diemTheoSVs = grid_BangDiem.DataSource as List<vDiemTheoSV>;
                CTDiemSV cTDiemSV = new CTDiemSV();
                cTDiemSV.MaSV = diemTheoSVs[e.RowIndex].MaSV;
                cTDiemSV.QLDiemController = QLDiemController;
                cTDiemSV.ShowDialog();
            }
            else
            {
                List<vDiemTheoMon> diemTheoMons = grid_BangDiem.DataSource as List<vDiemTheoMon>;
                CTDiemMon cTDiemMon = new CTDiemMon();
                cTDiemMon.MaMon = diemTheoMons[e.RowIndex].MaMon;
                cTDiemMon.QLDiemController = QLDiemController;
                cTDiemMon.ShowDialog();
            }
        }
    }
}
