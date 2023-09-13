using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StockBroker //Invoker
    {
        private IStockTrade buyStock;
        private IStockTrade sellStock;

        public StockBroker(IStockTrade buy, IStockTrade sell)
        {
            this.buyStock = buy;
            this.sellStock = sell;
        }

        //The Invoker cannot handle the Request, so it internally calls the Trade Method of the Command Object. 
        public void StockBuy()
        {
            buyStock.StockTrade();
        }
        public void StockSell()
        {
            sellStock.StockTrade();
        }
    }
}
