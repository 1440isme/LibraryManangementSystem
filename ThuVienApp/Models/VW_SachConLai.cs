using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuVienApp.Models
{
    public class VW_SachConLai
    {

        public int MaSach { get; set; }
        public string TieuDe { get; set; }
        public string ISBN { get; set; }
        public int NamXuatBan { get; set; }
        public string TenLoaiSach { get; set; }
        public string TenNXB { get; set; }
        public int SoBanSaoConLai { get; set; }



        public List<SachTacGia> SachTacGias { get; set; }
    }
}