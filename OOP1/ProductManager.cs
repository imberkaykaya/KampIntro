using System;
namespace OOP1
{
	public class ProductManager
	{
		//Encapsulation
		public void Add(Product product)
		{
			Console.WriteLine("Ekleme yapıldı"+ ": " + product.ProductName);
		}
		public void Update(Product product)
		{
            Console.WriteLine("Güncelleme yapıldı" + ": " + product.ProductName);
        }
    }
}

