using System;
namespace Matematik
{
	public class DortIslem
	{
		public void Topla(int sayi1, int sayi2)
		{
			int tp = sayi1 + sayi2;
			Console.WriteLine("Toplam:" + tp);
		}
		public void Cikar(int sayi1, int sayi2)
		{
			int fark = sayi1 - sayi2;
			Console.WriteLine("Sayıların farkı: " + fark);
		}
	}
}

