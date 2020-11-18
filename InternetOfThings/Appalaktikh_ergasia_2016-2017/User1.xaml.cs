using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;




using System.Linq;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Appalaktikh_ergasia_2016_2017
{
	public partial class User1
	{
        
		public User1()
		{
			this.InitializeComponent();

             
			// Insert code required on object creation below this point.
		}

        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
             NavigationService.Navigate(new Uri("User1_options.xaml",UriKind.Relative));
			
        }

        private void rectangle1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("Elderhouse.xaml",UriKind.Relative));
        }

        private void admin_choice_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	NavigationService.Navigate(new Uri("Admin.xaml",UriKind.Relative));
			// TODO: Add event handler implementation here.
        }

        private void x_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			t_help.Visibility=System.Windows.Visibility.Hidden;
			x.Visibility=System.Windows.Visibility.Hidden;
        }

        private void online_help_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	t_help.Visibility=System.Windows.Visibility.Visible;
			x.Visibility=System.Windows.Visibility.Visible;// TODO: Add event handler implementation here.
        }

       

        
	}
}