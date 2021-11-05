
namespace QLSinhVien
{
    partial class CTDiemMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTDiemMon));
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_dsDiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_TC = new System.Windows.Forms.Label();
            this.lb_TenMon = new System.Windows.Forms.Label();
            this.lb_MaMon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_rot = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_tyLe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_timKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemGKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemHe4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemChuHe4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Navy;
            this.label18.Location = new System.Drawing.Point(271, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(772, 69);
            this.label18.TabIndex = 23;
            this.label18.Text = "CHI TIẾT ĐIỂM MÔN HỌC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_dsDiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1271, 318);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // grid_dsDiem
            // 
            this.grid_dsDiem.AutoGenerateColumns = false;
            this.grid_dsDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dsDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoTenSVDataGridViewTextBoxColumn,
            this.maMonDataGridViewTextBoxColumn,
            this.tenMonDataGridViewTextBoxColumn,
            this.diemTKDataGridViewTextBoxColumn,
            this.diemGKDataGridViewTextBoxColumn,
            this.diemCKDataGridViewTextBoxColumn,
            this.diemTBDataGridViewTextBoxColumn,
            this.diemHe4DataGridViewTextBoxColumn,
            this.diemChuHe4DataGridViewTextBoxColumn});
            this.grid_dsDiem.DataSource = this.vDiemBindingSource;
            this.grid_dsDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_dsDiem.Location = new System.Drawing.Point(3, 31);
            this.grid_dsDiem.Name = "grid_dsDiem";
            this.grid_dsDiem.RowHeadersWidth = 62;
            this.grid_dsDiem.RowTemplate.Height = 28;
            this.grid_dsDiem.Size = new System.Drawing.Size(1265, 284);
            this.grid_dsDiem.TabIndex = 0;
            this.grid_dsDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsDiem_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_TC);
            this.groupBox1.Controls.Add(this.lb_TenMon);
            this.groupBox1.Controls.Add(this.lb_MaMon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 274);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lb_TC
            // 
            this.lb_TC.AutoSize = true;
            this.lb_TC.Location = new System.Drawing.Point(281, 218);
            this.lb_TC.Name = "lb_TC";
            this.lb_TC.Size = new System.Drawing.Size(113, 29);
            this.lb_TC.TabIndex = 11;
            this.lb_TC.Text = "Label lớp";
            // 
            // lb_TenMon
            // 
            this.lb_TenMon.AutoSize = true;
            this.lb_TenMon.Location = new System.Drawing.Point(281, 139);
            this.lb_TenMon.Name = "lb_TenMon";
            this.lb_TenMon.Size = new System.Drawing.Size(141, 29);
            this.lb_TenMon.TabIndex = 10;
            this.lb_TenMon.Text = "Label tên sv";
            // 
            // lb_MaMon
            // 
            this.lb_MaMon.AutoSize = true;
            this.lb_MaMon.Location = new System.Drawing.Point(281, 63);
            this.lb_MaMon.Name = "lb_MaMon";
            this.lb_MaMon.Size = new System.Drawing.Size(146, 29);
            this.lb_MaMon.TabIndex = 9;
            this.lb_MaMon.Text = "Label MSSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã môn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tín chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_rot);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lb_tyLe);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_timKiem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(675, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 274);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "                ";
            // 
            // lb_rot
            // 
            this.lb_rot.AutoSize = true;
            this.lb_rot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rot.ForeColor = System.Drawing.Color.Red;
            this.lb_rot.Location = new System.Drawing.Point(510, 176);
            this.lb_rot.Name = "lb_rot";
            this.lb_rot.Size = new System.Drawing.Size(65, 36);
            this.lb_rot.TabIndex = 14;
            this.lb_rot.Text = "Rớt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rớt";
            // 
            // lb_tyLe
            // 
            this.lb_tyLe.AutoSize = true;
            this.lb_tyLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tyLe.ForeColor = System.Drawing.Color.Red;
            this.lb_tyLe.Location = new System.Drawing.Point(137, 176);
            this.lb_tyLe.Name = "lb_tyLe";
            this.lb_tyLe.Size = new System.Drawing.Size(84, 36);
            this.lb_tyLe.TabIndex = 12;
            this.lb_tyLe.Text = "Tỷ lệ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tỷ lệ";
            // 
            // tb_timKiem
            // 
            this.tb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timKiem.Location = new System.Drawing.Point(43, 103);
            this.tb_timKiem.Name = "tb_timKiem";
            this.tb_timKiem.Size = new System.Drawing.Size(529, 41);
            this.tb_timKiem.TabIndex = 1;
            this.tb_timKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_timKiem_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // vDiemBindingSource
            // 
            this.vDiemBindingSource.DataSource = typeof(QLSinhVien.Model.vDiem);
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoTenSVDataGridViewTextBoxColumn
            // 
            this.hoTenSVDataGridViewTextBoxColumn.DataPropertyName = "HoTenSV";
            this.hoTenSVDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.hoTenSVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoTenSVDataGridViewTextBoxColumn.Name = "hoTenSVDataGridViewTextBoxColumn";
            this.hoTenSVDataGridViewTextBoxColumn.Width = 150;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.maMonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "Tên môn học";
            this.tenMonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            this.tenMonDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemTKDataGridViewTextBoxColumn
            // 
            this.diemTKDataGridViewTextBoxColumn.DataPropertyName = "DiemTK";
            this.diemTKDataGridViewTextBoxColumn.HeaderText = "Diểm thường kỳ";
            this.diemTKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemTKDataGridViewTextBoxColumn.Name = "diemTKDataGridViewTextBoxColumn";
            this.diemTKDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemGKDataGridViewTextBoxColumn
            // 
            this.diemGKDataGridViewTextBoxColumn.DataPropertyName = "DiemGK";
            this.diemGKDataGridViewTextBoxColumn.HeaderText = "Điểm giữa kỳ";
            this.diemGKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemGKDataGridViewTextBoxColumn.Name = "diemGKDataGridViewTextBoxColumn";
            this.diemGKDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemCKDataGridViewTextBoxColumn
            // 
            this.diemCKDataGridViewTextBoxColumn.DataPropertyName = "DiemCK";
            this.diemCKDataGridViewTextBoxColumn.HeaderText = "Điểm cuối kỳ";
            this.diemCKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemCKDataGridViewTextBoxColumn.Name = "diemCKDataGridViewTextBoxColumn";
            this.diemCKDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemTBDataGridViewTextBoxColumn
            // 
            this.diemTBDataGridViewTextBoxColumn.DataPropertyName = "DiemTB";
            this.diemTBDataGridViewTextBoxColumn.HeaderText = "Điểm trung bình";
            this.diemTBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemTBDataGridViewTextBoxColumn.Name = "diemTBDataGridViewTextBoxColumn";
            this.diemTBDataGridViewTextBoxColumn.Width = 150;
            // 
            // diemHe4DataGridViewTextBoxColumn
            // 
            this.diemHe4DataGridViewTextBoxColumn.DataPropertyName = "DiemHe4";
            this.diemHe4DataGridViewTextBoxColumn.HeaderText = "Điểm hệ 4";
            this.diemHe4DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemHe4DataGridViewTextBoxColumn.Name = "diemHe4DataGridViewTextBoxColumn";
            this.diemHe4DataGridViewTextBoxColumn.Width = 150;
            // 
            // diemChuHe4DataGridViewTextBoxColumn
            // 
            this.diemChuHe4DataGridViewTextBoxColumn.DataPropertyName = "DiemChuHe4";
            this.diemChuHe4DataGridViewTextBoxColumn.HeaderText = "Xếp loại";
            this.diemChuHe4DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diemChuHe4DataGridViewTextBoxColumn.Name = "diemChuHe4DataGridViewTextBoxColumn";
            this.diemChuHe4DataGridViewTextBoxColumn.Width = 150;
            // 
            // CTDiemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(219)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1299, 737);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CTDiemMon";
            this.Text = "Chi Tiết Điểm Môn Học";
            this.Load += new System.EventHandler(this.CTDiemMon_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDiemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_dsDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_TC;
        private System.Windows.Forms.Label lb_TenMon;
        private System.Windows.Forms.Label lb_MaMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_timKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_rot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_tyLe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemGKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemHe4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemChuHe4DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vDiemBindingSource;
    }
}