using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace Reservation
{
    public class Seat
    {

        private string name;
        private string customer;
        private Button btn;
     
        private bool isBooked;

        public Seat()
        {
            name = "";
            customer = "";
            isBooked = false;
            btn = new Button();
        }

        public Seat(string name, string customer, Button btn)
        {
            this.name = name;
            this.customer = customer;
            this.btn = btn;
            this.isBooked = false;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }


        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        [XmlIgnore]
        public Button Btn
        {
            get => btn;
            set => btn = value;
        }


        public void Reserve(string customer)
        {
            this.customer = customer;
            this.btn.Content = customer;
            this.isBooked = true;
        }

        

        public void Remove()
        {
            customer = "";
            btn.Content = name;
            isBooked = false;
        }

        public bool IsBookedCheck()
        {
            return this.isBooked;
        }

        public override string ToString()
        {
            return string.Format("Customer Name: {0}, Seat Number : {1}", customer, name);
        }


    }
}

