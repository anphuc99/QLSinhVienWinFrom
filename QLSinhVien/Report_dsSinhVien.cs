using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLSinhVien.Controller;
using QLSinhVien.Model;

namespace QLSinhVien
{
    public partial class frm_Report_dsSinhVien : Form
    {
        public List<vSinhVien> sinhViens { get; set; }
        public frm_Report_dsSinhVien()
        {
            InitializeComponent();
        }

        private void Report_dsSinhVien_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = sinhViens;
            report_dsSinhVien.LocalReport.DataSources.Clear();
            report_dsSinhVien.LocalReport.DataSources.Add(reportDataSource);
            this.report_dsSinhVien.RefreshReport();
        }

        private void report_dsSinhVien_Load_1(object sender, EventArgs e)
        {
        }
    }
}
