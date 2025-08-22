using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class VW_LichSuMuonSach
    {
       
        public int MaThanhVien { get; set; }
        public string TenThanhVien { get; set; }
        public string LoaiThanhVien { get; set; }
        public int MaPhieuMuon { get; set; }
        public int MaSach { get; set; }
        public string TieuDe { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayDenHan { get; set; }
        public DateTime? NgayTra { get; set; }
        public decimal SoTienPhat { get; set; }
        public bool DaThanhToan { get; set; } = false;
    }
}