using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class NonVegMeal : MealDecorator
    {
        public NonVegMeal(IHotel hotel) : base(hotel)
        {
        }

        public override void BookHotel(string Location, int numberOfDays, int numberOfNights)
        {
            base.BookHotel(Location, numberOfDays, numberOfNights);
            Console.WriteLine("Non-veg meal option added to the booking");
        }
    }
}
