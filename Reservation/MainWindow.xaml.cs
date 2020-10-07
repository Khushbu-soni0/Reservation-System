using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace Reservation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Seat seat1;
        Seat seat2;
        Seat seat3;
        Seat seat4;
        Seat seat5;

        Seat seat6;
        Seat seat7;
        Seat seat8;
        Seat seat9;
        Seat seat10;

        Seat seat11;
        Seat seat12;
        Seat seat13;
        Seat seat14;
        Seat seat15;
        Seat seat16;
        private Seat[] mySeats = new Seat[16];
        private Seat[] mybookedSeat;

        //private object btn;

        // static int[] tempbookseat;

        public MainWindow()
        {

            InitializeComponent();

            //bookedseat = new int[16];
            seat1 = new Seat("1", "", btn1);
            seat2 = new Seat("2", "", btn2);
            seat3 = new Seat("3", "", btn3);
            seat4 = new Seat("4", "", btn4);
            seat5 = new Seat("5", "", btn5);

            seat6 = new Seat("6", "", btn6);
            seat7 = new Seat("7", "", btn7);
            seat8 = new Seat("8", "", btn8);
            seat9 = new Seat("9", "", btn9);
            seat10 = new Seat("10", "", btn10);

            seat11 = new Seat("11", "", btn11);
            seat12 = new Seat("12", "", btn12);
            seat13 = new Seat("13", "", btn13);
            seat14 = new Seat("14", "", btn14);
            seat15 = new Seat("15", "", btn15);

            seat16 = new Seat("16", "", btn16);

            
            mySeats[0] = seat1;
            mySeats[1] = seat2;
            mySeats[2] = seat3;
            mySeats[3] = seat4;

            mySeats[4] = seat5;
            mySeats[5] = seat6;
            mySeats[6] = seat7;
            mySeats[7] = seat8;
            mySeats[8] = seat9;
            mySeats[9] = seat10;
            mySeats[10] = seat11;
            mySeats[11] = seat12;
            mySeats[12] = seat13;

            mySeats[13] = seat14;
            mySeats[14] = seat15;
            mySeats[15] = seat16;

           
        }


        private void WriteToFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Seat[]));
            TextWriter tw = new StreamWriter("seat.xml");
            serializer.Serialize(tw, mySeats);
            tw.Close();
        }

        private void ReadFromFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Seat[]));
            TextReader tr = new StreamReader("seat.xml");
            mybookedSeat = (Seat[])serializer.Deserialize(tr);
            tr.Close();
            NewButton();


        }
        private void NewButton()
        {
            
            mybookedSeat[0].Btn = btn1;
            mybookedSeat[1].Btn = btn2;
            mybookedSeat[2].Btn = btn3;
            mybookedSeat[3].Btn = btn4;
            mybookedSeat[4].Btn = btn5;
            mybookedSeat[5].Btn = btn6;
            mybookedSeat[6].Btn = btn7;
            mybookedSeat[7].Btn = btn8;
            mybookedSeat[8].Btn = btn9;
            mybookedSeat[9].Btn = btn10;
            mybookedSeat[10].Btn = btn11;
            mybookedSeat[11].Btn = btn12;
            mybookedSeat[12].Btn = btn13;
            mybookedSeat[13].Btn = btn14;
            mybookedSeat[14].Btn = btn15;
            mybookedSeat[15].Btn = btn16;
            for (int i = 0; i < 16; i++)
            {
                if (mybookedSeat[i].Customer!="")
                {

                    mySeats[i].Reserve(mybookedSeat[i].Customer);
                    mySeats[i].Btn.Background = Brushes.Red;
                }
            }

        }
        private void btnReserve_Click(object sender, RoutedEventArgs e)
        {


            if (tbCustomer.Text != "")
            {

                if (btn1.Background == Brushes.Green)
                {
                    seat1.Reserve(tbCustomer.Text);
                    btn1.Background = Brushes.Red;
                   // this.listName.Text += seat1.ToString() + "\n";

                }

                if (btn2.Background == Brushes.Green)
                {
                    seat2.Reserve(tbCustomer.Text);
                    btn2.Background = Brushes.Red;
                    //this.listName.Text += seat2.ToString() + "\n";
                }

                if (btn3.Background == Brushes.Green)
                {
                    seat3.Reserve(tbCustomer.Text);
                    btn3.Background = Brushes.Red;
                   // this.listName.Text += seat3.ToString() + "\n";
                }

                if (btn4.Background == Brushes.Green)
                {
                    seat4.Reserve(tbCustomer.Text);
                    btn4.Background = Brushes.Red;
                   // this.listName.Text += seat4.ToString() + "\n";
                }

                if (btn5.Background == Brushes.Green)
                {
                    seat5.Reserve(tbCustomer.Text);
                    btn5.Background = Brushes.Red;
                    //this.listName.Text += seat5.ToString() + "\n";
                }

                if (btn6.Background == Brushes.Green)
                {
                    seat6.Reserve(tbCustomer.Text);
                    btn6.Background = Brushes.Red;
                    //this.listName.Text += seat6.ToString() + "\n";
                }

                if (btn7.Background == Brushes.Green)
                {
                    seat7.Reserve(tbCustomer.Text);
                    btn7.Background = Brushes.Red;
                   // this.listName.Text += seat7.ToString() + "\n";
                }

                if (btn8.Background == Brushes.Green)
                {
                    seat8.Reserve(tbCustomer.Text);
                    btn8.Background = Brushes.Red;
                    //this.listName.Text += seat8.ToString() + "\n";
                }

                if (btn9.Background == Brushes.Green)
                {
                    seat9.Reserve(tbCustomer.Text);
                    btn9.Background = Brushes.Red;
                   // this.listName.Text += seat9.ToString() + "\n";
                }

                if (btn10.Background == Brushes.Green)
                {
                    seat10.Reserve(tbCustomer.Text);
                    btn10.Background = Brushes.Red;
                   // this.listName.Text += seat10.ToString() + "\n";
                }

                if (btn11.Background == Brushes.Green)
                {
                    seat11.Reserve(tbCustomer.Text);
                    btn11.Background = Brushes.Red;
                   // this.listName.Text += seat11.ToString() +"\n";
                }

                if (btn12.Background == Brushes.Green)
                {
                    seat12.Reserve(tbCustomer.Text);
                    btn12.Background = Brushes.Red;
                    //this.listName.Text += seat12.ToString() + "\n";
                }

                if (btn13.Background == Brushes.Green)
                {
                    seat13.Reserve(tbCustomer.Text);
                    btn13.Background = Brushes.Red;
                   // this.listName.Text += seat13.ToString() + "\n";
                }

                if (btn14.Background == Brushes.Green)
                {
                    seat14.Reserve(tbCustomer.Text);
                    btn14.Background = Brushes.Red;
                   // this.listName.Text += seat14.ToString() + "\n";
                }

                if (btn15.Background == Brushes.Green)
                {
                    seat15.Reserve(tbCustomer.Text);
                    btn15.Background = Brushes.Red;
                   // this.listName.Text += seat15.ToString() + "\n";
                }

                if (btn16.Background == Brushes.Green)
                {
                    seat16.Reserve(tbCustomer.Text);
                    btn16.Background = Brushes.Red;
                   // this.listName.Text += seat16.ToString() + "\n";
                }

                if (seat1.IsBookedCheck() && seat2.IsBookedCheck() && seat3.IsBookedCheck() && seat4.IsBookedCheck() && seat5.IsBookedCheck() && seat6.IsBookedCheck() && seat7.IsBookedCheck() && seat8.IsBookedCheck() && seat9.IsBookedCheck() && seat10.IsBookedCheck() && seat11.IsBookedCheck() && seat12.IsBookedCheck() && seat13.IsBookedCheck() && seat14.IsBookedCheck() && seat15.IsBookedCheck() && seat16.IsBookedCheck())
                {
                    MessageBox.Show("All the seats are Reserved");
                }

            }
            tbCustomer.Text = "";
            //MessageBox.Show("Please select the seats");

            


        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (!seat1.IsBookedCheck())
            {
                btn1.Background = Brushes.Green;
                btn1.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat1.Remove();
                    btn1.Background = Brushes.LightGray;
                   
                }
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (!seat2.IsBookedCheck())
            {
                btn2.Background = Brushes.Green;
                btn2.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat2.Remove(); 
                    btn2.Background = Brushes.LightGray;
                    
                }

            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (!seat3.IsBookedCheck())
            {
                btn3.Background = Brushes.Green;
                btn3.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat3.Remove();
                    btn3.Background = Brushes.LightGray;
                   
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (!seat4.IsBookedCheck())
            {
                btn4.Background = Brushes.Green;
                btn4.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat4.Remove();
                    btn4.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (!seat5.IsBookedCheck())
            {
                btn5.Background = Brushes.Green;
                btn5.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                 "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat5.Remove();
                    btn5.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (!seat6.IsBookedCheck())
            {
                btn6.Background = Brushes.Green;
                btn6.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat6.Remove();
                    btn6.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (!seat7.IsBookedCheck())
            {
                btn7.Background = Brushes.Green;
                btn7.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                 "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat7.Remove();
                    btn7.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (!seat8.IsBookedCheck())
            {
                btn8.Background = Brushes.Green;
                btn8.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat8.Remove();
                    btn8.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (!seat9.IsBookedCheck())
            {
                btn9.Background = Brushes.Green;
                btn9.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat9.Remove();
                    btn9.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            if (!seat10.IsBookedCheck())
            {
                btn10.Background = Brushes.Green;
                btn10.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat10.Remove();
                    btn10.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn11_Click(object sender, RoutedEventArgs e)
        {
            if (!seat11.IsBookedCheck())
            {
                btn11.Background = Brushes.Green;
                btn11.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                 "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat11.Remove();
                    btn11.Background = Brushes.LightGray;
                   
                }
            }
        }

        private void btn12_Click(object sender, RoutedEventArgs e)
        {
            if (!seat12.IsBookedCheck())
            {
                btn12.Background = Brushes.Green;
                btn12.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat12.Remove();
                    btn12.Background = Brushes.LightGray;
                    WriteToFile();
                }
            }
        }

        private void btn13_Click(object sender, RoutedEventArgs e)
        {
            if (!seat13.IsBookedCheck())
            {
                btn13.Background = Brushes.Green;
                btn13.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat13.Remove();
                    btn13.Background = Brushes.LightGray;
                 
                }
            }
        }

        private void btn14_Click(object sender, RoutedEventArgs e)
        {
            if (!seat14.IsBookedCheck())
            {
                btn14.Background = Brushes.Green;
                btn14.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat14.Remove();
                    btn14.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn15_Click(object sender, RoutedEventArgs e)
        {
            if (!seat15.IsBookedCheck())
            {
                btn15.Background = Brushes.Green;
                btn15.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                 "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat15.Remove();
                    btn15.Background = Brushes.LightGray;
                    
                }
            }
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            if (!seat16.IsBookedCheck())
            {
                btn16.Background = Brushes.Green;
                btn16.IsEnabled = true;
            }
            else
            {
                if (MessageBox.Show("Seat is already booked. Do you want to un-Reserved it?",
                "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    seat16.Remove();
                    btn16.Background = Brushes.LightGray;
                   
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

            seat1.Remove();
            btn1.Background = Brushes.LightGray;
            seat2.Remove();
            btn2.Background = Brushes.LightGray;
            seat3.Remove();
            btn3.Background = Brushes.LightGray;
            seat4.Remove();
            btn4.Background = Brushes.LightGray;
            seat5.Remove();
            btn5.Background = Brushes.LightGray;
            seat6.Remove();
            btn6.Background = Brushes.LightGray;
            seat7.Remove();
            btn7.Background = Brushes.LightGray;
            seat8.Remove();
            btn8.Background = Brushes.LightGray;
            seat9.Remove();
            btn9.Background = Brushes.LightGray;
            seat10.Remove();
            btn10.Background = Brushes.LightGray;
            seat11.Remove();
            btn11.Background = Brushes.LightGray;
            seat12.Remove();
            btn12.Background = Brushes.LightGray;
            seat13.Remove();
            btn13.Background = Brushes.LightGray;
            seat14.Remove();
            btn14.Background = Brushes.LightGray;
            seat15.Remove();
            btn15.Background = Brushes.LightGray;
            seat16.Remove();
            btn16.Background = Brushes.LightGray;

        }

        private void btnLinq1_Click(object sender, RoutedEventArgs e)
        {
            var query = from seat in mySeats
                        orderby seat.Customer descending
                        select seat;
             listName.Items.Clear();

            foreach (Seat s in query)
            {
                if (s.IsBookedCheck())
                {
                    Console.WriteLine("Name: {0}, customer: {1}", s.Name, s.Customer);
                    listName.Items.Add(s.Customer);
                }

            }

        }

        private void btnLinq2_Click(object sender, RoutedEventArgs e)
        {
            var query1 = from seat in mySeats
                        orderby seat.Customer.Length ascending
                        select seat;
            listName.Items.Clear();

            foreach (Seat s in query1)
            {
                if(s.IsBookedCheck())
                {
                    Console.WriteLine("Name: {0}, customer: {1}", s.Name, s.Customer);
                    listName.Items.Add(s.Customer);
                }
                
            }

        }

        private void btnLinq3_Click(object sender, RoutedEventArgs e)
        {

            var query2 = from seat in mySeats
                        select seat;
            listName.Items.Clear();

            foreach (Seat s in query2)
            {
                if (!s.IsBookedCheck())
                {
                    Console.WriteLine("Seat No.: {0}", s.Name);
                    listName.Items.Add(s.Name);
                }
            }
            

        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            WriteToFile();
            MessageBox.Show("Data is saved");
        }

        private void btnload_Click(object sender, RoutedEventArgs e)
        {

            if (File.Exists("seat.xml"))
            {
                ReadFromFile();
            }

        }
    }



}
