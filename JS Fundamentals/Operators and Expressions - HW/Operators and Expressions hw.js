//Problem 1. Odd or Even
console.log('Problem 1. Odd or Even, Write an expression that checks if given integer is odd or even.');
var numbers = [3, 2, -2, -1, 0,11];
for (var index = 0; index < numbers.length; ++index){
    var isOdd = (numbers[index]%2 != 0);
    if(isOdd) {
        console.log(numbers[index] + ' is Odd ');
    }
    else{
        console.log(numbers[index] + ' is Even ');
    }
}
//Problem 2. Divisible by 7 and 5
console.log('Problem 2. Divisible by 7 and 5');
numbers = [3, 0, 5, 7, 35, 140];
for (var index = 0; index < numbers.length; ++index){
    var isDevisibleby7and5 = (numbers[index]%5==0 && numbers[index]%7==0);
    console.log(numbers[index] +' ' + isDevisibleby7and5 );
}
console.log('');
//Problem 3. Rectangle area
console.log('Problem 3. Rectangle area, Write an expression that calculates rectangle’s area by given width and height.');
var width = [3, 2.5, 5];
var height=[4, 3, 5];
for (var index = 0; index < width.length; ++index){
    var area = (width[index]*height[index]);
    console.log(index+1 +'st rectangle has area: ' + area );
}
console.log('');
//Problem 4. Third digit
console.log('Problem 4. Third digit, Write an expression that checks for given integer if its third digit (right-to-left) is 7.');
var numbers = [5, 701, 1732, 877, 777877, 9999799];
for (var index = 0; index < numbers.length; ++index){
    var isDigit7 = (Math.floor((numbers[index] / 100) % 10) === 7);
    if(isDigit7)
    {
        console.log(numbers[index] + ' has third digit 7');
    }
}
console.log('');
//Problem 5. Third bit
console.log('Problem 5. Third bit, Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.');
//The bits are counted from right to left, starting from bit #0
var numbers = [5, 8, 0, 15, 53, 43, 62241];
var binary = [];

for (var index = 0; index < numbers.length; ++index){
    binary.push(numbers[index].toString(2));
}
console.log('number in binary');
for (var index = 0; index < binary.length; ++index){
    var indidualBinary = binary[index];
    var bit = indidualBinary[indidualBinary.length-3];
    console.log(numbers[index]+' in binary is ' + indidualBinary + ' with 3rd Bit fom right: ' + bit);
}




