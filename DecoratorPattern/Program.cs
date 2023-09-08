// See https://aka.ms/new-console-template for more information
using System;
namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHotel hotel = new Hotel();
            ITicket ticket = new Ticket();
            IHotel hotelWithVegMeal = new VegMeal(hotel);
            IHotel hotelWithNonVegMeal = new NonVegMeal(hotel);

            //IMeal nonVegOption = new NonVegMeal();

            ITravelPackageFacade travelPackageFacade = new TravelPackageFacade(hotel, ticket);

            Console.WriteLine("Select your travel package: ");

            travelPackageFacade.BookTravelPackage("Surat", 5, 4, "Flight", "Gaya", "Surat");

            Console.WriteLine("Select your travel package where hotel is providing Veg meal option: ");
            hotelWithVegMeal.BookHotel("Surat", 5, 4);

            Console.WriteLine("Select your travel package where hotel is providing Non-Veg meal option: ");
            hotelWithNonVegMeal.BookHotel("Surat", 5, 4);

        }
    }

}
