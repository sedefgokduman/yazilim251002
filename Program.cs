using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim251002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı girin");
            int sayi=Convert.ToInt32(Console.ReadLine());
            if (sayi%2==0 )
            {
                Console.WriteLine("çift sayı");
            }
            else
            {
                Console.WriteLine("tek sayı");
            }
            Console.ReadKey();
        }
    }
}
