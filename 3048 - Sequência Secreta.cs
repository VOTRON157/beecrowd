using System;
class Script
{
    static private void Main()
    {

        int length = Convert.ToInt32(Console.ReadLine());
        int corrects = 0;
        int lastnumber = 0;
        for (int i = 0; i < length; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != lastnumber)
            {
                corrects++;
            }
            lastnumber = number;
        }
        Console.WriteLine(corrects);
    }
}
