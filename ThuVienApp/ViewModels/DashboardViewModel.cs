using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVienApp.Data;

namespace ThuVienApp.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly ThuVienDbContext _dbContext;
        [ObservableProperty] private int tongSoSach;
        [ObservableProperty] private int sachDaMuon;
        [ObservableProperty] private int tongSoThanhVien;

        public DashboardViewModel(ThuVienDbContext dbContext)
        {
            _dbContext = dbContext;
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                //TongSoSach = await _dbContext.Sach.CountAsync();
                //SachDaMuon = await _dbContext.PhieuMuon.CountAsync(p => p.NgayTra == null);
                //TongSoThanhVien = await _dbContext.ThanhVien.CountAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading dashboard data: {ex.Message}");
            }
        }
    }
}
