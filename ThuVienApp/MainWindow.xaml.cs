using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace ThuVienApp
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            NavView.SelectedItem = NavView.MenuItems[0]; // Mặc định chọn Dashboard
            NavView_SelectionChanged(null, null); // Load Dashboard đầu tiên
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args?.SelectedItemContainer != null)
            {
                var tag = args.SelectedItemContainer.Tag.ToString();
                Type pageType = tag switch
                {
                    "DashboardPage" => typeof(Views.DashboardPage),
                    "SachPage" => typeof(Views.SachPage),
                    //"ThanhVienPage" => typeof(Views.ThanhVienPage),
                    //"MuonTraSachPage" => typeof(Views.MuonTraSachPage),
                    //"BaoCaoPage" => typeof(Views.BaoCaoPage),
                    _ => null
                };

                if (pageType != null)
                {
                    ContentFrame.Navigate(pageType);
                }
            }
        }

        private void AddSachButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic mở ContentDialog Thêm Sách (sẽ triển khai sau)
            System.Diagnostics.Debug.WriteLine("Button Thêm Sách clicked");
        }
    }
}