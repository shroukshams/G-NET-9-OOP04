using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_9_OOP03
{
    internal class IMAXTicket : Ticket
    {
        bool is3D;

        public IMAXTicket(string movieName, decimal price, bool is3D) : base(movieName, price)
        {
            this.is3D = is3D;
            if (is3D == true)
            {
                Price += 30; // Increase price by 30 EGP if it's a 3D ticket
            }
        }

        public override string printticket()
        {
            return base.printticket() + $", IMAX Ticket: Is 3D: {is3D   }";
        }
    }
}
