using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ThuVienApp.Data;
using ThuVienApp.Models;
using System;

namespace ThuVienApp.ViewModels
{
    public partial class SachViewModel : ObservableObject
    {
        private readonly ThuVienDbContext _dbContext;
        [ObservableProperty] private ObservableCollection<VW_SachConLai> danhSachSach;
        [ObservableProperty] private string errorMessage;
        [ObservableProperty] private bool hasError;
        [ObservableProperty] private Sach newSach = new Sach();
        [ObservableProperty] private ObservableCollection<LoaiSach> danhSachLoaiSach;
        [ObservableProperty] private ObservableCollection<NhaXuatBan> danhSachNXB;

        public SachViewModel(ThuVienDbContext dbContext)
        {
            _dbContext = dbContext;
           // ThemSachCommand = new RelayCommand(ShowThemSachDialog);
            LoadDataAsync();
        }

        public RelayCommand ThemSachCommand { get; }

        private async Task LoadDataAsync()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Starting to load data from VW_SachConLai...");
                danhSachSach = new ObservableCollection<VW_SachConLai>(await _dbContext.VW_SachConLai.ToListAsync());
                danhSachLoaiSach = new ObservableCollection<LoaiSach>(await _dbContext.LoaiSach.ToListAsync());
                danhSachNXB = new ObservableCollection<NhaXuatBan>(await _dbContext.NhaXuatBan.ToListAsync());
                System.Diagnostics.Debug.WriteLine("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi khi tải danh sách sách: {ex.Message}";
                hasError = true;
                System.Diagnostics.Debug.WriteLine($"Error loading data: {ex.Message} - StackTrace: {ex.StackTrace}");
            }
        }

        //private void ShowThemSachDialog()
        //{
        //    newSach = new Sach(); // Reset form
        //    var page = Window.Current.Content as FrameworkElement;
        //    while (page is FrameworkElement fe && !(fe is MainWindow))
        //    {
        //        page = fe.Parent as FrameworkElement;
        //    }
        //    if (page is MainWindow window)
        //    {
        //        var dialog = window.FindName("ThemSachDialog") as ContentDialog;
        //        if (dialog != null) _ = dialog.ShowAsync();
        //    }
        //}

        public async Task<(bool Success, string ErrorMessage)> AddSachAsync()
        {
            try
            {
                _dbContext.Sach.Add(newSach);
                await _dbContext.SaveChangesAsync();
                return (true, null);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.Message.Contains("UNIQUE") ?? false)
                    return (false, "ISBN đã tồn tại.");
                return (false, $"Lỗi khi thêm sách: {ex.Message}");
            }
        }
    }
}