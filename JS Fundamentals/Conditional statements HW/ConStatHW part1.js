//Problem 1. Exchange if greater
console.log('Problem 1. Exchange if greater');
//Write an if statement that takes two double variables a and b and
// exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.
var a =6.778686868686;
var b = 6.9454545455555555555555555555;
var biggest;

if(a>b){
    biggest=a;
}
else{
    biggest=b;
}
console.log('The biggest is: '+ biggest);
console.log(Math.min(a,b)+' '+Math.max(a,b));
console.log('');

//Problem 2. Multiplication Sign
//Write a script that shows the sign (+, - or 0) of
// the product of three real numbers, without calculating it.
console.log('Problem 2. Multiplication Sign');

var a= 2;
var b = -3;
var c = 1;

if(a>=0&&b>=0&&c>=0 || a<0&&b<0&&c>0 || a<0&&b>0&&c<0){
    console.log('+');
}
else if(a<=0&&b<=0&&c<=0 || a>0&&b>0&&c<0 ||a>0&&b<0&&c>0){
    console.log('-');
}
else if(a<0&&b>0&&c>0){
    console.log('-');
}
console.log('');
//Problem 3. The biggest of Three
console.log('Problem 3. The biggest of Three');
var numberss = [-0.1,-0.5,-1.1];
var bigggestOfThree = numberss[0];
for(var i=0; i<numberss.length; ++i)
{
    if(numberss[i]<numberss[i+1]){
        biggest=numberss[i+1];
    }
}
console.log('The biggest is: '+bigggestOfThree );
console.log('');
//Problem 4. Sort 3 numbers
console.log('Problem 4. Sort 3 numbers');
//Sort 3 real values in descending order.
var numbers = [5,1,2];
for(var i=0; i<numbers.length-1; ++i){
        for(var j =i+1; j<numbers.length; ++j){
            if(numbers[i]<numbers[j]){// if you ascending just change sign
                var temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp
            }

        }

}
//selection sort
console.log(numbers.join(' '));
//or ordinary stupid solver
(function () {
    var a = -2,
        b = 4,
        c = 3;

    console.log("Sort 3 numbers:");

    if (a >= b && a >= c) {
        if (b >= c) {
            console.log(a, b, c);
        } else {
            console.log(a, c, b);
        }
    } else if (b >= a && b >= c) {
        if (a >= c) {
            console.log(b, a, c);
        } else {
            console.log(b, c, a);
        }
    } else {
        if (a >= b) {
            console.log(c, a, b);
        } else {
            console.log(c, b, a);
        }
    }
}());
console.log('');
//Problem 5. Digit as word
console.log('Problem 5. Digit as word');
//??? how ot read from console????????????????
console.log('To see if it works change the digit')
var digit = 9;

/**
 * @return {string}
 */
function DigitAsWord(number){
    switch (number){
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        default: return 'Invalid digit';
    }

}
console.log(digit+' is in words: '+DigitAsWord(digit));
console.log('');
//Problem 6. Quadratic equation
console.log('Problem 6. Quadratic equation');
//Write a script that reads the coefficients a, b and c of a quadratic
// equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.

var aD =2;
var bD =5;
var cD =-3;
var dD = bD*bD-4*aD*cD;
var d = Math.sqrt(dD);
console.log(dD+' '+ d);

if(dD<0){
    console.log('No real Roots');
}
if(dD=0){
    var root = -bD/2*aD;
    console.log('The root is: '+root)
}
else{
    var root1 = (-bD+d)/(2*aD);
    var root2 =(-bD - d)/(2*aD);
    console.log('The two roots are: '+ root1 +' '+root2);
}
console.log('');
//Problem 7. The biggest of five numbers
console.log('Problem 7. The biggest of five numbers');

var nums = [0,-2.5, 0, 22222, 5];
var greatest=nums[0];
for(var i=0; i<nums.length;++i){
    if(nums[i]>=greatest){
        greatest=nums[i];
    }
}
console.log('The greatest nums is: '+greatest);
console.log('');
//Problem 8. Number as words
console.log('Problem 8. Number as words');
//Write a script that converts a number in the range [0…999] to words,
// corresponding to its English pronunciation
var numbers = [0, 9, 15, 111, 212, 273, 400, 501, 999];

for(var ind = 0; ind < numbers.length; ind++){
    console.log(numbers[ind] + '\t' + getString(numbers[ind]));
}

function getString(number){
    var text = '';
    var hundreds = Math.floor(number / 100) % 10;
    var tens = Math.floor(number / 10) % 10;
    var ones = number % 10;

    if(!hundreds && !tens && !ones){
        return 'zero';
    }

    if(hundreds){
        text += getDigit(hundreds) + ' hundred';
    }

    if(tens || ones){
        if(text.length){
            text += ' and ';
        }

        if(tens){
            if(tens === 1){
                return text + getTeens(tens * 10 + ones);
            }
            text += getTens(tens);
        }

        if(ones){
            if(tens){
                text += '-';
            }

            text += getDigit(ones);
        }
    }

    return text;
}

function getDigit (digit) {
    switch(digit){
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        default: return '';
    }
};

function getTens (digit) {
    switch(digit){
        case 2: return 'twenty';
        case 3: return 'thirty';
        case 4: return 'forty';
        case 5: return 'fifty';
        case 6: return 'sixty';
        case 7: return 'seventy';
        case 8: return 'eighty';
        case 9: return 'ninety';
        default: return '';
    }
};

function getTeens (digit) {
    switch(digit){
        case 10: return 'ten';
        case 11: return 'eleven';
        case 12: return 'twelve';
        case 13: return 'thirteen';
        case 14: return 'fourteen';
        case 15: return 'fifteen';
        case 16: return 'sixteen';
        case 17: return 'seventeen';
        case 18: return 'eighteen';
        case 19: return 'nineteen';
        default: return '';
    }
};