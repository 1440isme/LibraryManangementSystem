using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class LoaiSach
    {
        [Key]
        public int MaLoaiSach { get; set; }
        [Required]
        public string TenLoaiSach { get; set; }
        public string MoTa { get; set; }
        public List<Sach> Saches { get; set; }
    }
}
