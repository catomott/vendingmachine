using System;
using System.Diagnostics;
using Company.VendingMachine;

namespace Company.VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine();

            Console.WriteLine("Vending Machine App in C#\r");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine(vendingMachine.Display(0.00M) + "\n");
            Console.WriteLine("Choose a coin from the list to insert:");
            Console.WriteLine("\tp - Penny");
            Console.WriteLine("\tn - Nickle");
            Console.WriteLine("\td - Dime");
            Console.WriteLine("\tq - Quarter \n");

            Console.Write("Your choice? \n");

            switch (Console.ReadLine())
            {
                case "p":
                    vendingMachine.InsertCoin(vendingMachine.Penny);
                    Console.WriteLine("Not a valid coin. \n");
                    Console.WriteLine("Check the Coin Return. \n");
                    break;
                case "n":
                    vendingMachine.InsertCoin(vendingMachine.Nickle);
                    break;
                case "d":
                    vendingMachine.InsertCoin(vendingMachine.Dime);
                    break;
                case "q":
                    vendingMachine.InsertCoin(vendingMachine.Quarter);
                    break;
            }

            Console.WriteLine("\n Amount: $" + vendingMachine.Display(vendingMachine.Amount) + "\n");



            Console.Write("Press any key to close the Vending Machine App...");
            Console.ReadLine();
        }
    }
}
