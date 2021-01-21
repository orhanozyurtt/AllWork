using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            etiket:
            Console.WriteLine("kullanıcı adını girin:");
            //string veri tipinde kulad isimli değişken tanımlayın.
            string kulad = Console.ReadLine();
            Console.WriteLine("sifre girin:");
            int sifre = Convert.ToInt32(Console.ReadLine());
            if (kulad=="admin" && sifre==1234)
            {
                Console.WriteLine("giriş başarılı");
            }
            else
            {
                Console.WriteLine("kullanıcı adı veya şifre hatalı ");
                goto etiket;
               
            }
            
        }
    }
}
