using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern_OilBusinessExample_
{
    public class OilInGallon
    {
        private double oilPrice;
        public OilInGallon(double quantityInGallon)
        { 
            this.oilPrice = quantityInGallon * 2.98; //price is 2.98 dollars per liter
            Console.WriteLine("Total cost of purchase is " + oilPrice + " dollars.");
            Console.WriteLine("Purchase Complete");
        }
    }
}
