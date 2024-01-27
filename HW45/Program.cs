namespace HW45;
class Program
{
    static void Main(string[] args)
    {
        MineList<string> products = new MineList<string>();
        products.Add("Macbook Air 2020");
        products.Add("Logitech MK470");
        products.Add("Logitech M300");

        foreach (var product in products.Items)
        {
            Console.WriteLine(product);
        }
    }
}

