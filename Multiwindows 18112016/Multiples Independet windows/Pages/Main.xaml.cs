using System.Windows.Controls;
using System;

namespace Multiples_Independet_windows
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
            this.labelTime.Content = DateTime.Now.ToString();
        }

        private void clickSecondPage(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.Switch(new SecondPage(this));
            
        }
    }
}
