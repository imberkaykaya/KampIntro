using System;
namespace Metotlar
{
	public class SepetManager
	{
		public void Ekle(Urun urun)
		{
			Console.WriteLine("Sepete eklendi!" + ":" + urun.UrunAdi);
		}
		public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdet)
		{
            Console.WriteLine("Sepete eklendi!" + ":" + urunAdi);
        }
	}
}

