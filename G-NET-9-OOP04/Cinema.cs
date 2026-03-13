using G_NET_9_OOP03;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_9_OOP03
{
    internal class Cinema
    {


       // Create a `Cinema` class that holds up to 20 tickets using a private array.
        private Ticket[] _tickets = new Ticket[20];




    //Adds a ticket to the first available slot
    public bool AddTicket(Ticket t)
    {
        for (int i = 0; i < _tickets.Length; i++)
        {
            if (_tickets[i] == null)
            {
                _tickets[i] = t;
                return true;
            }
        }
        return false; // Cinema is full
    }

      
        public void OpenCinema()
    {
        Console.WriteLine("=======================Cinema is now open==========");
        Console.WriteLine("The projector is on.");
    }

    



    public void CloseCinema()
    {
        Console.WriteLine("===========Cinema is now closed============");
        Console.WriteLine("The projector is off.");

    }


       // In the Cinema class, update PrintAllTickets() so it loops through the Ticket[] array and calls PrintTicket() on each one.
       public void PrintAllTickets()
        {
            Console.WriteLine("--------------------allTickets--------");

            foreach (var ticket in _tickets)
           {
                if (ticket != null)
               {
                   ProcessTicket(ticket);
               }
            }
            Console.WriteLine($"Number of Tickets: {Ticket.GetTotalTickets()}");

        }
        //4. Create a static method ProcessTicket(Ticket t) that takes any Ticket and calls PrintTicket() on it.
        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine(t.printticket());
        }


    }
}

