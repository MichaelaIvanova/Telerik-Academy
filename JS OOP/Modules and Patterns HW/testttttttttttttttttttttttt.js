function validateTitle(text) {
    if (typeof text !== 'string' || text === undefined) {
        throw new Error('Must be a string');
    }
    if (text === '') {
        throw new Error('Not empty string');
    }
    if (text.length < 1) {
        throw new Error('Must be at least one symbol')
    }
    if (text[0] === ' ' || text[text.length - 1] === ' ') {
        throw new Error('Titles do not start or end with spaces');
    }
    if (/(  )+/.test(text)) {
        throw new Error('Titles do not have consecutive spaces');
    }
}
//validateTitle('a    b');
function validatePresentations(arr) {
    if (arr.length < 1) {
        throw new Error('Must have at least one presentation')
    }
    for (var i = 0; i < arr.length; i += 1) {
        var currentPresenation = arr[i];
        validateTitle(currentPresenation);
    }
}
//validatePresentations(['',' a ']);
function validateStudentName(name){
    if (typeof name !== 'string'|| name === undefined) {
        throw new Error('Must be a string');
    }
    if (name === '') {
        throw new Error('Not empty string');
    }
    var numberOfSpaces = name.match(/ /g).length;
    if(numberOfSpaces>1){
        throw new Error('No more than 1 space');
    }
    var splitted = name.split(' ');
    // name can be also only one letter!
    if(splitted[0].length===1){
        if(!/^[A-Z]$/.test(splitted[0])){
            throw new Error('Name one letter Fname must be in uppercase')
        }
    }
    if(splitted[1].length===1){
        if(!/^[A-Z]$/.test(splitted[1])){
            throw new Error('Name one letter Last must be in uppercase')
        }
    }
    if(splitted[0].lenght>1) {
        if (!/^[A-Z]+[a-z]+/.test(splitted[0])) {
            throw new Error('Invalid First Name - must be Firstname');
        }
    }
    if(splitted[1].lenght>1) {
        if (!/^[A-Z]+[a-z]+/.test(splitted[1])) {
            throw new Error('Invalid Last Name - must be Firstname');
        }
    }
}

//console.log(/^[A-Z]+[a-z]+/.test());
//validateStudentName('a T');//works
var student = {};

student.firstname='aaaa';
student.lastname='bbbb';
student.id=2;
//console.log(student);

var exists = false;

console.log('Problem 6 overloading');
function sortOn (arr, prop) {
    arr.sort (
        function (a, b) {
            if (a[prop] < b[prop]){
                return 1;
            } else if (a[prop] > b[prop]){
                return -1;
            } else {
                return 0;
            }
        }
    );
}
var cars = [
    {make:"AMC",        model:"Pacer",  year:1978},
    {make:"Koenigsegg", model:"CCGT",   year:2011},
    {make:"Pagani",     model:"Zonda",  year:2006}
];
sortOn(cars, 'year');

var a = [];
Object.defineProperty(cars[0], 'homework',{
    value:123445,
    enumerable:false,
    configurable:true,
    writable:false
});
cars[0].homework = 'hihihihioojojhi';
var q = cars[0].homework+'hhhhhhhhhhhhhhhhhhhhh';
a=cars.slice(0,2);
console.log(q);
console.log(a);

// test reducing score
var results = [{score:3}, {score:4}];
for (var i = 0; i<results.length; i++){
    results[i].score*=0.75;
}
console.log(results);