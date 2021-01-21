using System;

namespace ForEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayıların toplamını ekrana yazıran program 
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam += i;

            }
            Console.WriteLine("1'den 10'a kadar olan sayıların toplamı = {0}", toplam);
        }
    }
}
