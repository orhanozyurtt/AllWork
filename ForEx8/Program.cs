using System;

namespace ForEx8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ".sayıyı giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(dizi);
            Console.WriteLine("-----------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
