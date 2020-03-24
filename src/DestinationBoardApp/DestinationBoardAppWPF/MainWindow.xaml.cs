using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//各ページがある名前空間
using DestinationBoardAppWPF.Pages;

namespace DestinationBoardAppWPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isFullScreen = false;
        private static MainDisplayPage mainDisplayPage = new MainDisplayPage();
        private static OrganizationEditPage organizationEditPage  = new OrganizationEditPage();
        private static PersonEditPage personEditPage = new PersonEditPage();
        private static DestinationEditPage destinationEditPage = new DestinationEditPage();
        private static HelpPage helpPage = new HelpPage();
        private static SettingPage settingPage = new SettingPage();
        public MainWindow()
        {
            InitializeComponent();
            this.isFullScreen = false;
            ContentsFrame.Navigate(mainDisplayPage);
        } 

        private void QuitButton_Selected(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #region Buttons
        private void MainDisplayButton_Selected(object sender, RoutedEventArgs e)
        {
            ContentsFrame.Navigate(settingPage);

        }
        private void OrganizationEditButton_Selected(object sender, RoutedEventArgs e)
        {
            ContentsFrame.Navigate(organizationEditPage);

        }
        private void PersonEditButton_Selected(object sender, RoutedEventArgs e)
        {
            ContentsFrame.Navigate(personEditPage);

        }
        private void DestinationEditButton_Selected(object sender, RoutedEventArgs e)
        {
            ContentsFrame.Navigate(destinationEditPage);

        }
        private void ToggleScreenModeButton_Selected(object sender, RoutedEventArgs e)
        {
            //TODO: 連続してボタンが押せるように選択解除を実装する
            if (this.isFullScreen)
            {
                //現在フルスクリーンの場合はウィンドウに戻す
                this.WindowState = WindowState.Normal;
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                this.ScreenIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Fullscreen;
                isFullScreen = false;
            }
            else
            {
                //現在ウィンドウ表示の場合の場合はフルスクリーンにする
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None;
                this.ScreenIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.FullscreenExit;
                isFullScreen = true;
            }
        }
        private void HelpButton_Selected(object sender, RoutedEventArgs e)
        {
            ContentsFrame.Navigate(helpPage);

        }
        private void SettingButton_Selected(object sender, RoutedEventArgs e)
        {
            ContentsFrame.Navigate(settingPage);
        }
        #endregion
    }
}
