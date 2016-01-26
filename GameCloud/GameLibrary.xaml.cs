using System.Diagnostics;
using System.Windows;

namespace GameCloud
{
    /// <summary>
    ///     Interaction logic for GameLibrary.xaml
    /// </summary>
    public partial class GameLibrary
    {
        public GameLibrary()
        {
            InitializeComponent();
        }

        private void gameButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd", "/C mstsc /v:169.254.173.193 /f");
            //netsh wlan set hostednetwork mode=allow ssid=gamecloud key=12345678
            //netsh wlan start hostednetwork
        }
    }
}