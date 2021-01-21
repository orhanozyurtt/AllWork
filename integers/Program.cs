using System;

namespace integers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir tam sayı giriniz:"); 
            int num = Convert.ToInt32(Console.ReadLine()); 
            if (num <0)
            {
                Console.WriteLine("{0} negatif",num);
            }
            else if (num>0)
            {
                Console.WriteLine("{0} sayı pozitif",num);
            }
            else if (num ==0)
            {
                Console.WriteLine("sayı sıfırdır. sıfır işaretsiz bir tam sayıdır");
            }
            else
            {
                Console.WriteLine("hatalı değer");
            }

        }
    }
}
