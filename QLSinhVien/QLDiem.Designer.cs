
namespace QLSinhVien
{
    partial class QLDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLDiem));
            this.rd_SV = new System.Windows.Forms.RadioButton();
            this.rd_mon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_tyLe = new System.Windows.Forms.Label();
            this.lb_soDau = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_timKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_BangDiem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_BangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_SV
            // 
            this.rd_SV.AutoSize = true;
            this.rd_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_SV.Location = new System.Drawing.Point(32, 63);
            this.rd_SV.Name = "rd_SV";
            this.rd_SV.Size = new System.Drawing.Size(208, 50);
            this.rd_SV.TabIndex = 0;
            this.rd_SV.TabStop = true;
            this.rd_SV.Text = "Sinh viên";
            this.rd_SV.UseVisualStyleBackColor = true;
            this.rd_SV.CheckedChanged += new System.EventHandler(this.rd_SV_CheckedChanged);
            // 
            // rd_mon
            // 
            this.rd_mon.AutoSize = true;
            this.rd_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_mon.Location = new System.Drawing.Point(32, 139);
            this.rd_mon.Name = "rd_mon";
            this.rd_mon.Size = new System.Drawing.Size(200, 50);
            this.rd_mon.TabIndex = 1;
            this.rd_mon.TabStop = true;
            this.rd_mon.Text = "Môn học";
            this.rd_mon.UseVisualStyleBackColor = true;
            this.rd_mon.CheckedChanged += new System.EventHandler(this.rd_mon_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_tyLe);
            this.groupBox1.Controls.Add(this.lb_soDau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_timKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rd_SV);
            this.groupBox1.Controls.Add(this.rd_mon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // lb_tyLe
            // 
            this.lb_tyLe.AutoSize = true;
            this.lb_tyLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tyLe.ForeColor = System.Drawing.Color.Red;
            this.lb_tyLe.Location = new System.Drawing.Point(965, 135);
            this.lb_tyLe.Name = "lb_tyLe";
            this.lb_tyLe.Size = new System.Drawing.Size(95, 36);
            this.lb_tyLe.TabIndex = 7;
            this.lb_tyLe.Text = "label6";
            // 
            // lb_soDau
            // 
            this.lb_soDau.AutoSize = true;
            this.lb_soDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_soDau.Location = new System.Drawing.Point(634, 139);
            this.lb_soDau.Name = "lb_soDau";
            this.lb_soDau.Size = new System.Drawing.Size(95, 36);
            this.lb_soDau.TabIndex = 6;
            this.lb_soDau.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(866, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tỷ lệ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số sinh viên đậu";
            // 
            // tb_timKiem
            // 
            this.tb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timKiem.Location = new System.Drawing.Point(583, 52);
            this.tb_timKiem.Name = "tb_timKiem";
            this.tb_timKiem.Size = new System.Drawing.Size(468, 53);
            this.tb_timKiem.TabIndex = 3;
            this.tb_timKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_BangDiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(50, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1121, 517);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // grid_BangDiem
            // 
            this.grid_BangDiem.AllowUserToAddRows = false;
            this.grid_BangDiem.AllowUserToDeleteRows = false;
            this.grid_BangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_BangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_BangDiem.Location = new System.Drawing.Point(3, 31);
            this.grid_BangDiem.Name = "grid_BangDiem";
            this.grid_BangDiem.ReadOnly = true;
            this.grid_BangDiem.RowHeadersWidth = 62;
            this.grid_BangDiem.RowTemplate.Height = 28;
            this.grid_BangDiem.Size = new System.Drawing.Size(1115, 483);
            this.grid_BangDiem.TabIndex = 0;
            this.grid_BangDiem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_BangDiem_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(316, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(621, 91);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUẢN LÝ ĐIỂM";
            // 
            // QLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(219)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1217, 943);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLDiem";
            this.Text = "Quản Lý Điểm";
            this.Load += new System.EventHandler(this.QLDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_BangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_SV;
        private System.Windows.Forms.RadioButton rd_mon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_timKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_BangDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tyLe;
        private System.Windows.Forms.Label lb_soDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}