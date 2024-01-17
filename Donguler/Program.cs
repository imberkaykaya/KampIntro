namespace Donguler;
class Program
{
    static void Main(string[] args)
    {
        string kurs1 = "Yazılım geliştirici kampı";
        string kurs2 = "Programlamaya başlangıç kursu";
        string kurs3 = "Java";

        //Array - diziler

        string[] kurslar = new string[] {"Yazılım geliştirici kampı", "Programlamaya başlangıç kursu", "Java"};
        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("For bitti");

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("Sayfa Sonu - Footer");
    }
}

