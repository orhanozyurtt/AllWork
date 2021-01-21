using System.Runtime.Serialization;
using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;
using System;

namespace sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, islem;
            
            Console.WriteLine("Hoşgeldiin! İsmini öğrenebilir miyim?");
            ad = Console.ReadLine();
            Console.WriteLine("son olarak en sevdiğin renk hangisi");
            Console.WriteLine("kırmızı  \n sarı  \n mavi \n yesil  \n siyah  \n beyaz"); //
            islem = (Console.ReadLine()).ToLower();
            if (islem == "kırmızı")
            {
                Console.WriteLine("bilgileriniz \n  adınız:{0} \n sevdiğiniz renk :{1}", ad, islem);
            }
            else if (islem == "sarı")
            {
                Console.WriteLine("bilgileriniz adınız:{0} \n sevdiğiniz renk :{1}", ad, islem);
            }

            else if (islem == "mavi")
            {
                Console.WriteLine("bilgileriniz adınız:{0} \n sevdiğiniz renk :{1}", ad, islem);
            }
            else if (islem == "yesil")
            {
                Console.WriteLine("bilgileriniz adınız:{0} \n sevdiğiniz renk :{1}", ad, islem);
            }
            else if (islem == "siyah")
            {
                Console.WriteLine("bilgileriniz adınız:{0} \n sevdiğiniz renk :{1}", ad, islem);
            }
            else if (islem == "beyaz")
            {
                Console.WriteLine("bilgileriniz adınız:{0} \n sevdiğiniz renk :{1}", ad, islem);
            }


        }
    }
}
