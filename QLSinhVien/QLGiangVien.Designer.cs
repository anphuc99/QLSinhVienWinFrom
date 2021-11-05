
namespace QLSinhVien
{
    partial class QLGiangVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLGiangVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_timKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_lamLai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_MaGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_dsGiangVien = new System.Windows.Forms.DataGridView();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errorGiangVien = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_timKiem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_lamLai);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.tb_SDT);
            this.groupBox1.Controls.Add(this.tb_DiaChi);
            this.groupBox1.Controls.Add(this.tb_HoTen);
            this.groupBox1.Controls.Add(this.tb_MaGV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // tb_timKiem
            // 
            this.tb_timKiem.Location = new System.Drawing.Point(145, 187);
            this.tb_timKiem.Name = "tb_timKiem";
            this.tb_timKiem.Size = new System.Drawing.Size(573, 35);
            this.tb_timKiem.TabIndex = 0;
            this.tb_timKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_timKiem_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tìm kiếm";
            // 
            // btn_lamLai
            // 
            this.btn_lamLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.btn_lamLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lamLai.ForeColor = System.Drawing.Color.Navy;
            this.btn_lamLai.Location = new System.Drawing.Point(742, 175);
            this.btn_lamLai.Name = "btn_lamLai";
            this.btn_lamLai.Size = new System.Drawing.Size(103, 47);
            this.btn_lamLai.TabIndex = 6;
            this.btn_lamLai.Text = "Làm lại";
            this.btn_lamLai.UseVisualStyleBackColor = false;
            this.btn_lamLai.Click += new System.EventHandler(this.btn_lamLai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_xoa.Location = new System.Drawing.Point(742, 114);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(103, 45);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(172)))), ((int)(((byte)(241)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.ForeColor = System.Drawing.Color.Navy;
            this.btn_them.Location = new System.Drawing.Point(742, 54);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(103, 47);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(506, 119);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(212, 35);
            this.tb_SDT.TabIndex = 4;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(506, 54);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(212, 35);
            this.tb_DiaChi.TabIndex = 2;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(145, 119);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(212, 35);
            this.tb_HoTen.TabIndex = 3;
            // 
            // tb_MaGV
            // 
            this.tb_MaGV.Location = new System.Drawing.Point(145, 54);
            this.tb_MaGV.Name = "tb_MaGV";
            this.tb_MaGV.Size = new System.Drawing.Size(212, 35);
            this.tb_MaGV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã GV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "SĐT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên GV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_dsGiangVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // grid_dsGiangVien
            // 
            this.grid_dsGiangVien.AutoGenerateColumns = false;
            this.grid_dsGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dsGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGVDataGridViewTextBoxColumn,
            this.tenGVDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn});
            this.grid_dsGiangVien.DataSource = this.giangVienBindingSource;
            this.grid_dsGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_dsGiangVien.Location = new System.Drawing.Point(3, 31);
            this.grid_dsGiangVien.Name = "grid_dsGiangVien";
            this.grid_dsGiangVien.RowHeadersWidth = 62;
            this.grid_dsGiangVien.RowTemplate.Height = 28;
            this.grid_dsGiangVien.Size = new System.Drawing.Size(875, 243);
            this.grid_dsGiangVien.TabIndex = 0;
            this.grid_dsGiangVien.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsGiangVien_CellEndEdit);
            this.grid_dsGiangVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsGiangVien_RowEnter);
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "Mã giảng viên";
            this.maGVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maGVDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "Tên giảng viên";
            this.tenGVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            this.tenGVDataGridViewTextBoxColumn.Width = 150;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 150;
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataSource = typeof(QLSinhVien.Model.GiangVien);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(201, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Giảng Viên";
            // 
            // errorGiangVien
            // 
            this.errorGiangVien.ContainerControl = this;
            // 
            // QLGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(219)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(916, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLGiangVien";
            this.Text = "QLGiangVien";
            this.Load += new System.EventHandler(this.QLGiangVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_MaGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.DataGridView grid_dsGiangVien;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private System.Windows.Forms.TextBox tb_timKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_lamLai;
        private System.Windows.Forms.ErrorProvider errorGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
    }
}