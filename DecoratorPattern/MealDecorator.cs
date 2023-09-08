using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class MealDecorator : IHotel
    {
        protected IHotel hotel;
        public MealDecorator(IHotel hotel)
        {
            this.hotel = hotel;
        }
        
        public virtual void BookHotel(string Location, int numberOfDays, int numberOfNights)
        {
            hotel.BookHotel(Location, numberOfDays, numberOfNights);
        }
    }
}
