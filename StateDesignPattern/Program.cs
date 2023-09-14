// See https://aka.ms/new-console-template for more information
using System;
namespace StateDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            Console.WriteLine("Vending Machine current state: "+vendingMachine.vendingMachineState.GetType().Name);
            Console.WriteLine();

            vendingMachine.MakePayment();
            vendingMachine.GetItem();
            //vendingMachine.EnterItemNumber();
            Console.WriteLine();

            vendingMachine.SetState(new ItemNumberEnteredPaymentNotDoneState());
            Console.WriteLine("Vending Machine current state: " + vendingMachine.vendingMachineState.GetType().Name);
            vendingMachine.MakePayment();
            vendingMachine.GetItem();
            Console.WriteLine();


            vendingMachine.SetState(new ItemNumberEnteredPaymentDoneState());
            Console.WriteLine("Vending Machine current state: " + vendingMachine.vendingMachineState.GetType().Name);
            vendingMachine.MakePayment();
            vendingMachine.GetItem();
            Console.Read();
        }
    }
}
