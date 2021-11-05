using QLSinhVien.Controller;
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
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void mn_dangNhap_Click(object sender, EventArgs e)
        {
            frm_login frm_Login = new frm_login();
            frm_Login.ShowDialog();
        }

        private void frm_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chứ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void mn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mn_dangXuat_Click(object sender, EventArgs e)
        {
            ControllerBase.user = null;
        }

        private void mn_qlSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                frm_QLSinhVien qLSinhVien = new frm_QLSinhVien();
                QLSinhVienController qLSinhVienController = new QLSinhVienController();
                qLSinhVien.qLSinhVienController = qLSinhVienController;
                qLSinhVien.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void mn_quanLyDiem_Click(object sender, EventArgs e)
        {
            try
            {
                QLDiem qLDiem = new QLDiem();
                QLDiemController qLDiemController = new QLDiemController();
                qLDiem.QLDiemController = qLDiemController;
                qLDiem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mn_qlGiangVien_Click(object sender, EventArgs e)
        {
            try
            {
                QLGiangVien giangVien = new QLGiangVien();
                QLGiangVienController qLGiangVienController = new QLGiangVienController();
                giangVien.QLGiangVienController = qLGiangVienController;
                giangVien.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void mn_phanBoLopHoc_Click(object sender, EventArgs e)
        {
            try
            {
                PhanBoLop phanBoLop = new PhanBoLop();
                PhanBoLopController phanBoLopController = new PhanBoLopController();
                phanBoLop.PhanBoLopController = phanBoLopController;
                phanBoLop.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
