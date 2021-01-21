using System;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             bir üniversitede öğrencilerin ortalmaları 50 ve üzeri ise dersten başarılı sayılmaktadır
            öğrencilerin vize notu ortalamaya %40 final notu %60 etki ettiğine böre öğrencilerin ers başarı durumlarını
            hesaplayan programı yazın
             */
            Console.WriteLine("vize notunu girin: ");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notunu girin :");
            int final = Convert.ToInt32(Console.ReadLine());

            double ortlama = ((vize * 40) / 100) + ((final * 60) / 100);
            if (ortlama>=50)
            {
                Console.WriteLine("Tebrikler bu dersi geçtiniz. Ortalama= {0}", ortlama);
            }
            else
            {
                Console.WriteLine("bu dersten kaldınız :( Ortalamanız= {0}", ortlama);
            }
        }
    }
}
