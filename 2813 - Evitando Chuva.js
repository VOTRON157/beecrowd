var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let previsoes = Number(lines[0])
let casa = 0;
let trabalho = 0;
let tem_emcasa = 0;
let tem_notrabalho = 0;
        for(i = 0; i < previsoes; i++)
        {
            let previsao = lines[i+1].split(" ");
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
        console.log(`${trabalho} ${casa}`)
