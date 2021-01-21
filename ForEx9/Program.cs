using System;

namespace ForEx9
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen sayıları teklik çitliğini inceleyip tek olan ssayıların çarpımını gösteren program 
            int sayı=0, sonuc=1,cift=1,neg=1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("bir sayı girin");
                sayı = Convert.ToInt32(Console.ReadLine());
                if (sayı % 2 != 0 && sayı > 0)
                {
                    sonuc *= sayı;
                }
                else if (sayı % 2 ==0 && sayı>0)
                {
                    cift *= sayı;
                }
                else if(sayı<0)  
                {
                    neg *= sayı;
                }
            }
            Console.WriteLine(" tek sayıların çarpımı= {0} \n cift sayıların çarpımı {1} \n {2} negatif sayıların çarpımı",sonuc,cift,neg);
        }
    }
}
