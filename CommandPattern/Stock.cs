using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Stock //Receiver Object
    {
        public void Buy()
        {
            Console.WriteLine("Desired stock have been purchased");
        }
        public void Sell()
        {
            Console.WriteLine("Desired stock have been sold");
        }
    }
}
