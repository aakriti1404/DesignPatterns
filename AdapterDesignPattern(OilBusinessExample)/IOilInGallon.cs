using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern_OilBusinessExample_
{
    public interface IOilInGallon
    {
        public double BuyOilInGallon(double quantityInGallon);
    }
}
