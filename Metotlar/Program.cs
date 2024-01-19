namespace Metotlar;
class Program
{
    static void Main(string[] args)
    {
        //metot: tekrar tekrar kullanılabilen kod blokları
        /*
        string urunAdi = "Elma";
        double fiyat = 7;
        string aciklama = "Amasya Elması";*/

        Urun urun1 = new Urun();
        urun1.Id = 1;
        urun1.UrunAdi = "Karpuz";
        urun1.Fiyat = 5;
        urun1.Aciklama = "Diyarbakır Karpuzu";

        Urun urun2 = new Urun();
        urun2.Id = 2;
        urun2.UrunAdi = "Çilek";
        urun2.Fiyat = 52;
        urun2.Aciklama = "Çilek gibi çilek";

        Urun urun3 = new Urun();
        urun3.Id = 3;
        urun3.UrunAdi = "Yaprak";
        urun3.Fiyat = 150;
        urun3.Aciklama = "Erbaa Yaprağı ";

        Urun urun4 = new Urun();
        urun4.Id = 4;
        urun4.UrunAdi = "Elma";
        urun4.Fiyat = 17;
        urun4.Aciklama = "Amasyanın mis elması";

        Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4};

        foreach (Urun  urun in urunler)
        {
            Console.WriteLine(urun.UrunAdi);
            Console.WriteLine(urun.Fiyat);
            Console.WriteLine("--------");
        }
    }
}