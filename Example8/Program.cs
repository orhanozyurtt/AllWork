using System;

namespace Example8
{
    class Program
    {
        static void Main(string[] args)
        {
            string mar = "Marmara Bölgesi", ic = "İç Anadolu Bölgesi", ege = "Ege Bölgesi", ak = "Akdeniz Bölgesi", kar = "Karadeniz Bölgesi", dogu = "Doğu Anadolu Bölgesi", gun = "Güneydoğu Anadolu Bölgesi";
            Console.WriteLine("bana bulunduğun şehri söyle sana hangi bölgedde olduğunu söyliyim");
            string sehir = Console.ReadLine().ToLower();

            switch (sehir)
            {
                case "edirne":Console.WriteLine(mar);break;
                case "kırklareli":Console.WriteLine(mar);break;
                case "tekirdağ": Console.WriteLine(mar); break;
                case "istanbul": Console.WriteLine(mar); break;
                case "yalova": Console.WriteLine(mar); break;
                case "sakarya": Console.WriteLine(mar); break;
                case "bilecik": Console.WriteLine(mar); break;
                case "bursa": Console.WriteLine(mar); break;
                case "balıkesir": Console.WriteLine(mar); break;
                case "çanakkale": Console.WriteLine(mar); break;
                
                case "aksaray": Console.WriteLine(ic); break;
                case "ankara": Console.WriteLine(ic); break;
                case "çankırı": Console.WriteLine(ic); break;
                case "eskişehir": Console.WriteLine(ic); break;
                case "karaman": Console.WriteLine(ic); break;
                case "kırıkkale": Console.WriteLine(ic); break;
                case "kırşehir": Console.WriteLine(ic); break;
                case "konya": Console.WriteLine(ic); break;
                case "nevşehir": Console.WriteLine(ic); break;
                case "niğde": Console.WriteLine(ic); break;
                case "sivas": Console.WriteLine(ic); break;
                case "yozgat": Console.WriteLine(ic); break;
                case "kayseri": Console.WriteLine(ic); break;
                
                case "izmir": Console.WriteLine(ege); break;
                case "manisa": Console.WriteLine(ege); break;
                case "aydın": Console.WriteLine(ege); break;
                case "denizli": Console.WriteLine(ege); break;
                case "kütahya": Console.WriteLine(ege); break;
                case "afyonkarahisar": Console.WriteLine(ege); break;
                case "uşak": Console.WriteLine(ege); break;
                case "muğla": Console.WriteLine(ege); break;
                
                case "adana": Console.WriteLine(ak); break;
                case "osmaniye": Console.WriteLine(ak); break;
                case "antalya": Console.WriteLine(ak); break;
                case "burdur": Console.WriteLine(ak); break;
                case "hatay": Console.WriteLine(ak); break;
                case "ısparta": Console.WriteLine(ak); break;
                case "içel": Console.WriteLine(ak); break;
                case "kahramanmaraş": Console.WriteLine(ak); break;

                case "rize": Console.WriteLine(kar); break;
                case "trabzon": Console.WriteLine(kar); break;
                case "artvin": Console.WriteLine(kar); break;
                case "sinop": Console.WriteLine(kar); break;
                case "tokat": Console.WriteLine(kar); break;
                case "çorum": Console.WriteLine(kar); break;
                case "amasya": Console.WriteLine(kar); break;
                case "samsun": Console.WriteLine(kar); break;
                case "zonguldak": Console.WriteLine(kar); break;
                case "bolu": Console.WriteLine(kar); break;
                case "düzce": Console.WriteLine(kar); break;
                case "karabük": Console.WriteLine(kar); break;
                case "bartın": Console.WriteLine(kar); break;
                case "kastamonu": Console.WriteLine(kar); break;
                case "bayburt": Console.WriteLine(kar); break;
                case "giresun": Console.WriteLine(kar); break;
                case "gümüşhane": Console.WriteLine(kar); break;
                case "ordu": Console.WriteLine(kar); break;

                case "ağrı": Console.WriteLine(dogu); break;
                case "ardahan": Console.WriteLine(dogu); break;
                case "bingöl": Console.WriteLine(dogu); break;
                case "bitlis": Console.WriteLine(dogu); break;
                case "elazığ": Console.WriteLine(dogu); break;
                case "erzincan": Console.WriteLine(dogu); break;
                case "erzurum": Console.WriteLine(dogu); break;
                case "hakkari": Console.WriteLine(dogu); break;
                case "ığdır": Console.WriteLine(dogu); break;
                case "kars": Console.WriteLine(dogu); break;
                case "malatya": Console.WriteLine(dogu); break;
                case "muş": Console.WriteLine(dogu); break;
                case "tunceli": Console.WriteLine(dogu); break;
                case "van": Console.WriteLine(dogu); break;
                case "şırnak": Console.WriteLine(dogu); break;

                case "adıyaman": Console.WriteLine(gun); break;
                case "batman": Console.WriteLine(gun); break;
                case "diyarbakır": Console.WriteLine(gun); break;
                case "gaziantep": Console.WriteLine(gun); break;
                case "kilis": Console.WriteLine(gun); break;
                case "mardin": Console.WriteLine(gun); break;
                case "siirt": Console.WriteLine(gun); break;
                case "şanlıurfa": Console.WriteLine(gun); break;
              

                default:
                    break;
            }
        }
    }
}
