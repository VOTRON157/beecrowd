using System;
class Script
{
    static private void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        int competidores = Convert.ToInt32(valores[0]);
        int papeis = Convert.ToInt32(valores[1]);
        int receber = Convert.ToInt32(valores[2]);
        if (papeis / receber >= competidores) Console.WriteLine("S");
        else Console.WriteLine("N");
    }
}
