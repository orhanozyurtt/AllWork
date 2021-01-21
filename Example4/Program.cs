using System;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            // bilgisayarınızın tarih bilgisini alarak hangi günde olduğumuzu switch-case bloğu ile bulalım 
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
           // int gun1 = (int)DateTime.Now.DayOfYear;
           
            //Console.WriteLine(gun1.ToString());
            switch (gun)
            {
                case 1:
                    Console.WriteLine("bugün pazartesi");
                    break;
                case 2:
                    Console.WriteLine("bugün salı");
                    break;
                case 3:
                    Console.WriteLine("bugün çarşamba");
                    break;
                case 4:
                    Console.WriteLine("bugün perşembe");
                    break;
                case 5:
                    Console.WriteLine("bugün cuma ");
                    break;
                case 6:
                    Console.WriteLine("bugün cumartesi");
                    break;
                case 7:
                    Console.WriteLine("bugün cuma");
                    break;
                default:
                    break;
            }
        }
    }
}
