using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using ThuVienApp.Views;

namespace ThuVienApp
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Mặc định load Trang Dashboard  
            ContentFrame.Navigate(typeof(DashboardPage));
            SetButtonSelected(BtnDashboard);
        }

        private void ResetAllButtons()
        {
            var buttons = new[] { BtnDashboard, BtnSach, BtnThanhVien, BtnMuonTra, BtnBaoCao };
            foreach (var btn in buttons)
            {
                btn.Background = new SolidColorBrush(Colors.Transparent);
                btn.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void SetButtonSelected(Button selected)
        {
            ResetAllButtons();
            selected.Background = new SolidColorBrush(Colors.MediumSlateBlue);
            selected.Foreground = new SolidColorBrush(Colors.White);
        }

        private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(DashboardPage));
            SetButtonSelected((Button)sender);
        }

        private void BtnSach_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(SachPage));
            SetButtonSelected((Button)sender);
        }

        private void BtnThanhVien_Click(object sender, RoutedEventArgs e)
        {
            //ContentFrame.Navigate(typeof(ThanhVienPage));  
            SetButtonSelected((Button)sender);
        }

        private void BtnMuonTra_Click(object sender, RoutedEventArgs e)
        {
            //ContentFrame.Navigate(typeof(MuonTraSachPage));  
            SetButtonSelected((Button)sender);
        }

        private void BtnBaoCao_Click(object sender, RoutedEventArgs e)
        {
            //ContentFrame.Navigate(typeof(BaoCaoPage));  
            SetButtonSelected((Button)sender);
        }
    }
}
