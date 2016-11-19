using System.Windows.Controls;
using System;

namespace Multiples_Independet_windows
{
    /// <summary>
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : UserControl
    {
        UserControl Main;
        public SecondPage(UserControl main)
        {
            InitializeComponent();
            this.labelTime.Content = DateTime.Now.ToString();
            Main = main;
        }
        
        private void clickBackMain(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.Switch(Main);
        }
    }
}
