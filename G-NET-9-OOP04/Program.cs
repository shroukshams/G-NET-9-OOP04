using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Principal;

namespace G_NET_9_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //////Answers:
            //////a) Composition (The University and Departments have a strong lifecycle dependency. If the University is closed, the Departments cease to exist.)
            //////b) Association (The Driver and Car have a weak relationship. The Driver uses the Car but does not own it, and the Car can exist independently of the Driver.)
            //////c) Inheritance (A Dog is a specific type of Animal, indicating an "is-a" relationship where Dog inherits from Animal.)
            //////d) Aggregation (The Team and Players have a weak relationship. The Team can exist without the Players, and the Players can exist without the Team.)
            //////e) Dependency (The method depends on the Logger to perform its function, but the Logger is not a part of the method's lifecycle. The method uses the Logger temporarily and does not maintain a long-term relationship with it.)

            #endregion
            #region Q2  Q2 : Answer the following questions about access modifiers and sealed:



            ////Answers:
            ////a) A child class in a different assembly cannot access a protected field directly. However, it can access it through inheritance. An object instance from outside cannot access the protected field at all.
            ////b) protected internal allows access to the member from any class in the same assembly or from derived classes in any assembly. private protected allows access only from derived classes within the same assembly.
            ////c) When applied to a class, the sealed keyword prevents other classes from inheriting from it. When applied to a method, it prevents derived classes from overriding that method.
            ////d) Yes, you can create an object from a sealed class using new. The sealed keyword only prevents inheritance, not instantiation. You can still create instances of a sealed class as long as it has a public constructor.


            #endregion


            #region part2
            #region Extending the Movie Ticket Booking System
           
             Cinema cinema = new Cinema();
                cinema.OpenCinema();
            Console.WriteLine("Cinema opened.");
            Console.WriteLine("----------------------------");

            // Create one StandardTicket, one VIPTicket, and one IMAXTicket.
            StandardTicket standardTicket = new StandardTicket("Standard", 10, "A-4");
            VIPTicket vipTicket = new VIPTicket("VIP", 20, true);
            IMAXTicket imaxTicket = new IMAXTicket("IMAX", 30, is3D: true);

            // Test both versions of SetPrice on one ticket.
            standardTicket.SetPrice(10);
            standardTicket.SetPrice(12);

            // Add all tickets to the Cinema and call PrintAllTickets().
            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);
            cinema.PrintAllTickets();

            // Call ProcessTicket() with one of the tickets.
            Cinema.ProcessTicket(standardTicket);
            Console.WriteLine("----------------------------");
            // Close the Cinema.
            cinema.CloseCinema();

            #endregion
            #endregion
        }
    }
}