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

namespace DestinationBoardAppWPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isFullScreen = false;
        public MainWindow()
        {
            InitializeComponent();
            this.isFullScreen = false;
        }

        private void QuitButton_Selected(object sender, RoutedEventArgs e)
        {
            this.Close();

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

        private void SettingButton_Selected(object sender, RoutedEventArgs e)
        {
            ContentsFrame.Navigate(new SettingPage());
        }
    }
}
