using Microsoft.EntityFrameworkCore;
using ThuVienApp.Models;

namespace ThuVienApp.Data
{
    public class ThuVienDbContext : DbContext
    {
        public DbSet<Sach> Sach { get; set; }
        public DbSet<LoaiSach> LoaiSach { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public DbSet<TacGia> TacGia { get; set; }
        public DbSet<SachTacGia> SachTacGia { get; set; }
        public DbSet<ThanhVien> ThanhVien { get; set; }
        public DbSet<PhieuMuon> PhieuMuon { get; set; }
        public DbSet<TienPhat> TienPhat { get; set; }
        public DbSet<VW_SachConLai> VW_SachConLai { get; set; }
        public DbSet<VW_LichSuMuonSach> VW_LichSuMuonSach { get; set; }

        public ThuVienDbContext(DbContextOptions<ThuVienDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Định nghĩa composite key cho SachTacGia
            modelBuilder.Entity<SachTacGia>()
                .HasKey(st => new { st.MaSach, st.MaTacGia });

            // Cấu hình mối quan hệ nhiều-nhiều
            modelBuilder.Entity<SachTacGia>()
                .HasOne(st => st.Sach)
                .WithMany(s => s.SachTacGia)
                .HasForeignKey(st => st.MaSach);

            modelBuilder.Entity<SachTacGia>()
                .HasOne(st => st.TacGia)
                .WithMany(t => t.SachTacGia)
                .HasForeignKey(st => st.MaTacGia);

            // Định nghĩa view keyless
            modelBuilder.Entity<VW_SachConLai>().HasNoKey().ToView("VW_SachConLai");
            modelBuilder.Entity<VW_LichSuMuonSach>().HasNoKey().ToView("VW_LichSuMuonSach");
        }
    }
}