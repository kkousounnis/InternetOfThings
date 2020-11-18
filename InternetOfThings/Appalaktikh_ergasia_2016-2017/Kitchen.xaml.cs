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

namespace Appalaktikh_ergasia_2016_2017
{
	public partial class Kitchen
	{
		public Kitchen()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void red_b_off_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			red_b_on.Visibility=System.Windows.Visibility.Visible;
            coffe_full.Visibility = System.Windows.Visibility.Visible;



        }

		private void red_b_on_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			red_b_on.Visibility=System.Windows.Visibility.Hidden;
            coffe_full.Visibility = System.Windows.Visibility.Hidden;
			
            
			
			
		}

		private void screen_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			switch_off.Visibility=System.Windows.Visibility.Hidden;
			frame_screen_fridje.Visibility=System.Windows.Visibility.Visible;
			
			JUICE.Visibility=System.Windows.Visibility.Hidden;		
			kreata.Visibility=System.Windows.Visibility.Hidden;
			milk.Visibility=System.Windows.Visibility.Hidden;
			frouta.Visibility=System.Windows.Visibility.Hidden;
			laxanika.Visibility=System.Windows.Visibility.Hidden;
			
			x_close_fridge.Visibility=System.Windows.Visibility.Visible;
			Random rnd = new Random();
            int number = rnd.Next(5);
            if (number == 0) 
            {
                JUICE.Visibility=System.Windows.Visibility.Visible;		
            }
            if (number == 1) 
            {
               kreata.Visibility=System.Windows.Visibility.Visible;
            }
			if (number == 2) 
            {
               milk.Visibility=System.Windows.Visibility.Visible;
            }
			if (number == 3) 
            {
               frouta.Visibility=System.Windows.Visibility.Visible;
            }
			if (number == 4) 
            {
               laxanika.Visibility=System.Windows.Visibility.Visible;
            }
		}

		private void x_close_fridge_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			frame_screen_fridje.Visibility=System.Windows.Visibility.Hidden;
			x_close_fridge.Visibility=System.Windows.Visibility.Hidden;
			JUICE.Visibility=System.Windows.Visibility.Hidden;		
			kreata.Visibility=System.Windows.Visibility.Hidden;
			milk.Visibility=System.Windows.Visibility.Hidden;
			frouta.Visibility=System.Windows.Visibility.Hidden;
			laxanika.Visibility=System.Windows.Visibility.Hidden;
			switch_off.Visibility=System.Windows.Visibility.Visible;
			
		}

		private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("House.xaml",UriKind.Relative));
		}

		 
	}
}