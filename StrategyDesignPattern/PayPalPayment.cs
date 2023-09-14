using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class PayPalPayment : IPayment
    {
        public void MakePayment(string paymentMethodName)
        {
            Console.WriteLine("Payment is done using " + paymentMethodName);
        }
    }
}
