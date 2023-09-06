using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern_OilBusinessExample_
{
    public class OilInLiter
    {
        private double oilPrice;

        public OilInLiter()
        {
        }

        public OilInLiter(double quantityInLiter)
        {
            this.oilPrice = quantityInLiter * 1.49; //price is 1.49 dollars per liter
            Console.WriteLine("Total cost of purchase is " + oilPrice + " dollars.");
            Console.WriteLine("Purchase Complete");
        }
    }
}
