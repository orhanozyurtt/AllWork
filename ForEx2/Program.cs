using System;

namespace ForEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            // alfabeyi ekrana yazdıran program
            char karakter;
            for (karakter = 'a'; karakter <= 'z'; karakter++)
            {
                Console.Write(karakter + " "); 
                //Console.Write("{0} ", karakter);
            }
        }
    }
}
