using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ThuVienApp.Models
{
    public class ThanhVien
    {
        [Key]
        public int MaThanhVien { get; set; }
        [Required]
        public string TenThanhVien { get; set; }
        [Required]
        public string LoaiThanhVien { get; set; }
        [Required]
        public string KhoaPhong { get; set; }
        
        public string EmailLienHe { get; set; }

        public bool HoatDong { get; set; } = true;

        public DateTime NgayDangKy { get; set; } = DateTime.Now;
        public List<PhieuMuon> PhieuMuons { get; set; }
    }
}