using System;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("bir sayı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("işlem türünü seçiniz");
            Console.WriteLine("toplma= 1 \n çıkarma= 2 \n çarpma= 3 \n bölme= 4 \n mod al =5");

            int islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1: Console.WriteLine(sayi + sayi1); break;
                case 2: Console.WriteLine(sayi - sayi1); break;
                case 3: Console.WriteLine(sayi * sayi1); break;
                case 4: Console.WriteLine(sayi / sayi1); break;
                case 5: Console.WriteLine(sayi % sayi1); break;
                default: Console.WriteLine("hatalı seçim, böyle  bir işlem bulunmamaktadır");break;
            }
        }
    }
}
