using System;

namespace İfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

           
            int s1, s2, ort = 0;
            Console.WriteLine("1. sınav notu");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sınav notu");
            s2 = Convert.ToInt32(Console.ReadLine());

            ort = (s1 + s2) / 2;
            if (ort>=87 && ort<=100)
            {
                Console.WriteLine("AA");
            }
            else if (ort>=81 && ort<=87)
            {
                Console.WriteLine("BA");
            }
            else if (ort>=74 && ort<=80)
            {
                Console.WriteLine("BB");
            }
            else if (ort>=67 && ort<=73)
            {
                Console.WriteLine("CB");
            }
            else if (ort>60 && ort<=66)
            {
                Console.WriteLine("CC");
            }
            else if (ort>=53 && ort<=59)
            {
                Console.WriteLine("DC");
            }
            else if (ort>=46 && ort <= 52)
            {
                Console.WriteLine("DD");
            }
            else if (ort>=39 && ort<=45)
            {
                Console.WriteLine("FD");
            }
            else if (ort>=0 && ort<=38)
            {
                Console.WriteLine("FF");

            }
            } while (true);

        }
    }
}
