using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class PhieuMuon
    {
        [Key]
        public int MaPhieuMuon { get; set; }
        [Required]
        public int MaThanhVien { get; set; }
        [Required]
        public int MaSach { get; set; }
        [Required]
        public DateTime NgayMuon { get; set; }
        public DateTime NgayDenHan { get; set; }
        public DateTime? NgayTra { get; set; }
        public bool DaTra { get; set; } = false;
        public ThanhVien ThanhVien { get; set; }
        public Sach Sach { get; set; }
    }
}