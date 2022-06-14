var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let length = Number(lines[0])
let corrects = 0;
let lastnumber = 0;
for (i = 0; i < length; i++){
    number = lines[i+1]
    if (number != lastnumber){
                corrects++;
            }
            lastnumber = number;
        }
console.log(corrects);
