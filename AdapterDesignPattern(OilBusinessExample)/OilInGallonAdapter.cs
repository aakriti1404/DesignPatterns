using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern_OilBusinessExample_
{
    public class OilInGallonAdapter : IOilInGallon
    {
        private OilInLiter oilInLiter = new OilInLiter();
        private double ConvertGallonToLiter(double quantityInGallon)
        {
            return quantityInGallon * 3.78541;
        }
        public double BuyOilInGallon(double quantityInGallon)
        {
            double oilInLiter = ConvertGallonToLiter(quantityInGallon);
            return oilInLiter;

        }
    }
}
