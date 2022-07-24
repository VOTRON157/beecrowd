using System;

public class Program
{
    public static void Main()
    {
        string n = Console.ReadLine();
        if (n.Contains("13")) Console.WriteLine($"{n} es de Mala Suerte");
        else Console.WriteLine($"{n} NO es de Mala Suerte");
    }
}
