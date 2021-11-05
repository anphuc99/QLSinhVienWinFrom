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
    public partial class QLGiangVien : Form
    {
        public QLGiangVienController QLGiangVienController { get; set; }
        private int Index;
        public QLGiangVien()
        {
            InitializeComponent();
        }

        private void QLGiangVien_Load(object sender, EventArgs e)
        {
            grid_dsGiangVien.DataSource = QLGiangVienController.dsGiangVien();
        }

        private void reset()
        {
            tb_MaGV.Text = "";
            tb_HoTen.Text = "";
            tb_SDT.Text = "";
            tb_DiaChi.Text = "";
            grid_dsGiangVien.DataSource = QLGiangVienController.dsGiangVien();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSave = true;
                if(tb_MaGV.Text == "")
                {
                    errorGiangVien.SetError(tb_MaGV, "Mã giảng viên không được để trống!");
                    isSave = false;
                }
                if (tb_HoTen.Text == "")
                {
                    errorGiangVien.SetError(tb_HoTen, "Họ tên không được để trống!");
                    isSave = false;
                }
                if (tb_SDT.Text == "")
                {
                    errorGiangVien.SetError(tb_SDT, "Số điện thoại không được để trống!");
                    isSave = false;
                }
                if (tb_DiaChi.Text == "")
                {
                    errorGiangVien.SetError(tb_DiaChi, "Địa chỉ không được để trống!");
                    isSave = false;
                }
                if (!isSave) return;
                GiangVien giangVien = new GiangVien();
                giangVien.MaGV = tb_MaGV.Text;
                giangVien.TenGV = tb_HoTen.Text;
                giangVien.DiaChi = tb_DiaChi.Text;
                giangVien.SDT = tb_SDT.Text;
                QLGiangVienController.AddGiangVien(giangVien);
                reset();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_dsGiangVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        private void btn_lamLai_Click(object sender, EventArgs e)
        {
            tb_MaGV.Text = "";
            tb_HoTen.Text = "";
            tb_SDT.Text = "";
            tb_DiaChi.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa giảng viên này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<p_findGiangVien_Result> giangViens = grid_dsGiangVien.DataSource as List<p_findGiangVien_Result>;
                QLGiangVienController.RemoveGiangVien(giangViens[Index].MaGV);
                reset();
            }            
        }

        private void grid_dsGiangVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<p_findGiangVien_Result> giangViens = grid_dsGiangVien.DataSource as List<p_findGiangVien_Result>;
                QLGiangVienController.UpdateGiangVien(giangViens[e.RowIndex]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_timKiem_KeyUp(object sender, KeyEventArgs e)
        {
            grid_dsGiangVien.DataSource = QLGiangVienController.findGiangVien(tb_timKiem.Text);
        }
    }
}
