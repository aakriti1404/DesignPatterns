using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface IVendingMachineState
    {
        void EnterItemNumber();
        void MakePayment();
        void GetItem();

    }
}
