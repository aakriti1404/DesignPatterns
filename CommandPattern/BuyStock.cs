using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class BuyStock : IStockTrade //ConcreteCommand
    {
        //Reference of Receiver Object
        private Stock stock;

        //Initializing the Receiver Object using the Constructor
        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }

        //StockTrade Method will internally call the Receiver Object Buy Method
        public void StockTrade()
        {
            stock.Buy();
        }
    }
}
