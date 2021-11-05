using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSinhVien.Model;
using System.Windows.Forms;
using QLSinhVien.Controller;
using System.Data.Entity;

namespace QLSinhVien
{
    public partial class PhanBoLop : Form
    {
        public PhanBoLopController PhanBoLopController { get; set; }
        private int page = 1;
        private List<Button> cacPhong = new List<Button>();
        private string phongHoc = "";
        private bool cheDoSua = false;
        private vLopHocPhan lopDangSua;
        private int index;
        public PhanBoLop()
        {            
            InitializeComponent();
        }
        private void setDefaultPhong()
        {
            foreach(Button phong in cacPhong)
            {
                phong.Text = "";
            }
        }
        private void setPhong()
        {
            setDefaultPhong();
            string[] phong = PhanBoLopController.getPhongHoc(page);
            try
            {
                for(int i = 0; i < 45; i++)
                {
                    cacPhong[i].Text = phong[i];
                }
            }
            catch
            {

            }
        }
        private void setMau()
        {
            try
            {
                QLSinhVienEntities db = new QLSinhVienEntities();
                GiangVien giangVien = cb_giangVien.SelectedItem as GiangVien;
                if (cheDoSua)
                {
                    LopHocPhan lopHocPhan = db.LopHocPhans.Find(lopDangSua.MaLopHocPhan);
                    if (giangVien.MaGV == lopHocPhan.MaGV)
                    {
                        setMau2();
                        return;
                    }                    
                }                
                MonHoc monHoc = cb_mon.SelectedItem as MonHoc;
                int thu;
                if((string)cb_thu.SelectedItem == "CN")
                {
                    thu = 8;
                }
                else
                {
                    thu = int.Parse((string)cb_thu.SelectedItem);
                }                
                DateTime ngayBD = Convert.ToDateTime(date_ngBD.Text);
                DateTime ngayKT = Convert.ToDateTime(date_ngKT.Text);
                int tietBD = int.Parse(tb_tuTiet.Text);
                int tietKT = int.Parse(tb_denTiet.Text);
                string phongHoc = p1.Text;
                if (db.p_ktGVTrungLich(thu, ngayBD, ngayKT, tietBD, tietKT, giangVien.MaGV).FirstOrDefault() == 1)
                    foreach (Button phong in cacPhong)
                    {
                        phong.BackColor = Color.Red;
                    }
                else
                {
                    foreach (Button phong in cacPhong)
                    {
                        if(phong.Text != lopDangSua?.PhongHoc && db.p_ktPHTrungLich(thu, ngayBD, ngayKT, tietBD, tietKT, phong.Text).FirstOrDefault() == 1)
                        {
                            phong.BackColor = Color.Red;
                        }
                        else
                        {
                            if (phong.Text == this.phongHoc)
                            {
                                phong.BackColor = Color.Green;
                            }
                            else
                            {
                                phong.BackColor = Color.FromArgb(224, 224, 224);
                            }

                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void PhanBoLop_Load(object sender, EventArgs e)
        {
            QLSinhVienEntities db = new QLSinhVienEntities();
            cb_giangVien.DataSource = db.GiangViens.ToList();
            cb_mon.DataSource = db.MonHocs.ToList();
            cb_thu.DataSource = new string[] { "2", "3", "4", "5", "6", "7", "CN" };
            cb_hocKy.DataSource = new string[] { "1", "2", "3" };
            cb_loaiLop.DataSource = LoaiLop.getLoaiLop().Select(x=>x.TenLoai).ToList();
            cb_hocKy2.DataSource = new string[] { "1", "2", "3" };
            cb_namHoc.DataSource = new string[] { "2019", "2020", "2021", "2022", "2023" };
            cb_loaiLop.DataSource = new string[] {"Lý thuyết","Thực hành","Đồ án","Khóa luận"};
            btn_sua.Enabled = false;
            grid_lopHoc.DataSource = PhanBoLopController.getLopHoc(int.Parse(cb_hocKy2.Text),DateTime.Now.Year);
            grid_lopHoc.Columns[0].HeaderText = "Mã học phần";
            grid_lopHoc.Columns[1].HeaderText = "Tên lớp";
            grid_lopHoc.Columns[2].HeaderText = "Môn học";
            grid_lopHoc.Columns[3].HeaderText = "Phòng học";
            grid_lopHoc.Columns[4].HeaderText = "Học kỳ";
            grid_lopHoc.Columns[5].HeaderText = "Tên giảng viên";
            grid_lopHoc.Columns[6].HeaderText = "Thứ";
            grid_lopHoc.Columns[7].HeaderText = "Ngày bắt đầu";
            grid_lopHoc.Columns[8].HeaderText = "Ngày kết thúc";
            grid_lopHoc.Columns[9].HeaderText = "Từ tiết";
            grid_lopHoc.Columns[10].HeaderText = "Đến tiết";
            grid_lopHoc.Columns[11].HeaderText = "Loại lớp";
            cacPhong.Add(p1);
            cacPhong.Add(p2);
            cacPhong.Add(p3);
            cacPhong.Add(p4);
            cacPhong.Add(p5);
            cacPhong.Add(p6);
            cacPhong.Add(p7);
            cacPhong.Add(p8);
            cacPhong.Add(p9);
            cacPhong.Add(p10);
            cacPhong.Add(p11);
            cacPhong.Add(p12);
            cacPhong.Add(p13);
            cacPhong.Add(p14);
            cacPhong.Add(p15);
            cacPhong.Add(p16);
            cacPhong.Add(p17);
            cacPhong.Add(p18);
            cacPhong.Add(p19);
            cacPhong.Add(p20);
            cacPhong.Add(p21);
            cacPhong.Add(p22);
            cacPhong.Add(p23);
            cacPhong.Add(p24);
            cacPhong.Add(p25);
            cacPhong.Add(p26);
            cacPhong.Add(p27);
            cacPhong.Add(p28);
            cacPhong.Add(p29);
            cacPhong.Add(p30);
            cacPhong.Add(p31);
            cacPhong.Add(p32);
            cacPhong.Add(p33);
            cacPhong.Add(p34);
            cacPhong.Add(p35);
            cacPhong.Add(p36);
            cacPhong.Add(p37);
            cacPhong.Add(p38);
            cacPhong.Add(p39);
            cacPhong.Add(p40);
            cacPhong.Add(p41);
            cacPhong.Add(p42);
            cacPhong.Add(p43);
            cacPhong.Add(p44);
            cacPhong.Add(p45);
            setPhong();
        }

        private void grid_lopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<vLopHocPhan> vLopHocPhans = grid_lopHoc.DataSource as List<vLopHocPhan>;
            grid_dsSinhVien.DataSource = PhanBoLopController.getdsSinhVien(vLopHocPhans[e.RowIndex].MaLopHocPhan);
        }

        private void cb_hocKy2_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid_lopHoc.DataSource = PhanBoLopController.getLopHoc(int.Parse(cb_hocKy2.Text), int.Parse(cb_namHoc.Text));
        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            page--;
            setPhong();
            setMau();
        }

        private void btn_xemTiep_Click(object sender, EventArgs e)
        {
            page++;
            setPhong();
            setMau();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (cheDoSua)
                {
                    MessageBox.Show("Bạn đang ở chế độ sửa không thể thêm");
                    return;
                }
                LopHocPhan lopHocPhan = new LopHocPhan();
                GiangVien giangVien = cb_giangVien.SelectedItem as GiangVien;
                MonHoc monHoc = cb_mon.SelectedItem as MonHoc;
                bool luu = true;
                if (tb_maLop.Text == "")
                {
                    errorProvider1.SetError(tb_maLop, "Mã lớp học phần không được để trống");
                    luu = false;
                }
                if (tb_tenLop.Text == "")
                {
                    errorProvider1.SetError(tb_tenLop, "Tên lớp học phần không được để trống");
                    luu = false;
                }
                if (tb_tuTiet.Text == "")
                {
                    errorProvider1.SetError(tb_tuTiet, "Tiết bắt đầu không được để trống");
                    luu = false;
                }
                if (tb_denTiet.Text == "")
                {
                    errorProvider1.SetError(tb_denTiet, "Tiết kết thúc không được để trống");
                    luu = false;
                }
                if (phongHoc == null || phongHoc == "")
                {
                    MessageBox.Show("Vui lòng chọn phòng học", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    luu = false;
                }
                if (!luu) return;
                lopHocPhan.MaGV = giangVien.MaGV;
                lopHocPhan.MaMon = monHoc.MaMon;
                lopHocPhan.HocKy = int.Parse((string)cb_hocKy.SelectedItem);
                lopHocPhan.MaLopHocPhan = tb_maLop.Text;
                lopHocPhan.TenLopHoc = tb_tenLop.Text;
                lopHocPhan.LoaiLop = LoaiLop.getLoaiLop().Where(x => x.TenLoai == (string)cb_loaiLop.SelectedItem).Select(x => x.MaLoai).FirstOrDefault();
                lopHocPhan.TietBD = int.Parse(tb_tuTiet.Text);
                lopHocPhan.TietKT = int.Parse(tb_denTiet.Text);
                lopHocPhan.Thu = int.Parse((string)cb_thu.SelectedItem);
                lopHocPhan.NgayBD = Convert.ToDateTime(date_ngBD.Text);
                lopHocPhan.NgayKT = Convert.ToDateTime(date_ngKT.Text);
                lopHocPhan.PhongHoc = phongHoc;
                PhanBoLopController.AddLopHocPhan(lopHocPhan);
                phongHoc = null;
                setMau();
                grid_lopHoc.DataSource = PhanBoLopController.getLopHoc(int.Parse((string)cb_hocKy.SelectedItem),lopHocPhan.NgayBD.Year);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                LopHocPhan lopHocPhan = new LopHocPhan();
                GiangVien giangVien = cb_giangVien.SelectedItem as GiangVien;
                MonHoc monHoc = cb_mon.SelectedItem as MonHoc;
                bool luu = true;
                if (tb_maLop.Text == "")
                {
                    errorProvider1.SetError(tb_maLop, "Mã lớp học phần không được để trống");
                    luu = false;
                }
                if (tb_tenLop.Text == "")
                {
                    errorProvider1.SetError(tb_tenLop, "Tên lớp học phần không được để trống");
                    luu = false;
                }
                if (tb_tuTiet.Text == "")
                {
                    errorProvider1.SetError(tb_tuTiet, "Tiết bắt đầu không được để trống");
                    luu = false;
                }
                if (tb_denTiet.Text == "")
                {
                    errorProvider1.SetError(tb_denTiet, "Tiết kết thúc không được để trống");
                    luu = false;
                }
                if (phongHoc == null || phongHoc == "")
                {
                    MessageBox.Show("Vui lòng chọn phòng học", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    luu = false;
                }
                if (!luu) return;
                lopHocPhan.MaGV = giangVien.MaGV;
                lopHocPhan.MaMon = monHoc.MaMon;
                lopHocPhan.HocKy = int.Parse((string)cb_hocKy.SelectedItem);
                lopHocPhan.MaLopHocPhan = tb_maLop.Text;
                lopHocPhan.TenLopHoc = tb_tenLop.Text;
                lopHocPhan.LoaiLop = LoaiLop.getLoaiLop().Where(x => x.TenLoai == (string)cb_loaiLop.SelectedItem).Select(x => x.MaLoai).FirstOrDefault();
                lopHocPhan.TietBD = int.Parse(tb_tuTiet.Text);
                lopHocPhan.TietKT = int.Parse(tb_denTiet.Text);
                lopHocPhan.Thu = int.Parse((string)cb_thu.SelectedItem);
                lopHocPhan.NgayBD = Convert.ToDateTime(date_ngBD.Text);
                lopHocPhan.NgayKT = Convert.ToDateTime(date_ngKT.Text);
                lopHocPhan.PhongHoc = phongHoc;
                PhanBoLopController.UpdateLopHocPhan(lopHocPhan);
                grid_lopHoc.DataSource = PhanBoLopController.getLopHoc(int.Parse(cb_hocKy2.Text), DateTime.Now.Year);
                QLSinhVienEntities db = new QLSinhVienEntities();
                string maHP = tb_maLop.Text;
                lopDangSua = db.vLopHocPhans.Where(x => x.MaLopHocPhan == maHP).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa lớp học phần này chứ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    List<vLopHocPhan> vLopHocPhans = grid_lopHoc.DataSource as List<vLopHocPhan>;
                    PhanBoLopController.DeleteLopHocPhan(vLopHocPhans[index].MaLopHocPhan);
                    grid_lopHoc.DataSource = PhanBoLopController.getLopHoc(int.Parse(cb_hocKy2.Text), DateTime.Now.Year);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chonPhongHoc(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.BackColor != Color.Red)
            {
                foreach (Button phong in cacPhong)
                {
                    if (phong.BackColor == Color.Green)
                    {
                        phong.BackColor = Color.FromArgb(224, 224, 224);
                    }
                }
                button.BackColor = Color.Green;
                phongHoc = button.Text;
            }
        }

        private void ktPhong(object sender, EventArgs e)
        {
            setMau();
        }

        private void grid_lopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            vLopHocPhan lopHocPhan = (grid_lopHoc.DataSource as List<vLopHocPhan>)[e.RowIndex];
            cb_giangVien.SelectedIndex = cb_giangVien.FindString(lopHocPhan.TenGV);
            cb_hocKy.SelectedIndex = cb_hocKy.FindString(lopHocPhan.HocKy.ToString());
            cb_mon.SelectedIndex = cb_mon.FindString(lopHocPhan.TenMon);
            cb_thu.SelectedIndex = cb_thu.FindString(lopHocPhan.Thu == 8 ? "CN" : lopHocPhan.Thu.ToString());
            cb_loaiLop.SelectedIndex = cb_loaiLop.FindString(lopHocPhan.LoaiLop);
            tb_maLop.Text = lopHocPhan.MaLopHocPhan;
            tb_tenLop.Text = lopHocPhan.TenLopHoc;
            tb_tuTiet.Text = lopHocPhan.TietBD.ToString();
            tb_denTiet.Text = lopHocPhan.TietKT.ToString();
            date_ngBD.Value = lopHocPhan.NgayBD;
            date_ngKT.Value = lopHocPhan.NgayKT;
            phongHoc = lopHocPhan.PhongHoc;
            setMau2();
            cheDoSua = true;
            button1.BackColor = Color.Red;
            tb_maLop.ReadOnly = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
        }
        private void setMau2()
        {
            try
            {
                QLSinhVienEntities db = new QLSinhVienEntities();
                GiangVien giangVien = cb_giangVien.SelectedItem as GiangVien;
                MonHoc monHoc = cb_mon.SelectedItem as MonHoc;
                int thu;
                if ((string)cb_thu.SelectedItem == "CN")
                {
                    thu = 8;
                }
                else
                {
                    thu = int.Parse((string)cb_thu.SelectedItem);
                }
                DateTime ngayBD = Convert.ToDateTime(date_ngBD.Text);
                DateTime ngayKT = Convert.ToDateTime(date_ngKT.Text);
                int tietBD = int.Parse(tb_tuTiet.Text);
                int tietKT = int.Parse(tb_denTiet.Text);
                string phongHoc = p1.Text;
                {
                    foreach (Button phong in cacPhong)
                    {
                        if (db.p_ktPHTrungLich(thu, ngayBD, ngayKT, tietBD, tietKT, phong.Text).FirstOrDefault() == 1)
                        {
                            if (phong.Text == lopDangSua.PhongHoc)
                            {
                                phong.BackColor = Color.FromArgb(224, 224, 224);
                            }
                            else
                            {
                                phong.BackColor = Color.Red;
                            }                            
                        }
                        else
                        {
                            if (phong.Text == this.phongHoc)
                            {
                                phong.BackColor = Color.Green;
                            }
                            else
                            {
                                phong.BackColor = Color.FromArgb(224, 224, 224);
                            }

                        }
                    }
                }
                foreach (Button phong in cacPhong)
                {
                    if (phong.Text == this.phongHoc)
                    {
                        phong.BackColor = Color.Green;
                    }
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cheDoSua)
            {
                cheDoSua = false;
                button1.BackColor = Color.Chartreuse;
                tb_maLop.ReadOnly = false;
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
            }
            else
            {
                cheDoSua = true;
                button1.BackColor = Color.Red;
                tb_maLop.ReadOnly = true;
                btn_them.Enabled = false;
                btn_sua.Enabled = true;
            }
            setMau();
        }

        private void tb_maLop_TextChanged(object sender, EventArgs e)
        {
            try
            {
                QLSinhVienEntities db = new QLSinhVienEntities();
                string maHP = tb_maLop.Text;
                lopDangSua = db.vLopHocPhans.Where(x=>x.MaLopHocPhan == maHP).First();
            }
            catch
            {
                lopDangSua = null;
            }
            
        }

        private void grid_lopHoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
