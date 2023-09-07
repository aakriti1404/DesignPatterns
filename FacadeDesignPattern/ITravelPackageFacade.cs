using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public interface ITravelPackageFacade
    {
        public void BookTravelPackage(string location, int numberOfDays, int numberOfNights, string meansOfTransport, string departureLocation, string arrivalLocation);
    }
}
