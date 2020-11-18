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


using System.Text.RegularExpressions;


namespace Appalaktikh_ergasia_2016_2017
{
	
	public partial class Elderhouse
	{
		
        int i = 0;
        int a = 0;
		int kleinw=0;
		System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
			if(i==15  && frame_ambulance.IsVisible==false)
			{
				frame_ambulance.Visibility=System.Windows.Visibility.Visible;
				
				Random rnd = new Random();
                int number = rnd.Next(1);
			if(number==0)
			{
				t_siggenist_siggenis.Visibility=System.Windows.Visibility.Visible;
				 
			}
			if(number==1)
			{
			   t_koinonikes_ipiresies.Visibility=System.Windows.Visibility.Visible;	
			}
				
			}
			
			if(i>15)
			{
				i=0;
				a=0;
			}
			
            if (i <= 15 && t_number.IsVisible==true)
            {
                t_number.Text = i.ToString();
                i = i + 1;

            }
			
            if (a > 5)
			{
				a = 0;
				 
			}
			if (a == 5 && frame_smile.IsVisible==true)
            {
                frame_smile.Visibility=System.Windows.Visibility.Hidden;
				
            }
             
			if (a == 5 && frame_ambulance.IsVisible==true)
            {
                 
				frame_ambulance.Visibility=System.Windows.Visibility.Hidden; 
				t_koinonikes_ipiresies.Visibility=System.Windows.Visibility.Hidden;
				t_siggenist_siggenis.Visibility=System.Windows.Visibility.Hidden;
			
				 
            }
            a = a + 1;
           
            

        }
		public Elderhouse()
		{
			this.InitializeComponent();
			Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
			// Insert code required on object creation below this point.
		}

		private void Rectangle_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
            
			// TODO: Add event handler implementation here.
            if (vase1.IsVisible==false) 
            {
                
            }
            if (vase2.IsVisible == true)
            {

            }
			
		}

         

        private void yes_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			frame_smile.Visibility=System.Windows.Visibility.Visible;
			t_number.Visibility=System.Windows.Visibility.Hidden; 
			frame_patient.Visibility=System.Windows.Visibility.Hidden;
			
        }

        private void No_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			frame_ambulance.Visibility=System.Windows.Visibility.Visible;
			frame_smile.Visibility=System.Windows.Visibility.Hidden;
            t_number.Visibility = System.Windows.Visibility.Hidden;
			frame_patient.Visibility=System.Windows.Visibility.Hidden;
			
			
			Random rnd = new Random();
            int number = rnd.Next(1);
			if(number==0)
			{
				t_siggenist_siggenis.Visibility=System.Windows.Visibility.Visible;
				 
			}
			if(number==1)
			{
			   t_koinonikes_ipiresies.Visibility=System.Windows.Visibility.Visible;	
			}
			
        }

        private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			NavigationService.Navigate(new Uri("User1.xaml",UriKind.Relative));
			
        }

        

         
	}
}