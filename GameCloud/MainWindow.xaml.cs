using System;
using System.Windows;

namespace GameCloud
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            var librarywindow = (GameLibrary) Application.LoadComponent(new Uri("GameLibrary.xaml", UriKind.Relative));
            librarywindow.Show();
            Close();
        }
    }
}