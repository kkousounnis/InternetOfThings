﻿using System;
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
	public partial class User1_options
	{
		public User1_options()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("Programme.xaml",UriKind.Relative));
		}

		private void rectangle1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("House.xaml",UriKind.Relative));
		}

        private void door_open_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void door_closed_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void door_open_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			 NavigationService.Navigate(new Uri("User1.xaml", UriKind.Relative));
        }

        private void online_help_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	t_help.Visibility=System.Windows.Visibility.Visible;
			x.Visibility=System.Windows.Visibility.Visible;// TODO: Add event handler implementation here.
        }

        private void x_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	t_help.Visibility=System.Windows.Visibility.Hidden;
			x.Visibility=System.Windows.Visibility.Hidden;// TODO: Add event handler implementation here.
        }

        
	}
}