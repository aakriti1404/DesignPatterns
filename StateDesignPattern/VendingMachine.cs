using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class VendingMachine : IVendingMachineState
    {
        public IVendingMachineState vendingMachineState;
        public VendingMachine()
        {
            vendingMachineState = new ItemNumberNotEnteredState();
        }

        public void SetState(IVendingMachineState state)
        {
            vendingMachineState = state;
        }
        public void EnterItemNumber()
        {
            vendingMachineState.EnterItemNumber();
        }
        public void MakePayment()
        {
            vendingMachineState.MakePayment();
        }
        public void GetItem()
        {
            vendingMachineState.GetItem();
        }
    }
}
