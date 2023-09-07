// See https://aka.ms/new-console-template for more information
using System;
namespace FacadeDesignPattern
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            IHotel hotel = new Hotel();
            ITicket ticket = new Ticket();
            
            ITravelPackageFacade travelPackageFacade = new TravelPackageFacade(hotel, ticket);

            Console.WriteLine("Select your travel package: ");

            travelPackageFacade.BookTravelPackage("Surat", 5, 4, "Flight" , "Gaya", "Surat");
        }
    }

}
