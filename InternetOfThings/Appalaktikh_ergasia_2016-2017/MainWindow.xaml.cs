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

namespace Appalaktikh_ergasia_2016_2017
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rectangle1_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rectangle1.Visibility = System.Windows.Visibility.Hidden;
			rectangle1_Copy.Visibility=System.Windows.Visibility.Hidden;
			textBlock1.Visibility=System.Windows.Visibility.Hidden;
			textBlock2.Visibility=System.Windows.Visibility.Hidden;
			online_help.Visibility=System.Windows.Visibility.Hidden;
			
            frame.Content = new User1();
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;//eksafanizei to backspace otan kanw pagenavigation
			
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
				
        }

        private void rectangle1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			frame.Content= new Admin();
			frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
			rectangle1.Visibility = System.Windows.Visibility.Hidden;
			rectangle1_Copy.Visibility=System.Windows.Visibility.Hidden;
			textBlock1.Visibility=System.Windows.Visibility.Hidden;
			textBlock2.Visibility=System.Windows.Visibility.Hidden;
			online_help.Visibility=System.Windows.Visibility.Hidden;
			
        }

        private void x_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	t_help.Visibility=System.Windows.Visibility.Hidden;// TODO: Add event handler implementation here.
			x.Visibility=System.Windows.Visibility.Hidden;
        }

        private void online_help_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	t_help.Visibility=System.Windows.Visibility.Visible;// TODO: Add event handler implementation here.
			x.Visibility=System.Windows.Visibility.Visible;
        }

        

        
    }
}
