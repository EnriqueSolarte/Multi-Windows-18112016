using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace DependentWindows
{
	public partial class MainMenu : UserControl 
	{

        //LoginWindowForm loginForm;
        //RegisterForm registerForm;

		public MainMenu()
		{
            
			InitializeComponent();         
		}

        private void clickBTN(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Gameplay());
        }
    }
}