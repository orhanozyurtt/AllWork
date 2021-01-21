using System;

namespace Example11
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            switch (sayi>= 5)
            {
                case true: Console.WriteLine("sayı 5  ten büyük veya eşit");break;
                case false:Console.WriteLine("sayı 5 ten küçük");break;
                default:
                    Console.WriteLine("hatalı değer");
                    break;
            }
        }
    }
}
