var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

if(lines[0].includes("13")) console.log(`${lines[0]} es de Mala Suerte`)
else console.log(`${lines[0]} NO es de Mala Suerte`)
