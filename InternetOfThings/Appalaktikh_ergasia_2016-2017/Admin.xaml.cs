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
	public partial class Admin
	{
		public Admin()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void meds_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			combo.Items.Add("Depon");
			combo.Items.Add("Lexotanil");
			combo.Items.Add("Bitamini");
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			MessageBox.Show("Εγινε");
		}

		private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			MessageBox.Show("Done");
		}

		private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			MessageBox.Show("Done");
		}

		private void Button_Click_3(object sender, System.Windows.RoutedEventArgs e)
		{
			MessageBox.Show("Done");// TODO: Add event handler implementation here.
		}

		private void leave_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("User1.xaml",UriKind.Relative));
		}
	}
}