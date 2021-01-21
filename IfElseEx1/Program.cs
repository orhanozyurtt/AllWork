using System;

namespace IfElseEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * soru-1
             * belirlenen kullanıcı adı ve şifre doğru girildiğinde "giriş başarılı", yanlış girildiğinde "girdiğiniz kullanıcı adı ve şifre hatalı "
             * hatalı mesajını veren console uygulamasını yazınız */
            /*
             * kullanıcı adı
             * şifre 
             * kontrol deyimine 
             */
            /*
            int sifre,bsifre=123;
            string kadi,bkadi="enver";
            
            Console.WriteLine("kullanıcı adını girin");
            kadi = Console.ReadLine().ToLower();
            Console.WriteLine("{0} şifreni gir", kadi);
            sifre = Convert.ToInt32(Console.ReadLine());
            if (kadi == bkadi && sifre==bsifre)
            {
                Console.WriteLine("giriş başarılı \n {0} hoşgeldin",kadi);
            }
            else
            {
                Console.WriteLine("giriş hatalı");
            }
            */
            /*
             * soru-2 
             klavyeden girilen sayının tek mi, çift mi olduğunu gösteren c# programını yazınız 
             */



            /*
             * soru -3 
             * 2 sınavın ortalamasını alan ve notu 50'nin altındaysa kaldı üstündeyse geçti yazan programın kodlarını yazın
             5
            
             */
            /*
            double not1, not2,ort;
            Console.WriteLine("1. sınav notunu girin");
            not1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. sınav notunu girin");
            not2 = Convert.ToDouble(Console.ReadLine());
            ort = (not1 + not2) / 2;
            if (ort >= 50)
            {
                Console.WriteLine("1.sınavınız = {0} \n 2.sınıvanız = {1}", not1, not2);
                Console.WriteLine("{0} ortalama ile dersi geçtiniz", ort);
            }
            else
            {
                Console.WriteLine("1.sınavınız = {0} \n 2.sınıvanız = {1}", not1, not2);
                Console.WriteLine("{0} ortalama ile dersten kaldınız", ort);
            }
            */
        }
    }
}
