﻿using System;

namespace ForEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yüksekliği Girin : ");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genişliği Girin : ");
            int genislik = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= yukseklik; i++)
            {
                for (int j = 1; j <= genislik; j++)
                {
                    if (i == 1 || i == yukseklik)
                        Console.Write("*");
                    else
                        if (j == 1 || j == genislik)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        
        }
    }
}
