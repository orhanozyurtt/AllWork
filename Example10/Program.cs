using System;

namespace Example10
{
    class Program
    {
        static void Main(string[] args)
        {
            // ilk harifine göre isim öneren programın kodlarını yazın. 
            Console.WriteLine(" ismin ilk harfini girin");
            char harf = Convert.ToChar( Console.ReadLine());

            switch (harf)
            {
                case 'a': Console.WriteLine("ali");break;
              
                default:
                    break;
            }

        }
    }
}
