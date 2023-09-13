using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class SellStock : IStockTrade //ConcreteCommand
    {
        //Reference of Receiver Object
        private Stock stock;

        //Initializing the Receiver Object using the Constructor
        public SellStock(Stock stock)
        {
            this.stock = stock;
        }

        //StockTrade Method will internally call the Receiver Object Sell Method
        public void StockTrade()
        {
            stock.Sell();
        }
    }
}
