//Problem 1. Increase array members
console.log('Problem 1. Increase array members');
//Write a script that allocates array of 20 integers and
// initializes each element by its index multiplied by 5.
var array = new Array(20);
for(var i =0; i<array.length; i+=1){
    array[i] = i*5;
}
console.log(array);
console.log('');
//Problem 2. Lexicographically comparison
console.log('Problem 2. Lexicographically comparison');
//Write a script that compares two char arrays
// lexicographically (letter by letter).
function compareArray(arr1,arr2) {
    var isEqualLength = (arr1.length === arr2.length);
    if (isEqualLength === false) {
        return false;
    }
    else {
        for (var i = 0; i < arr1.length; i += 1) {
          return (arr1[i] === arr2[i]);

        }
    }
}
    var charArrOne = 'abcdefg'.split('');
    console.log(charArrOne);
    var charArrTwo = 'abcdefg'.split('');
    console.log(charArrTwo);
    console.log('Are arrays equal? ' + compareArray(charArrOne,charArrTwo));
    console.log('');
//Problem 3. Maximal sequence
console.log('Problem 3. Maximal sequence');
//Write a script that finds the maximal
// sequence of equal elements in an array.
 var arraySeq = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
 var bestSeq = 1;
 var currSeq = 1;
 var bestNum = 0;
for (var i = 0; i<arraySeq.length-1; i+=1){
    if (arraySeq[i]===arraySeq[i+1]){
        currSeq+=1;
    }
    else{
        currSeq=1;
    }
    if(currSeq>=bestSeq){
        bestSeq=currSeq;
        bestNum=arraySeq[i];
    }

}
var bestSubSeq = [];
for (var i = 0; i<bestSeq; i+=1){
    bestSubSeq.push(bestNum);
}
console.log(bestSubSeq);
console.log('');
//Problem 4. Maximal increasing sequence
console.log('Problem 4. Maximal increasing sequence');
var array = [3, 2, 3, 4, 2, 2, 4];
var bestSubSeq = [array[0]],
    temp = [array[0]];

for (var i = 1; i<array.length; i+=1){
    if(array[i]>array[i-1]){
        temp.push(array[i]);
    }
    else{
        temp = [array[i]];
    }
    if(temp.length>bestSubSeq.length){
        bestSubSeq=temp;
    }
}
console.log(bestSubSeq);
console.log('');
//Problem 5. Selection sort
console.log('Problem 5. Selection sort');
//Find the smallest element, move it at the first position, find the smallest from the rest,
// move it at the second position, etc.
var array = [3, 2, 3, 4, 2, 2, 4,1000, -9,-2000, 0, 3000, '-1'];
var finalArr = [];

while (array.length>0){
    var min = Math.min.apply(Math, array);
    finalArr.push(min);
    var index = array.indexOf(min);
    array.splice(index,1);
}
console.log(finalArr);
console.log(array);
console.log('');
//Problem 6. Most frequent number
console.log('Problem 6. Most frequent number');
//Write a script that finds the most frequent number in an array.
var array =[4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
console.log(array);
var mixed = [];
var checkMax = [];
for (var i = 0; i<array.length; i+=1){
    var num = array[i];
    var counter = 0;
    for(var elements of array){
        if(num === elements){
            counter++;
        }
    }
    mixed.push(num+'('+counter+' times);');
    checkMax.push(num);
    checkMax.push(counter);
    var counter = 0;

}

var resultString = mixed.join('&');
//console.log(resultString);
var splitted = resultString.split('&');
// no duplicates!!!!!!!!!!!
var uniqueArray = splitted.filter(function(elem, pos) {
    return splitted.indexOf(elem) == pos;
});
console.log(uniqueArray);
// now we use the other array to find the max sequence number
// on even position are numbers, on odd - times seen:)
console.log(checkMax);
var maxseq = checkMax[1];
var numIndex = checkMax[0];
for (var i = 1; i<checkMax.length; i+=2){
    if(maxseq<checkMax[i]){
        maxseq=checkMax[i];
        numIndex=i-1;
    }
}
console.log('The number with best frequence is:'+numIndex +
    ' and the frequence is '+maxseq);

console.log('');
//Problem 7. Binary search
console.log('Problem 7. Binary search');
var arr = [3, 1, 5, 12, 4, 8, 2];
var key = 4,
    first = 0,
    last = arr.length - 1;

arr.sort(function (a, b) {
    return a - b;
});

while (last >= first) {
    var mid = parseInt((first + last) / 2);
    if (arr[mid] < key) {
        first = mid + 1;
    } else if (arr[mid] > key) {
        last = mid - 1;
    } else {
        console.log(mid);
        break;
    }
}



