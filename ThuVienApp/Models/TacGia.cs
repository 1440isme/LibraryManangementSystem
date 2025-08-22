using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class TacGia
    {
        [Key]
        public int MaTacGia { get; set; }
        [Required]
        public string TenTacGia { get; set; }
        public string TieuSu { get; set; }

        public List<SachTacGia> SachTacGia { get; set; }
    }
}