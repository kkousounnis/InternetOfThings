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
    

	public class onlynumbers
        {
            public bool checknumbers(String phone)
            {
                bool IsValid = false;
                if (String.IsNullOrEmpty(phone)) return false;
                Regex r = new Regex("[0-9]"+":"+"[0-5]"+"[0-9]");
				
                if (r.IsMatch(phone) )
                {
					 
                    IsValid = true;
					 
            
                }
                return IsValid;
            }


        }
	public partial class Programme
	{
		
		 System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();//gia to roloi
		public Programme()
		{
            
			this.InitializeComponent();
			Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
			// Insert code required on object creation below this point.
		}

        private void work_Checked(object sender, RoutedEventArgs e)
        {
            
			 
        }

        private void button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			
			
			work.Visibility=System.Windows.Visibility.Hidden;
			house.Visibility=System.Windows.Visibility.Hidden;
			University.Visibility=System.Windows.Visibility.Hidden;
			textblock_Pou_briskeste.Visibility=System.Windows.Visibility.Hidden;
			textblock_pou_pate.Visibility=System.Windows.Visibility.Visible;
			if(work.IsChecked==true)
			{
				house2.Visibility=System.Windows.Visibility.Visible;
				University1.Visibility=System.Windows.Visibility.Visible;
			}
			if(house.IsChecked==true)
			{
				work1.Visibility=System.Windows.Visibility.Visible;
				University1.Visibility=System.Windows.Visibility.Visible;
			}
			if(University.IsChecked==true)
			{
				work1.Visibility=System.Windows.Visibility.Visible;
				house2.Visibility=System.Windows.Visibility.Visible;
			}
			Button1.Visibility=System.Windows.Visibility.Visible; 
        }

        private void Button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			 work1.Visibility=System.Windows.Visibility.Hidden;
			
			 house2.Visibility=System.Windows.Visibility.Hidden;
			
			 University1.Visibility=System.Windows.Visibility.Hidden;
			 textblock_pou_pate.Visibility=System.Windows.Visibility.Hidden;
			Button1.Visibility=System.Windows.Visibility.Hidden;
			 textblock_arrival_time.Visibility=System.Windows.Visibility.Visible;
			 time_text.Visibility=System.Windows.Visibility.Visible;
             Button2.Visibility = System.Windows.Visibility.Visible;
	
        }
        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            clock.Content = d.Hour + ":" + d.Minute + ":" + d.Second;

        }

        private void Button2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			onlynumbers a =new onlynumbers();
            


            if (a.checknumbers(time_text.Text) )
			{
                if (time_text.Text.Length == 7)
                {
                    textblock_time.Text = time_text.Text;
					time_text.Visibility=System.Windows.Visibility.Hidden;
					textblock_arrival_time.Visibility=System.Windows.Visibility.Hidden;
					
					
					car.Visibility=System.Windows.Visibility.Visible;
					mmm.Visibility=System.Windows.Visibility.Visible;
					textblock_meso.Visibility=System.Windows.Visibility.Visible;
					Button2.Visibility=System.Windows.Visibility.Hidden;
					Button3.Visibility=System.Windows.Visibility.Visible;
                }
                else
                    MessageBox.Show("Παρακαλω πληκτολογήστε τον σωστό αριθμο ψηφιών xx:xx");
			}
			else
            {
                MessageBox.Show("Παρακαλώ πληκτρολογήσετε αριθμούς στην εξής μορφή xx:xx");
            }
			
			
			
        }

        private void Button3_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			car.Visibility=System.Windows.Visibility.Hidden;
			mmm.Visibility=System.Windows.Visibility.Hidden;
			textblock_meso.Visibility=System.Windows.Visibility.Hidden;
			Button3.Visibility=System.Windows.Visibility.Hidden;
			
			
			textblock_choosefood.Visibility=System.Windows.Visibility.Visible;
			Button4.Visibility=System.Windows.Visibility.Visible;
			Button5.Visibility=System.Windows.Visibility.Visible;
			
			frame_food.Visibility=System.Windows.Visibility.Visible;
			 
			
			
        }
         

        private void Button4_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            Button6.Visibility=System.Windows.Visibility.Visible;
            textblock_choosefood.Visibility = System.Windows.Visibility.Hidden;
            Button4.Visibility = System.Windows.Visibility.Hidden;
            Button5.Visibility = System.Windows.Visibility.Hidden;

            combo1.Visibility = System.Windows.Visibility.Visible;
            combo2.Visibility = System.Windows.Visibility.Visible;
            combo3.Visibility = System.Windows.Visibility.Visible;

            string[] comparetime;
            comparetime = new string[1];
            comparetime=textblock_time.Text.Split(':');//bazw se enan pinaka ton xrono pou 8elw na ftasw kai to xwrizw ekei poy exei : 
            if (int.Parse(comparetime[0]) < 12 && int.Parse(comparetime[0])>=8)
            {
				
				textbreakfast.Visibility= System.Windows.Visibility.Visible;
                textepiloges1.Visibility = System.Windows.Visibility.Visible;
                textepiloges2.Visibility = System.Windows.Visibility.Visible;
                textepiloges3.Visibility = System.Windows.Visibility.Visible;

                
                combo1.Items.Add("freddo esspresso");
                combo1.Items.Add("freddo capuccino");
                combo1.Items.Add("esspresso");
                combo1.Items.Add("ελληνικο");

                combo2.Items.Add("Τυρόπιτα");
                combo2.Items.Add("Μπουγατσα");
                combo2.Items.Add("Τοστ με ζαμπον");
                combo2.Items.Add("Αραβικη με κοτοπουλο");

                combo3.Items.Add("Κρουασαν σοκολατας");
                combo3.Items.Add("Κέικ σοκολατας");
                



            }
            if (int.Parse(comparetime[0]) >= 12 && (int.Parse(comparetime[0])<16)) 
            {
				textlunch.Visibility=System.Windows.Visibility.Visible;
                textepiloges4.Visibility = System.Windows.Visibility.Visible;
                textepiloges2.Visibility = System.Windows.Visibility.Visible;
                textepiloges3.Visibility = System.Windows.Visibility.Visible;

                textepiloges2.Visibility = System.Windows.Visibility.Visible;
				
                combo1.Items.Add("χοιρινο με ρυζι");
                combo1.Items.Add("κοτοπουλο με πατατες");
                combo1.Items.Add("σαλατα του καισσαρα");

                combo2.Items.Add("Αραβικη με κοτοπουλο");
                combo2.Items.Add("Sandwich με ζαμπον,ντοματα,τυρι και μαρουλι");
                combo2.Items.Add("Τοστ  ζαμπον και τυρί");
                combo2.Items.Add("Αραβικη με κοτοπουλο και sos");

                combo3.Items.Add("Μηλόπιτα");
                combo3.Items.Add("Τιγανήτες με μερεντα");
                combo3.Items.Add("Σουφλε σοκαλατας");
                
            }
            if (int.Parse(comparetime[0]) >= 16 && int.Parse(comparetime[0]) <21) 
            {
				textgluko.Visibility=System.Windows.Visibility.Visible;
                textepiloges1.Visibility = System.Windows.Visibility.Visible;
                textepiloges2.Visibility = System.Windows.Visibility.Visible;
                textepiloges3.Visibility = System.Windows.Visibility.Visible;
				
				
                combo1.Items.Add("σαλατα του καισσαρα");

                
                combo2.Items.Add("Αραβικη με κοτοπουλο και sos");

                combo3.Items.Add("Crepa σοκολατας");
                combo3.Items.Add("Βαφλα με σοκολατα");
                 
                 
            }
			if (int.Parse(comparetime[0]) >=21  ||  int.Parse(comparetime[0]) <= 8 )
			{
				frame_food.Visibility=System.Windows.Visibility.Hidden;
				frame_closed.Visibility=System.Windows.Visibility.Visible;
				
				combo1.Visibility = System.Windows.Visibility.Hidden;
            	combo2.Visibility = System.Windows.Visibility.Hidden;
            	combo3.Visibility = System.Windows.Visibility.Hidden;
			} 

            
        }

        private void Button5_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			frame_food.Visibility=System.Windows.Visibility.Hidden;
			textblock_choosefood.Visibility=System.Windows.Visibility.Hidden;
			Button4.Visibility=System.Windows.Visibility.Hidden;
			Button5.Visibility=System.Windows.Visibility.Hidden;
            
			string[] comparetime;
            comparetime = new string[1];
            comparetime = textblock_time.Text.Split(':');
            if (car.IsChecked == true)
            {
                if (int.Parse(comparetime[0]) >= 8)
                {
                    if ((int.Parse(comparetime[0]) == 10 && int.Parse(comparetime[1]) <= 30) || (int.Parse(comparetime[0]) < 10))
                    {
                        frame_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Mesogeiwn.Visibility = System.Windows.Visibility.Visible;
                    }

                }

                if (int.Parse(comparetime[0]) >= 15)
                {
                    if ((int.Parse(comparetime[0]) == 17 && int.Parse(comparetime[1]) <= 30) || (int.Parse(comparetime[0]) < 17))
                    {
                        frame_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Mesogeiwn.Visibility = System.Windows.Visibility.Visible;
                    }

                }

                if ((int.Parse(comparetime[0]) == 19 && int.Parse(comparetime[1]) >= 30) || (int.Parse(comparetime[0]) > 19))
                {
                    if (int.Parse(comparetime[0]) < 21)
                    {
                        frame_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Mesogeiwn.Visibility = System.Windows.Visibility.Visible;
                    }

                }

                if ((int.Parse(comparetime[0]) == 6 && int.Parse(comparetime[1]) <= 15) || (int.Parse(comparetime[0]) > 6))
                {
                    if (int.Parse(comparetime[0]) < 8)
                    {
                        frame_metria_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Kifisias.Visibility = System.Windows.Visibility.Visible;

                    }

                }

                if (int.Parse(comparetime[0]) >= 12)
                {
                    if (int.Parse(comparetime[0]) < 15)
                    {
                        frame_metria_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Kifisias.Visibility = System.Windows.Visibility.Visible;

                    }

                }
                if ((int.Parse(comparetime[0]) == 17 && int.Parse(comparetime[1]) > 30) || int.Parse(comparetime[0]) > 17)
                {
                    if ((int.Parse(comparetime[0]) == 19 && int.Parse(comparetime[1]) < 30) || (int.Parse(comparetime[0]) < 19))
                    {
                        frame_metria_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Kifisias.Visibility = System.Windows.Visibility.Visible;

                    }

                }
                if (int.Parse(comparetime[0]) >= 21)
                {
                    if ((int.Parse(comparetime[0]) == 23 && int.Parse(comparetime[1]) < 59) || (int.Parse(comparetime[0]) < 23))
                    {
                        frame_metria_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Kifisias.Visibility = System.Windows.Visibility.Visible;

                    }

                }
                if ((int.Parse(comparetime[0]) == 00 && int.Parse(comparetime[1]) >= 00) || int.Parse(comparetime[0]) > 00)
                {
                    if ((int.Parse(comparetime[0]) == 6 && int.Parse(comparetime[1]) < 15) || (int.Parse(comparetime[0]) < 6))
                    {
                        frame_katholou_kinisi.Visibility = System.Windows.Visibility.Visible;
						text_Kifissos.Visibility=System.Windows.Visibility.Visible;

                    }

                }

                if ((int.Parse(comparetime[0]) == 10 && int.Parse(comparetime[0]) > 30) || int.Parse(comparetime[0]) > 10)
                {

                    if (int.Parse(comparetime[0]) < 12)
                    {
                        frame_katholou_kinisi.Visibility = System.Windows.Visibility.Visible;
						text_Kifissos.Visibility=System.Windows.Visibility.Visible;
                    }

                }

            }
            else
            {
                if(int.Parse(comparetime[0])>=00 && int.Parse(comparetime[0])<=5)
				{
					frame_taxi.Visibility=System.Windows.Visibility.Visible;
					Button7.Visibility=System.Windows.Visibility.Visible;
					Button8.Visibility=System.Windows.Visibility.Visible;
					text_plhrofories_taxi.Visibility=System.Windows.Visibility.Visible;
				}
				if((int.Parse(comparetime[0])>=5 && int.Parse(comparetime[0])<=8) || (int.Parse(comparetime[0])>=18 && int.Parse(comparetime[0])<=23))
				{
					frame_leoforio.Visibility=System.Windows.Visibility.Visible;
                    text_time_diafora.Visibility = System.Windows.Visibility.Visible;
                    text_leoforio.Visibility = System.Windows.Visibility.Visible;
					int a=0;
                    if (int.Parse(comparetime[1]) < 30)
                    {
                        a = 30 - int.Parse(comparetime[1]);
                        
                    }
                    if (int.Parse(comparetime[1]) > 30)
                    {
                        a =  60-int.Parse(comparetime[1]);

                    }
                    if (int.Parse(comparetime[1]) == 30) 
                    {
                        a = 30;
                    }
                    text_time_diafora.Text = a.ToString()+"λεπτά";
                    
					 
				}
				if(int.Parse(comparetime[0])>=8 && int.Parse(comparetime[0])<=18)
				{
					frame_hlektrikos.Visibility=System.Windows.Visibility.Visible;
					text_ilektrikos_mnm.Visibility=System.Windows.Visibility.Visible;
				}
            }
			
        }

        private void Button6_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			frame_food.Visibility=System.Windows.Visibility.Hidden;
			textblock_choosefood.Visibility=System.Windows.Visibility.Hidden;
			combo1.Visibility=System.Windows.Visibility.Hidden;
			combo2.Visibility=System.Windows.Visibility.Hidden;
			combo3.Visibility=System.Windows.Visibility.Hidden;
			textepiloges1.Visibility=System.Windows.Visibility.Hidden;
			textepiloges2.Visibility=System.Windows.Visibility.Hidden;
			textepiloges3.Visibility=System.Windows.Visibility.Hidden;
			textepiloges4.Visibility=System.Windows.Visibility.Hidden;
			textbreakfast.Visibility=System.Windows.Visibility.Hidden;
			textlunch.Visibility=System.Windows.Visibility.Hidden;
			textgluko.Visibility=System.Windows.Visibility.Hidden;
			Button6.Visibility=System.Windows.Visibility.Hidden;
			frame_closed.Visibility=System.Windows.Visibility.Hidden;
			
			textparaggelia3.Visibility=System.Windows.Visibility.Visible;
			textparaggelia.Text=combo1.Text;
			textparaggelia1.Text=combo2.Text;
			textparaggelia2.Text=combo3.Text;


            string[] comparetime;
            comparetime = new string[1];
            comparetime = textblock_time.Text.Split(':');
            if (car.IsChecked == true)
            {
                if (int.Parse(comparetime[0]) >= 8)
                {
                    if ((int.Parse(comparetime[0]) == 10 && int.Parse(comparetime[1]) <= 30) || (int.Parse(comparetime[0]) < 10))
                    {
                        frame_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Mesogeiwn.Visibility = System.Windows.Visibility.Visible;
                    }

                }

                if (int.Parse(comparetime[0]) >= 15)
                {
                    if ((int.Parse(comparetime[0]) == 17 && int.Parse(comparetime[1]) <= 30) || (int.Parse(comparetime[0]) < 17))
                    {
                        frame_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Mesogeiwn.Visibility = System.Windows.Visibility.Visible;
                    }

                }

                if ((int.Parse(comparetime[0]) == 19 && int.Parse(comparetime[1]) >= 30) || (int.Parse(comparetime[0]) > 19))
                {
                    if (int.Parse(comparetime[0]) < 21)
                    {
                        frame_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Mesogeiwn.Visibility = System.Windows.Visibility.Visible;
                    }

                }

                if ((int.Parse(comparetime[0]) == 6 && int.Parse(comparetime[1]) <= 15) || (int.Parse(comparetime[0]) > 6))
                {
                    if (int.Parse(comparetime[0]) < 8)
                    {
                        frame_metria_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Kifisias.Visibility = System.Windows.Visibility.Visible;

                    }

                }

                if (int.Parse(comparetime[0]) >= 12)
                {
                    if (int.Parse(comparetime[0]) < 15)
                    {
                        frame_metria_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Kifisias.Visibility = System.Windows.Visibility.Visible;

                    }

                }
                if ((int.Parse(comparetime[0]) == 17 && int.Parse(comparetime[1]) > 30) || int.Parse(comparetime[0]) > 17)
                {
                    if ((int.Parse(comparetime[0]) == 19 && int.Parse(comparetime[1]) < 30) || (int.Parse(comparetime[0]) < 19))
                    {
                        frame_metria_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Kifisias.Visibility = System.Windows.Visibility.Visible;

                    }

                }
                if (int.Parse(comparetime[0]) >= 21)
                {
                    if ((int.Parse(comparetime[0]) == 23 && int.Parse(comparetime[1]) < 59) || (int.Parse(comparetime[0]) < 23))
                    {
                        frame_metria_kinisi.Visibility = System.Windows.Visibility.Visible;
                        text_Kifisias.Visibility = System.Windows.Visibility.Visible;

                    }

                }
                if ((int.Parse(comparetime[0]) == 00 && int.Parse(comparetime[1]) >= 00) || int.Parse(comparetime[0]) > 00)
                {
                    if ((int.Parse(comparetime[0]) == 6 && int.Parse(comparetime[1]) < 15) || (int.Parse(comparetime[0]) < 6))
                    {
                        frame_katholou_kinisi.Visibility = System.Windows.Visibility.Visible;
						text_Kifissos.Visibility=System.Windows.Visibility.Visible;

                    }

                }

                if ((int.Parse(comparetime[0]) == 10 && int.Parse(comparetime[0]) > 30) || int.Parse(comparetime[0]) > 10)
                {

                    if (int.Parse(comparetime[0]) < 12)
                    {
                        frame_katholou_kinisi.Visibility = System.Windows.Visibility.Visible;
						text_Kifissos.Visibility=System.Windows.Visibility.Visible;
                    }

                }

            }
            else
            {
                if(int.Parse(comparetime[0])>=00 && int.Parse(comparetime[0])<=5)
				{
					frame_taxi.Visibility=System.Windows.Visibility.Visible;
					Button7.Visibility=System.Windows.Visibility.Visible;
					Button8.Visibility=System.Windows.Visibility.Visible;
					text_plhrofories_taxi.Visibility=System.Windows.Visibility.Visible;
				}
				if((int.Parse(comparetime[0])>=5 && int.Parse(comparetime[0])<=8) || (int.Parse(comparetime[0])>=18 && int.Parse(comparetime[0])<=23))
				{
					frame_leoforio.Visibility=System.Windows.Visibility.Visible;
                    text_time_diafora.Visibility = System.Windows.Visibility.Visible;
                    text_leoforio.Visibility = System.Windows.Visibility.Visible;
					int a=0;
                    if (int.Parse(comparetime[1]) < 30)
                    {
                        a = 30 - int.Parse(comparetime[1]);
                        
                    }
                    if (int.Parse(comparetime[1]) > 30)
                    {
                        a =  60-int.Parse(comparetime[1]);

                    }
                    if (int.Parse(comparetime[1]) == 30) 
                    {
                        a = 30;
                    }
                    text_time_diafora.Text = a.ToString()+"λεπτά";
                    
					 
				}
				if(int.Parse(comparetime[0])>=8 && int.Parse(comparetime[0])<=18)
				{
					frame_hlektrikos.Visibility=System.Windows.Visibility.Visible;
					text_ilektrikos_mnm.Visibility=System.Windows.Visibility.Visible;
				}
            }

			
			
			
					
        }

        private void Button7_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			Button7.Visibility=System.Windows.Visibility.Hidden;
			Button8.Visibility=System.Windows.Visibility.Hidden;
			text_plhrofories_taxi.Visibility=System.Windows.Visibility.Hidden;
			
			text_wait.Visibility=System.Windows.Visibility.Visible;
			taxi_progressbar.Visibility=System.Windows.Visibility.Visible;
			
            
        }

        private void frame_taxi_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			if(taxi_progressbar.Value==100)
			{
				text_wait.Visibility=System.Windows.Visibility.Hidden;
			    taxi_progressbar.Visibility=System.Windows.Visibility.Hidden;
				text_taxi_eftase.Visibility=System.Windows.Visibility.Visible;
			}
        }

        private void Rectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			 NavigationService.Navigate(new Uri("User1_options.xaml",UriKind.Relative));
			
        }

        private void Button8_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			text_plhrofories_taxi.Visibility=System.Windows.Visibility.Hidden;
			frame_taxi.Visibility=System.Windows.Visibility.Hidden;
			Button7.Visibility=System.Windows.Visibility.Hidden;
			Button8.Visibility=System.Windows.Visibility.Hidden;
        }

        
	}
}