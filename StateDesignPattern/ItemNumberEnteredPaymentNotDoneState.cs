using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class ItemNumberEnteredPaymentNotDoneState : IVendingMachineState
    {
        public void EnterItemNumber()
        {
            Console.WriteLine("Item number entered.");
        }
        public void MakePayment()
        {
            Console.WriteLine("Payment not done.");
        }
        public void GetItem()
        {
            Console.WriteLine("You cannot get the item without doing payment.");
        }
    }
}
