using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class VegMeal : MealDecorator
    {
        public VegMeal(IHotel hotel) : base(hotel)
        {
        }

        public override void BookHotel(string Location, int numberOfDays, int numberOfNights)
        {
            base.BookHotel(Location, numberOfDays, numberOfNights);
            Console.WriteLine("Veg meal option added to the booking");
        }
    }
}
