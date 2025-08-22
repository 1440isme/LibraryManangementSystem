using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class NhaXuatBan
    {
        [Key]
        public int MaNXB { get; set; }
        [Required]
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public string EmailLienHe { get; set; }
        public List<Sach> Saches { get; set; }
    }
}