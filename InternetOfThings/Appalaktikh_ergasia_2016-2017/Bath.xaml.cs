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
	public partial class Bath
	{
		public Bath()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

		private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("House.xaml",UriKind.Relative));
		}
	}
}