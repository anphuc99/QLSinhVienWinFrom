//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSinhVien.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiemSV
    {
        public int MaMon { get; set; }
        public string MaSV { get; set; }
        public Nullable<double> DiemTK { get; set; }
        public Nullable<double> DiemGK { get; set; }
        public Nullable<double> DiemCK { get; set; }
        public Nullable<double> DiemTB { get; set; }
    
        public virtual MonHoc MonHoc { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}