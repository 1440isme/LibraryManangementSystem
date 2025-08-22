using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class SachTacGia
    {
        [Required]
        public int MaSach { get; set; }
        [Required]
        public int MaTacGia { get; set; }

        public Sach Sach { get; set; }
        public TacGia TacGia { get; set; }
    }
}