using System;

namespace PdfEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            //kişinin yaşına bakarak ehliyet alıp alamıcağını bildiren programı yazınız. 
            Console.WriteLine("yaşınızı girin :");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas<18)
            {
                Console.WriteLine("ehliyet için yaşınız küçük");
            }
            else
            {
                Console.WriteLine("ehliyet için yaşınız yeterli");
            }
        }
    }
}
