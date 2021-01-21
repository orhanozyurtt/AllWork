using System;

namespace shopping2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise, 
            2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.
             */
         
            
            double urun1, urun2, ilktoplam, odemetutari, indirim;
            Console.Write("Birinci ürünün fiyatını girin:");
            urun1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci ürünün fiyatını girin:");
            urun2 = Convert.ToDouble(Console.ReadLine());
            ilktoplam = urun1 + urun2;
            odemetutari = ilktoplam;
            if (ilktoplam >= 200)
            {
                indirim = urun2 * 25 / 100; // eğer bir sayının yüzdesini hesaplama isterseniz 
                /*
                    yüzdesi alınacak sayı x yüzde değeri / 100
                    100 sayısının %10 kaçtır?
                    100x10/100 = 10 
                    bu işlemde 100 sayısının yüzde 10'nun 10 olduğunu hesapladık
                 */
                odemetutari = ilktoplam - indirim;
            }
            Console.WriteLine("Ödeme tutarı: " + odemetutari);
        }


        
    }
}
