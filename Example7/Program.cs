using System;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir gün giriniz");
            string day = Console.ReadLine().ToLower();

            switch (day)
            {
                case "pazartesi": Console.WriteLine("hafta içi");break;
                case "salı": Console.WriteLine("hafta içi"); break;
                case "çarşamba": Console.WriteLine("hafta içi"); break;
                case "perşembe": Console.WriteLine("hafta içi"); break;
                case "cuma": Console.WriteLine("hafta içi"); break;
                case "cumartesi": Console.WriteLine("hafta sonu"); break;
                case "pazar": Console.WriteLine("hafta sonu"); break;
                default: Console.WriteLine("hatalı bir değer girdiniz");
                    break;
            }
        }
    }
}
