using System;

namespace GainCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maaliyetinizi girin :");
            double maaliyet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kar oranını girin % :");
            double kar = Convert.ToDouble(Console.ReadLine());

            double satis = maaliyet + ((maaliyet * kar) / 100);
            Console.WriteLine("maaliyet = {0} \n kar yüzdesi = %{1} \n satış fiyatı={2}", maaliyet, kar, satis);
        }
    }
}
