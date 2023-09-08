using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Ticket :ITicket
    {
        public void BookTicket(string meansOfTransport, string departureLocation, string arrivalLocation)
        {
            Console.WriteLine("Your means of transportation is "+meansOfTransport+" and ticket is booked from " + departureLocation + " to " + arrivalLocation + " .");
        }
    }
}
