using System;
using System.Windows.Controls;

namespace DependentWindows
{
    public partial class Gameplay : UserControl
    {
		public Gameplay()
		{
			InitializeComponent();
		}

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	Switcher.Switch(new MainMenu());
        }
        #endregion
    }
}