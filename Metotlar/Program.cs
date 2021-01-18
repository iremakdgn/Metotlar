using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Açiklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun  in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Açiklama);
                Console.WriteLine("-------------");

            }
            Console.WriteLine("-----------------Metotlar-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
//tekrar etmeyen kodları metotlarla yazabiliriz