using System;

namespace PercentCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // numb = number(numara) 
            // percent(yüzde)
            // result(sonuç)
            //soru: kullanıcıdan bir sayı ve hesaplanmasını istediği yüzdelik değeri alıp işlemleri yaparak 
            // kullanıcıya sonucu gösteren program
            double numb = 0,percent=0,result=0; // eğer işlemlerde virgüllü sayılarla işlem yapılacaksa <double> veri tipi kullanılır
            Console.WriteLine("yüzdesini hesaplamak istediğiniz sayıyı girin :");
            // kullanıcıdan gelen veriyi double veri tipine dönüştürdük
            numb = Convert.ToDouble(Console.ReadLine()); 
            
            Console.WriteLine("yüzdelik oranını girin:");
            // kullanıcıdan gelen veriyi double veri tipine dönüştürdük 
            percent = Convert.ToDouble(Console.ReadLine());
            //yüzde hesaplama işlemini yaptık ve result(sonuc) değişkenine atadık. 
            // burda yapılan işlem shopping2 isimli proje dossyasında detaylı olarak anlatılmıştır
            result = (numb * percent) / 100;
            // en son kullanıcıya işlem sonucunu bildirmek için bu kodu yazıyoruz 
            // {0} parametresi kullanıcının girdiği sayıyı 
            //{1} parametresi sayının yüzdelik değerini 
            // {2} parametresi yüzdelik hesaplama sonucunu ekrana yazdırır 
            Console.WriteLine("{0} sayısının %{1} = {2}", numb, percent, result);

            /* örnek: 
             * yüzdesini hesaplamak istediğiniz sayıyı girin: 
             * 100
             * yüzdelik oranını girin: 
             * 50
             * 100 sayısının %50 = 50
             * program bitti 
             
             
             
             */
            
        }
    }
}
