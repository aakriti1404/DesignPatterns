using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Hotel : IHotel
    {
        public void BookHotel(string location, int numberOfDays, int numberOfNights)
        {
            Console.WriteLine("Hotel is booked at location " + location + " for " + numberOfDays + " days and " + numberOfNights+" nights.");
        }
    }
}
