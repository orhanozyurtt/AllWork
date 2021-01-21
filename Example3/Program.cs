using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

           
            Console.WriteLine("rakamların sembolik görünümleri için okunuş olarak sayı giriniz");
            string sayi = (Console.ReadLine().ToLower());
            switch (sayi)
            {
                case "bir":
                    Console.WriteLine("1");
                    break;
                case "iki":
                    Console.WriteLine("2");
                    break;
                case "üç":
                    Console.WriteLine("3");
                    break;
                case "dört":
                    Console.WriteLine("4");
                    break;
                case "beş":
                    Console.WriteLine("5");
                    break;
                case "altı":
                    Console.WriteLine("6");
                    break;
                case "yedi":
                    Console.WriteLine("7");
                    break;
                case "sekiz":
                    Console.WriteLine("8");
                    break;
                case "dokuz":
                    Console.WriteLine("9");
                    break;
                case "on":
                        Console.WriteLine("10");
                        break;
                    default:
                    break;
            }
            } while (true);
        }
    }
}
