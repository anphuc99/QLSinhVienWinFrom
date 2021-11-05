
namespace QLSinhVien
{
    partial class frm_Report_dsSinhVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Report_dsSinhVien));
            this.report_dsSinhVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vSinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vSinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report_dsSinhVien
            // 
            this.report_dsSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vSinhVienBindingSource;
            this.report_dsSinhVien.LocalReport.DataSources.Add(reportDataSource1);
            this.report_dsSinhVien.LocalReport.ReportEmbeddedResource = "QLSinhVien.Report1.rdlc";
            this.report_dsSinhVien.Location = new System.Drawing.Point(0, 0);
            this.report_dsSinhVien.Name = "report_dsSinhVien";
            this.report_dsSinhVien.ServerReport.BearerToken = null;
            this.report_dsSinhVien.Size = new System.Drawing.Size(1328, 616);
            this.report_dsSinhVien.TabIndex = 0;
            this.report_dsSinhVien.Load += new System.EventHandler(this.report_dsSinhVien_Load_1);
            // 
            // vSinhVienBindingSource
            // 
            this.vSinhVienBindingSource.DataSource = typeof(QLSinhVien.Model.vSinhVien);
            // 
            // frm_Report_dsSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 616);
            this.Controls.Add(this.report_dsSinhVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Report_dsSinhVien";
            this.Text = "Report_dsSinhVien";
            this.Load += new System.EventHandler(this.Report_dsSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vSinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_dsSinhVien;
        private System.Windows.Forms.BindingSource vSinhVienBindingSource;
    }
}