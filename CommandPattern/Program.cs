// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;

namespace CommandPattern
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //Create an Instance of Receiver
            Stock stock = new Stock();

            // Create the Command Object by passing the Receiver Instance
            IStockTrade buyStock = new BuyStock(stock);
            IStockTrade sellStock = new SellStock(stock);

            //Create the Invoker instance by passing the command objects
            StockBroker broker = new StockBroker(buyStock, sellStock);
            broker.StockBuy();
            broker.StockSell();

        }
    }
}
