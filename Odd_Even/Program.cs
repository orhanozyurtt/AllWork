using System;

namespace Odd_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("bir sayı girin :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("{0} sayısı çift sayıdır", sayi);
               
            }
            else
            {
                Console.WriteLine("{0} sayısı tek sayıdır", sayi);
              
            }
        }
    }
}
