using System;

namespace PdfEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Bir sayı giriniz:yoksa program çalışmaz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if ((sayi % 3 == 0) && (sayi % 5 == 0))
            {
                Console.WriteLine("{0} sayısı hem 3'e hem de 5'e kalansız bölünebilir", sayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı hem 3'e hem de 5'e kalansız bölünemez", sayi);
            }

        }
    }
}
