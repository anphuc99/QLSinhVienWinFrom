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
    public partial class CTDiemMon : Form
    {
        public int MaMon { get; set; }
        public QLDiemController QLDiemController { get; set; }
        public CTDiemMon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CTDiemMon_Load(object sender, EventArgs e)
        {
            MonHoc monHoc;
            List<vDiem> diems;
            QLDiemController.chiTietDiemMon(MaMon, out monHoc, out diems);
            lb_MaMon.Text = monHoc.MaMon.ToString();
            lb_TenMon.Text = monHoc.TenMon;
            lb_TC.Text = monHoc.TC.ToString();            
            grid_dsDiem.DataSource = diems;
            grid_dsDiem.Columns[2].Visible = false;
            grid_dsDiem.Columns[3].Visible = false;
            int rot = diems.Where(x => x.DiemHe4 == 0).ToList().Count;
            int daHoc = diems.Count;
            int tyLe = (int)Math.Round(((double)rot / (double)daHoc) * 100);
            lb_rot.Text = rot + "";
            lb_tyLe.Text = tyLe + "%";
        }

        private void tb_timKiem_KeyUp(object sender, KeyEventArgs e)
        {
            grid_dsDiem.DataSource = QLDiemController.findChiTiet(tb_timKiem.Text, 2, MaMon.ToString());
        }

        private void grid_dsDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            List<vDiem> diems = grid_dsDiem.DataSource as List<vDiem>;
            QLDiemController.suaDiemSV(diems[e.RowIndex]);
        }
    }
}
