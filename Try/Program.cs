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
            //değişken tanımlama 
            string ad, islem;
            //kullanıcıyı bilgilendirici mesajı ekrana yazdırma 
            Console.WriteLine("Hoşgeldiin! İsmini öğrenebilir miyim?");
            //kullanıcan gelen veriyi değişkene atama
            ad = Console.ReadLine();
            //kullanıcıyı bilgilendirici mesajı ekrana yazdırma
            Console.WriteLine("son olarak en sevdiğin renk hangisi");
            // çift tırnak içine girilen verileri eğer alt alta yazdırma istersek \n ifadesini kullanırız
            Console.WriteLine("kırmızı  \n sarı  \n mavi \n yesil  \n siyah  \n beyaz"); 
            //kullanıcının seçimini değişkenin içerisine atarız 
            // ToLower() komutu gelen verideki tüm harfleri küçük harfe dönüşürür
            islem = (Console.ReadLine()).ToLower();
            if (islem == "kırmızı") // if kontrollerinde == ifadesi eşit ise anlamına gelir 
            {
                //eğer kullanıcı console üzrinde kırmızı yazdıysa bu bilgilendirmeyi ekrana yazdırır 
                /* {0} ifadesi parametre belirtir. parametreyi çift tırnak içerisinde tanımladıktan sonra
                    çift tırnaların dışına çıkılır ve virgül ',' eklenip parametrenin içerisine gelecek olan değişken yazılır
                 */
                Console.WriteLine("bilgileriniz \n  adınız:{0} \n sevdiğiniz renk :{1}", ad, islem);
            }
            else if (islem == "sarı")
            {
                //eğer if çalışmazsa else if kodu denenir
                // if-->eğer | else if --> değilse eğer 
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
