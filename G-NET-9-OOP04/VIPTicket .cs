using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_9_OOP03
{
    internal class VIPTicket: Ticket
    {
        bool loungeAcces;
        decimal servicefee = 50;
        public VIPTicket(string eventName, decimal price, bool loungeAcces) : base(eventName, price)
        {
            this.loungeAcces = loungeAcces;
        }

        public override string printticket()
        {
            return base.printticket() + $", VIP Ticket: Lounge Access: {loungeAcces}, Service Fee: {servicefee:C}";
        }

         
       
    }

}
