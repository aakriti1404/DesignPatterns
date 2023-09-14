using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class ItemNumberEnteredPaymentDoneState : IVendingMachineState
    {
        public void EnterItemNumber()
        {
            Console.WriteLine("Item number entered.");
        }
        public void MakePayment()
        {
            Console.WriteLine("Payment done.");
        }
        public void GetItem()
        {
            Console.WriteLine("You can now get the item.");
        }
    }
}
