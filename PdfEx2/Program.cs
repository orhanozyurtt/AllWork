using System;

namespace PdfEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ünlü şairimiz Mehmet Akif'in soyadı nedir ?\nCevabınız: ");
            string cevap = ( Console.ReadLine()).ToLower();
            if (cevap=="ersoy") 
            {
                Console.WriteLine("cevabınız doğru");
            }
            else
            {
                Console.WriteLine("cevabını hatalı");
            }

            Console.WriteLine(cevap);
        }
    }
}
