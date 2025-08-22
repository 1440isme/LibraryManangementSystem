using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class Sach
    {
        [Key]
        public int MaSach { get; set; }
        [Required]
        public string TieuDe { get; set; }
        public string ISBN { get; set; }
        public int NamXuatBan { get; set; }
        public int MaLoaiSach { get; set; }
        public int MaNXB { get; set; }
        public int TongSoBanSao { get; set; }
        public int SoBanSaoConLai { get; set; }

        public LoaiSach LoaiSach { get; set; }
        public NhaXuatBan NhaXuatBan { get; set; }
        public List<SachTacGia> SachTacGia { get; set; }
    }
}