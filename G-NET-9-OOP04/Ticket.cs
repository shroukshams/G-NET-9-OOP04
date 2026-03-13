using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace G_NET_9_OOP03
{
    internal class Ticket
    {
         public string MovieName;
        private decimal _price;
        private static int _ticketid=1;
        private static int _counter=0;
        public int Ticketid
        {
            get { return   _ticketid; }
        }
        public decimal Price
        {
            get
            { return _price; }

            set
            {
                if (value > 0)
                { _price = value; }
                else
                { Console.WriteLine("please int postive number "); }
            }
        }
        // add constructor
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            _ticketid= ++_counter;
        }

        // PriceAfterTax
        public decimal PriceAfterTax()
        {
            return Price +(Price*0.14m); // Assuming a tax rate of 14%
        }

        public virtual string printticket()
        {
            return $"Ticket ID: {Ticketid}, Movie Name: {MovieName}, Price: {Price:C}, Price After Tax: {PriceAfterTax():C}";
        }   
         public static int GetTotalTickets()
        {
                        return _counter;
        }

    
        public void SetPrice(decimal newPrice)
        {
            Price = newPrice;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }



    }
    }

