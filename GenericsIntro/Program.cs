﻿namespace GenericsIntro;
class Program
{
    static void Main(string[] args)
    {
        MyList<string> isimler = new MyList<string>();
        isimler.Add("Berkay");

        Console.WriteLine(isimler.Length);

        isimler.Add("Salih");

        Console.WriteLine(isimler.Length);

        foreach (var item in isimler.Items)
        {
            Console.WriteLine(item);
        }
    }
}

