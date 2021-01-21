using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            switch(kosul)
            {
                case 1 : işlemi;break;
            
                default:;break;
            }
            */
            //günler(days)
            Console.WriteLine("hangi günün kaçıncı gün olduğunu merak ediyorsunuz ? (1-7)");

            int days = Convert.ToInt32(Console.ReadLine());
            switch (days)
            {
                case 1:
                    Console.WriteLine("haftanın {0}. günü pazartersi",days);
                    break;
                case 2:
                    Console.WriteLine("haftanın {0}. günü salı", days);
                    break;
                case 3:
                    Console.WriteLine("haftanın {0}. günü çarşamba", days);
                    break;
                case 4:
                    Console.WriteLine("haftanın {0}. günü perşembe", days);
                    break;
                case 5:
                    Console.WriteLine("haftanın {0}. günü  cuma", days);
                    break;
                case 6:
                    Console.WriteLine("haftanın {0}. günü  cumartesi", days);
                    break;
                case 7:
                    Console.WriteLine("haftanın {0}. günü  pazar", days);
                    break;
                case 8:
                    Console.WriteLine("öyle bir gün varsa banada haber et");break;
                default:
                    Console.WriteLine("aralık dışı veri girişi");
                    break;
            }

            /*
            if (days==1)
            {
                Console.WriteLine("pazartesi");
            }
            else
            {
                Console.WriteLine("hata");
            }
            */

        }
    }
}
