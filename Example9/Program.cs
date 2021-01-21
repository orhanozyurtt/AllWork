using System;

namespace Example9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("trafik lambasının rengini girin");
            String renk = Console.ReadLine().ToLower();
            switch (renk)
            {
                case "kırmızı": Console.WriteLine("dur");break;
                case "sarı": Console.WriteLine("hazır ol"); break;
                case "yesil":Console.WriteLine("geç");break;
                default: Console.WriteLine("hatalı veri girdiniz");break;
            }
        }
    }
}
