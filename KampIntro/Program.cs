namespace KampIntro;

class Program
{
    static void Main(string[] args)
    {
        //type safety - tip güvenliği
        //Do not repeat yourself.
        //değer tutucu - alias 
        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        if (dolarDun > dolarBugun)
        {
            Console.WriteLine("Azalış Oku!");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış Oku!");
        }
        else
        {
            Console.WriteLine("Değişmedi");
        }

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Ayarlar Butonu");
        }
        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }
        Console.WriteLine(kategoriEtiketi);
    }
}