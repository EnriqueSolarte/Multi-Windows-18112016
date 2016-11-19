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
using System.Windows.Shapes;

namespace Multiwindows_18112016
{
    /// <summary>
    /// Interaction logic for SecondWindows.xaml
    /// </summary>
    public partial class SecondWindows : Window
    {
        public SecondWindows(int x, string y)
        {
            InitializeComponent();
            this.labelTime.Content = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void clickGiveTime(object sender, RoutedEventArgs e)
        {
            this.labelTime.Content = DateTime.Now.ToString();
        }
    }
}
