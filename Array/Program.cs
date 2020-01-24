//5 ITN nr 3 Enrick De Munter
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGen = new Random();
            byte[] lottoCijfers = new byte[6];
            //6 wilekeurige getallen tussen 1 en 42
            for (int i = 0; i < 6; i++)
            {
                lottoCijfers[1] = (byte)randomGen.Next(1, 43);
            }

            Console.WriteLine();
            Console.WriteLine("originele getallen");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(lottoCijfers[i]);
            }

            Console.WriteLine();
            Console.WriteLine("gesorteerde getallen");

            Array.Sort(lottoCijfers);
            foreach (byte item in lottoCijfers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("aflopend gesorteerde getallen");
            
            foreach (byte item in lottoCijfers)
            {
                Console.WriteLine(item);
            }

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();

        }
    }
}
