using System;

namespace BasicCalculater
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

    
            double num1, num2, result = 0;
            Console.WriteLine("bir sayı girin:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("bir sayı girin:"); // kullanıcıdan bir sayı girmesini istedik 
            num2 = Convert.ToDouble(Console.ReadLine()); // kullanıcıdan girilen değeri double veri tipine dönüştürdük
            

            Console.WriteLine("işlemi seçin \n toplama --> t \n çıkarma --> c \n çarpma --> x \n bölme --> /");
            string islem = Console.ReadLine();
            if (islem == "t")
            {
                result = num1 + num2;
                Console.WriteLine(result);
            }
            else if (islem == "c")
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
            else if (islem =="x")
            {
                result = num1 * num2;
                Console.WriteLine(result);
            }
            else if (islem=="/")
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
            } while (true);
        }
    }
}
