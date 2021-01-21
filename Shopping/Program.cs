using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //ödeme tutarınız 100 tl nin altındaysa direk tutarı gösteren değilse ödeme tutarına 5 tl kargo ekleyip kullanıcıya gösteren programı yazın ?
            double tutar;
            Console.WriteLine("ürünün fiyatını giriniz :");
            tutar = Convert.ToDouble(Console.ReadLine());
            if (tutar <=100)
            {
                Console.WriteLine("ödeme tutarınız={0} tl", tutar);
            }
            else
            {
                Console.WriteLine("ödeme tutarınız={0} tl  kargo=5 tl  ", tutar + 5);
            }
            

        }
    }
}
