using System;

namespace İfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //öğrencinin iki notunu alan ve ortalam 50 nin üstündeyse geçti , altındaysa kaldı yazan program
            do
            {

            
            Console.WriteLine("1. notu girin :");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. notu girin :");
            int not2 = Convert.ToInt32(Console.ReadLine());
            double ortalama = (not1 + not2) / 2;
            if (ortalama<50)
            {
                Console.WriteLine("bu dersi geçmek için ortalamanız yeterli değil. ortlama={0}", ortalama);

            }
            else
            {
                Console.WriteLine("dersi geçtiniz. Tebrikler :) ortlama={0}",ortalama);
            }
            } while (true);
            
        }
    }
}
