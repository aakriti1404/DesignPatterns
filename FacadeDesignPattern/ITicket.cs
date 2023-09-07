using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public interface ITicket
    {
        void BookTicket(string meansOfTransport ,string departureLocation, string arrivalLocation);
    }
}
