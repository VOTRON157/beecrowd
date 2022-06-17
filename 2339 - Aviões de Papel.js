var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let [competidores, papeis, receber] = lines[0].split(" ")
if(Number(papeis) / Number(receber) >= Number(competidores)) console.log("S")
else console.log("N")
