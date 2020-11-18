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
using System.Media;

 



namespace Appalaktikh_ergasia_2016_2017
{
     
	public partial class House
	{
		
		public House()
		{
			this.InitializeComponent();
            // Insert code required on object creation below this point.
            
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            
			  
		}

		private void on_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			 
             
			
		}

		private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("User1_options.xaml",UriKind.Relative));
		}

		 

		private void play_song_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			SoundPlayer s = new SoundPlayer("gonnaflynow.wav");
            s.Play();
		}

		private void pause_song_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
            SoundPlayer s = new SoundPlayer("gonnaflynow.wav");
			s.Stop();
		}

        private void kitchen_door_closed_MouseDown(object sender, MouseButtonEventArgs e)
        {
            				
        }

        private void kitchen_door_open_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("Kitchen.xaml",UriKind.Relative));
        }

        private void toilet_door_open_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("Bath.xaml",UriKind.Relative));
        }

        

		
	}
}