using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class ItemNumberNotEnteredState : IVendingMachineState
    {
        public void EnterItemNumber()
        {
            Console.WriteLine("Item number not inserted.");
        }
        public void MakePayment()
        {
            Console.WriteLine("You cannot make payment without entering the item number.");
        }
        public void GetItem()
        {
            Console.WriteLine("You cannot get the item without entering the item number.");
        }
    }
}
