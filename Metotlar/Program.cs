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
        urun1.StokAdedi = 33;

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

		Urun urun5 = new Urun();
		urun5.Id = 4;
		urun5.UrunAdi = "İğde";
		urun5.Fiyat = 90;
		urun5.Aciklama = "Şekerli Un Mis İğde";

		Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4, urun5};

        foreach (Urun  urun in urunler)
        {
            Console.WriteLine(urun.UrunAdi);
            Console.WriteLine(urun.Fiyat);
            Console.WriteLine("--------");
        }
        Console.WriteLine("---------Metotlar-------");
        //Instance - Örnek
        //Encapsulation - Kapsülleme


        SepetManager sepetmanager = new SepetManager();
        sepetmanager.Ekle(urun1);
        sepetmanager.Ekle(urun2);
        sepetmanager.Ekle(urun3);

        sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 10);
        sepetmanager.Ekle2("Elma", "Yeşil Elma", 15, 7);
        sepetmanager.Ekle2("Karpuz", "Yeşil Karpuz", 18, 22);
    }
}