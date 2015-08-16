/**
 * Created by b50 on 5.6.2015 ã..
 */
//Problem 1. Planar coordinates
console.log('Problem 1. Planar coordinates');
function buildPoint(x,y){
    return{
        x:x,
        y:y
    }
}
function lineDistance(point1, point2){
    var squiredX = (point1.x - point2.x)*(point1.x - point2.x);
    var squiredY  = (point1.y - point2.y)*(point1.y - point2.y);
    var distance = Math.sqrt(squiredX+squiredY);
    return distance;
}

function buildLine(point1,point2) {
    return {
        distanceCalc: function(){
            var squiredX = (point1.x - point2.x) * (point1.x - point2.x);
            var squiredY = (point1.y - point2.y) * (point1.y - point2.y);
            var distance = Math.sqrt(squiredX + squiredY);
            return +distance.toFixed(3);// zaduljitelno + za6toto raboti s obekti i ina4e vru6ta string
        }
    }
}
function checkIfTraingle(line1,line2,line3){
    var check1 = line1.distanceCalc()+line2.distanceCalc()>line3.distanceCalc();
    var check2 = line1.distanceCalc()+line3.distanceCalc()>line2.distanceCalc();
    var check3 = line2.distanceCalc()+line3.distanceCalc()>line1.distanceCalc();

    if(check1&&check2&&check3){
        return 'Lines can form triangle';
    }
    else{
        return 'Cannot form a triangle';
    }
}

var pointOne = buildPoint(1,1);
var pointTwo = buildPoint(2,2);
var pointThree= buildPoint(2,1);
var lineOne = buildLine(pointOne,pointTwo);
var lineTwo = buildLine(pointTwo,pointThree);
var lineThree = buildLine(pointThree,pointOne);
var lineFour = buildLine({x:3,y:5},{x:7,y:8});
var lineFive = buildLine({x:0,y:0},{x:0,y:0});
console.log(lineOne.distanceCalc());
console.log(lineTwo.distanceCalc());
console.log(lineThree.distanceCalc());
console.log(lineFour.distanceCalc());
console.log(lineFive.distanceCalc());
console.log(checkIfTraingle(lineOne,lineTwo,lineThree));
console.log(checkIfTraingle(lineThree,lineFour,lineOne));
console.log();
//Problem 2. Remove elements
console.log('Problem 2. Remove elements');
//Write a function that removes all elements with a given value.
var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
Array.prototype.remove = function() {
    var what, a = arguments, L = a.length, ax;
    while (L && this.length) {
        what = a[--L];
        while ((ax = this.indexOf(what)) !== -1) {
            this.splice(ax, 1);
        }
    }
    return this;
};
var newArr = arr.remove(1);
console.log(newArr);//[2,4,3,4,111,3,2,'1'];
console.log('');
//Problem 3. Deep copy
console.log('Problem 3. Deep copy');
console.log(clone(5));
console.log(clone({name: 'Ninja', age: Infinity}));

function clone(obj){
    if (typeof obj !== 'object') {
        return obj;
    }

    var cloned = {};
    for (var prop in obj) {
        cloned[prop] = clone(obj[prop]);
    }

    return cloned;
}
console.log('');
//Problem 4. Has property
console.log('Problem 4. Has property');
var obj = {color: 'red', size: '230x20px'};

function checkHasProperty(obj,pr){
    for(var prop in obj){
        if([prop]==pr){
            return 'Has property: '+pr;
        }
        else{
            return 'Does not have property:'+pr;
        }
    }
}
var searchedProp = 'color';
console.log(checkHasProperty(obj,searchedProp));
for(var prop in obj){
    console.log(prop);
}
function hasProperty(obj, prop){
    return obj.hasOwnProperty(prop);
}
console.log('');
//Problem 5. Youngest person
console.log('Problem 5. Youngest person');
var people = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname : 'Bay', lastname: 'Ivan', age: 81},
    { firstname : 'Bay', lastname: 'UI', age: 20}];

function youngestPerson(arr){
    var youngest = arr[0];

    for( var person of arr){
        if(person.age<youngest.age){
            youngest=person;
        }
    }
    return 'The youngest is:'+youngest.firstname+' '+youngest.lastname+' '+youngest.age
}
console.log(youngestPerson(people));
console.log('');
//Problem 6.
//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)
console.log('Problem 6 overloading');
function sortOn (arr, prop) {
    arr.sort (
        function (a, b) {
            if (a[prop] < b[prop]){
                return -1;
            } else if (a[prop] > b[prop]){
                return 1;
            } else {
                return 0;
            }
        }
    );
}
var cars = [
    {make:"AMC",        model:"Pacer",  year:1978},
    {make:"Koenigsegg", model:"CCGT",   year:2011},
    {make:"Pagani",     model:"Zonda",  year:2006},
    {make:"AMC",        model:"Pacer",  year:1900}
];
sortOn(cars, 'make');
console.log(cars);
sortOn(cars,'year');
console.log(cars);