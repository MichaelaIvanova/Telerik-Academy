//Problem 1. English digit
console.log('Problem 1. English digit');
function lastDigitinWords(number){
    var lastDigit = number%10;
    switch(lastDigit){
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7:return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        default : return 'Not a number';


    }
}
console.log(lastDigitinWords('2323231111'));
console.log('');
//Problem 2. Reverse number
console.log('Problem 2. Reverse number');

function reverse(number){
    var checkNum = isNaN(number);
    if(checkNum){
        return 'Not a number';
    }
    var numberString = number.toString().split('');
    var reversedNum = [];
    for(var i = 0; i<numberString.length; i+=1){
        reversedNum.push(numberString[numberString.length-1-i]);
    }
    return reversedNum.join('');
}
console.log(reverse('1234.5'));
console.log('');
//Problem 3. Occurrences of word
console.log('Problem 3. Occurrences of word');
var texta = 'word Word word Word 2.word?word...';
var worda = 'word';


function countWord(text, word, isCaseSensitive){
    var splittedText = text.split(/(?:,| )/);
    console.log(splittedText);
    function countWordINSenstive(word){
        var wordL = word.toLowerCase();
        var counter = 0;
        for(var w of splittedText){
            if(w.toLowerCase()===wordL){
                counter++;
            }
        }
        return counter;
    }
    function countWordSensi(word){
        var counter = 0;
        for(var w of splittedText)
        {
            if (w === word) {
                counter++;
            }
        }
        return counter;
    }
    switch (arguments.length){
        case 2: return countWordSensi(word);
        case 3: return isCaseSensitive?countWordSensi(word):countWordINSenstive(word);
    }
}
console.log(countWord(texta,worda, false));
console.log(countWord(texta,worda));
console.log('');
//Problem 4. Number of elements
console.log('Problem 4. Number of elements');



console.log('');
//Problem 5. Appearance count
console.log('Problem 5. Appearance count');

var array = [2,2,2,4,5,6,62];

function countNumber(arr,num){
    var counter = 0;
    for(var n of arr){
        if(n===num){
            counter++;
        }
    }
    return counter;

}
console.log(countNumber(array,2));
console.log('');
//Problem 6. Larger than neighbours
console.log('Problem 6. Larger than neighbours');
//Write a function that checks if the element at given position in given array of
// integers is bigger than its two neighbours (when such exist).

var array = [1,3,2,4,5,9,7];

function checkBiggerThanNeightbours(arr, index){
    if(index===0|| index===arr.length-1){
        return'Invalid Index';
    }
    if ((arr[index]>=arr[index-1])&&(arr[index]>=arr[index+1])){
        return 'Is Bigger';
    }
    else{
        return 'Is not bigger';
    }
}
console.log(checkBiggerThanNeightbours(array,1));
console.log(checkBiggerThanNeightbours(array,2));
console.log('');
//Problem 7. First larger than neighbours
console.log('Problem 7. First larger than neighbours');
var array = [1,3,2,4,5,9,7];

function findFistBiggerThanNeighbours(arr){
    var fistBigger = 0;

    for(var i =1; i<arr.length-1; i++){
        var biggerThanNeightbours = ((arr[i]>=arr[i-1])&&(arr[i]>=arr[i+1]));
        if(biggerThanNeightbours){
            fistBigger+=arr[i];
            break;
        }
    }
    return fistBigger;
}
console.log(findFistBiggerThanNeighbours(array));


/*
 Problem 4. Number of elements
 Write a function to count the number of div elements on the web page
 */

var result = document.getElementById('result');

var divs = document.getElementsByTagName('div');
var numberOfDivs = divs.length;

console.log('The divs on the page are: ' + numberOfDivs);
result.innerHTML += 'The divs on the page are: ' + numberOfDivs;



