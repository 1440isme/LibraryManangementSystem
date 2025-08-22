using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ThuVienApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            NavView.ItemInvoked += NavView_ItemInvoked;
            ContentFrame.Navigate(typeof(Views.SachPage));
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var tag = args.InvokedItemContainer.Tag.ToString();
            Type pageType = tag switch
            {
                "SachPage" => typeof(Views.SachPage),
                //"ThanhVienPage" => typeof(Views.ThanhVienPage),
                //"MuonTraSachPage" => typeof(Views.MuonTraSachPage),
                //"BaoCaoPage" => typeof(Views.BaoCaoPage),
                _ => null
            };
            if (pageType != null)
                ContentFrame.Navigate(pageType);
        }
    }
}
