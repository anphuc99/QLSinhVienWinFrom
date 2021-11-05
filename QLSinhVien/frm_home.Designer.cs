
namespace QLSinhVien
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_dangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qlSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qlGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_quanLyDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_phanBoLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_dangNhap,
            this.mn_dangXuat,
            this.mn_thoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // mn_dangNhap
            // 
            this.mn_dangNhap.Name = "mn_dangNhap";
            this.mn_dangNhap.Size = new System.Drawing.Size(205, 34);
            this.mn_dangNhap.Text = "Đăng Nhập";
            this.mn_dangNhap.Click += new System.EventHandler(this.mn_dangNhap_Click);
            // 
            // mn_dangXuat
            // 
            this.mn_dangXuat.Name = "mn_dangXuat";
            this.mn_dangXuat.Size = new System.Drawing.Size(205, 34);
            this.mn_dangXuat.Text = "Đăng Xuất";
            this.mn_dangXuat.Click += new System.EventHandler(this.mn_dangXuat_Click);
            // 
            // mn_thoat
            // 
            this.mn_thoat.Name = "mn_thoat";
            this.mn_thoat.Size = new System.Drawing.Size(205, 34);
            this.mn_thoat.Text = "Thoát";
            this.mn_thoat.Click += new System.EventHandler(this.mn_thoat_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_qlSinhVien,
            this.mn_qlGiangVien,
            this.mn_quanLyDiem,
            this.mn_phanBoLopHoc});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // mn_qlSinhVien
            // 
            this.mn_qlSinhVien.Name = "mn_qlSinhVien";
            this.mn_qlSinhVien.Size = new System.Drawing.Size(270, 34);
            this.mn_qlSinhVien.Text = "Quản lý sinh viên";
            this.mn_qlSinhVien.Click += new System.EventHandler(this.mn_qlSinhVien_Click);
            // 
            // mn_qlGiangVien
            // 
            this.mn_qlGiangVien.Name = "mn_qlGiangVien";
            this.mn_qlGiangVien.Size = new System.Drawing.Size(270, 34);
            this.mn_qlGiangVien.Text = "Quản lý giảng viên";
            this.mn_qlGiangVien.Click += new System.EventHandler(this.mn_qlGiangVien_Click);
            // 
            // mn_quanLyDiem
            // 
            this.mn_quanLyDiem.Name = "mn_quanLyDiem";
            this.mn_quanLyDiem.Size = new System.Drawing.Size(270, 34);
            this.mn_quanLyDiem.Text = "Quản lý điểm";
            this.mn_quanLyDiem.Click += new System.EventHandler(this.mn_quanLyDiem_Click);
            // 
            // mn_phanBoLopHoc
            // 
            this.mn_phanBoLopHoc.Name = "mn_phanBoLopHoc";
            this.mn_phanBoLopHoc.Size = new System.Drawing.Size(270, 34);
            this.mn_phanBoLopHoc.Text = "Phân bố lớp học";
            this.mn_phanBoLopHoc.Click += new System.EventHandler(this.mn_phanBoLopHoc_Click);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(219)))), ((int)(((byte)(248)))));
            this.BackgroundImage = global::QLSinhVien.Properties.Resources.dh_nguyen_tat_thanh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1228, 641);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_home_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_dangNhap;
        private System.Windows.Forms.ToolStripMenuItem mn_dangXuat;
        private System.Windows.Forms.ToolStripMenuItem mn_thoat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_qlSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mn_qlGiangVien;
        private System.Windows.Forms.ToolStripMenuItem mn_quanLyDiem;
        private System.Windows.Forms.ToolStripMenuItem mn_phanBoLopHoc;
    }
}

