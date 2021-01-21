using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("") komutunu ekrana yazdırma işlemi için kullanırız.
            //aşağıdaki satırda kullanıcı adını girin: şeklinde kullanıcıya bilgi verecektir
            Console.WriteLine("kullanıcı adını girin:");
            //string veri tipinde <kulad> isimli değişken tanımladık.
            /*
                değişken tanımlama nasıl yapılır? not:<> işareti sadece okunurlu kolaylaştırmak içindir.kodlarla ilgisi yoktur
                
                <veri tipi> <değikenin adı> ;
                değişkenlerin içerisine veri atama 
                string ad = "orhan"; --> bu örnekte artık ad değişkenin içinde orhan ismi yer alıyor
                 
             */
            string kulad = Console.ReadLine(); // console.Readline(); kullanıcının klavyeden girdiği değeri okumamızı sağlar 
            Console.WriteLine("sifre girin:");
            int sifre = Convert.ToInt32(Console.ReadLine()); // Convert.Toİnt() komutu parantez içerisine girilen değeri int veri tipine dönüştürür
            if (kulad=="admin" && sifre==1234) // kullanıcıdan alınan verileri karşılaştırmamızı sağlar // && --> işareti ve anlamına gelir
            {
                Console.WriteLine("giriş başarılı"); // eğer kullanıcı adı ve şifre doğru ise ekrana giriş başarılı yazdırır 
            }
            else
            {
                Console.WriteLine("kullanıcı adı veya şifre hatalı "); // değilse kullanıcı adı ve şifre hatalı yazdırır
                
               
            }
            
        }
    }
}
