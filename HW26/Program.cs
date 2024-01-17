Product product1 = new Product();
product1.id = 1;
product1.name = "Mouse";
product1.description = "Logi MK350";

Product product2 = new Product();
product2.id = 2;
product2.name = "Keyboard";
product2.description = "Logi MK470";

Product[] products = new Product[] { product1, product2 };

Console.WriteLine("Foreach İle Döndü");
foreach (var product in products)
{
    Console.WriteLine(product.id + "-" + product.name);
}
Console.WriteLine("-------------");

Console.WriteLine("For İle Dönüyoruz");
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].id + "-" + products[i].name);
}
Console.WriteLine("-------------");

Console.WriteLine("While İle Dönüyoruz");
int j = 0;
while (j < products.Length)
{
    Console.WriteLine((j + 1) + "-" + products[j].name);
    j++;
}

class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
}