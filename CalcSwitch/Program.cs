using System;

namespace CalcSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc=0;
            Console.WriteLine("sayı gir");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("sayı gir");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("işlem seçin \n toplama --> 1 \n çıkarma -->  2 \n çarpma --> 3 \n bölme --> 4");
            int islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    sonuc = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}",num1,num2,sonuc);
                    break;
                case 2:
                    sonuc = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, sonuc);
                    break;
                case 3:
                    sonuc = num1 * num2;
                    Console.WriteLine("{0} x {1} = {2}", num1, num2, sonuc);
                    break;
                case 4:
                    sonuc = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, sonuc); ;
                    break;
                default:
                    break;
            }
        }
    }
}
