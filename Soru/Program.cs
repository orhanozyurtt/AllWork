using System;

namespace Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen sayının hem 2 ye hem de 3 kalansız bölünüp bölünmediğini bildiren programı yazınız 

            Console.WriteLine("bir sayı girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if ((sayi % 2==0) && (sayi % 3 ==0))
            {
                Console.WriteLine("{0} sayısı 2 ye ve 3 e kalansız bölündü",sayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı 2 ye ve 3 e kalansız bölünmüyor", sayi);
            }
           

        }
    }
}
