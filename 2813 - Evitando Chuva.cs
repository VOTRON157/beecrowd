using System;
// using System.Globalization;
// using System.Threading;
class Script
{
    static private void Main()
    {
        int previsoes = Convert.ToInt32(Console.ReadLine());
        int casa = 0;
        int trabalho = 0;
        int tem_emcasa = 0;
        int tem_notrabalho = 0;
        for(int i = 0; i < previsoes; i++)
        {
            string[] previsao = Console.ReadLine().Split(' ');
            // Na hora de ir para o tabalho.
            if (previsao[0] == "chuva")
            {
                if (tem_emcasa == 0)
                {
                    trabalho++;
                    tem_notrabalho++;
                } else
                {
                    tem_notrabalho++;
                    tem_emcasa--;
                }
            }
            // Na hora de voltar do trabalho.
            if (previsao[1] == "chuva")
            {
                if (tem_notrabalho == 0)
                {
                    casa++;
                    tem_emcasa++;
                } else
                {
                    tem_emcasa++;
                    tem_notrabalho--;
                }
            }
        }
        Console.WriteLine($"{trabalho} {casa}");
    }
}
