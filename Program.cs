using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillInheretinceLab14
{
    class Program
    {
        static void Main(string[] args)
        {
            //codesnippit 1
            Bill bill1 = new Bill(15.80,0.06);
            Pay(bill1);

            //code snippit 2
            TippableBill bill2 = new TippableBill(8.50, 0.06, 2.00);
            Pay(bill2);

            //ending ;)
            Console.WriteLine("Press BACKSPACE + ALT to exit...");
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.Backspace || key.Modifiers != ConsoleModifiers.Alt)
            {
                key = Console.ReadKey(true);
            }
            System.Environment.Exit(0);
        }
        public static void Pay(Bill bill)
        {
            double total = bill.CalcTotal();
            Console.WriteLine($"${total}");
        }
    }
}
