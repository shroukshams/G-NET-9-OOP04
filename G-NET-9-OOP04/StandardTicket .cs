using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_9_OOP03
{
    internal class StandardTicket: Ticket

    {
        string SeatNumber;

        public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }
        public override string printticket( )
        {
            return base.printticket() + $", Standard Ticket: Seat Number: {SeatNumber}";
        }
    }
}
