using System;

namespace PercentCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            etiket:
            double numb = 0,percent=0,result=0;
            Console.WriteLine("yüzdesini hesaplamak istediğiniz sayıyı girin :");
            numb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("yüzdelik oranını girin:");
            percent = Convert.ToDouble(Console.ReadLine());

            result = (numb * percent) / 100;
            Console.WriteLine("{0} sayısının %{1} = {2}", numb, percent, result);
            goto etiket;
        }
    }
}
