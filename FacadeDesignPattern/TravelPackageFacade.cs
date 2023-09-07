using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class TravelPackageFacade : ITravelPackageFacade
    {
        private IHotel hotel;
        private ITicket ticket;
        public TravelPackageFacade(IHotel hotel, ITicket ticket)
        {
            this.hotel = hotel;
            this.ticket = ticket;
        }
        public void BookTravelPackage(string location, int numberOfDays, int numberOfNights, string meansOfTransport, string departureLocation, string arrivalLocation)
        {
            Console.WriteLine("Booking a travel package for you.");
            hotel.BookHotel(location, numberOfDays, numberOfNights);
            ticket.BookTicket(meansOfTransport, departureLocation, arrivalLocation);
            Console.WriteLine("Travel package booked successfully.");

        }

    }

}
