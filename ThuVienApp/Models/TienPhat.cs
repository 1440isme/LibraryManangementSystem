using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class TienPhat
    {
        [Key]
        public int MaPhat { get; set; }
        [Required]
        public int MaPhieuMuon{ get; set; }
        [Required]
        public decimal SoTienPhat { get; set; }
        [Required]
        public DateTime NgayPhat { get; set; }
        public bool DaThanhToan { get; set; } = false;

        public ThanhVien ThanhVien { get; set; }
    }
}