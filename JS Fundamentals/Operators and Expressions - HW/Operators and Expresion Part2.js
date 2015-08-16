//Hw part2
//Problem 6. Point in Circle
console.log('Problem 6. Point in Circle')
//Write an expression that checks if given point P(x, y)
// is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
// c2 = a2+b2 if c2>25 is not in the circle

var x = [0,-5,-4,1.5,-4, 100, 0, 0.2, 0.9, 2];
var y = [1,0,5,-3,-3.5,-30,0,-0.8,-4.93, 2.655];

var c =[]
for(var index =0; index< x.length; ++index){
    c.push(x[index]*x[index]+y[index]* y[index]);
    if(c[index]>25){
        console.log('Point ' +x[index]+' '+y[index]+'is OUTside the circle');
    }
    else{
        console.log('Point '+x[index]+' '+y[index]+' is IN the circle');
    }
}
//Problem 7. Is prime
console.log('');
console.log('Problem 7. Is prime, Write an expression that checks if given' +
    ' positive integer number n (n ? 100) is prime.');
var numbers=[1,2,3,4,37,97,51,-3,0];
for(var index =0; index< numbers.length; ++index){
    var numCheck = (numbers[index]);
    var isPrime = checkIfItsPrime(numCheck);
    console.log(numCheck+' is Prime: '+isPrime);

}
    function checkIfItsPrime(value) {
        value = parseFloat(value);
        var prime;
        if (value < 2) {
            return false;
        } else {
            prime = true;
            for(var i = 2; i < value; i++) {
                if(value % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }
console.log('');
//Problem 8. Trapezoid area
console.log('Problem 8. Trapezoid area');
var a=[5,2,8.5, 100, 0.222];
var b=[7,1,4.3,200,0.333];
var h=[12,33,2.7,300,0.555];

for(var indexT=0; indexT< a.length;++indexT)
{
    var result=TrapezoidArea(a[indexT],b[indexT],h[indexT]);
    var rounded = Math.round( result * 10000000 ) / 10000000;
    console.log(indexT+1+' trapezoid\'s area is:'+ rounded);
}
function TrapezoidArea(sideA, sideB, height){
    return((sideA+sideB)*height/2);
}
console.log('');

//Problem 9. Point in Circle and outside Rectangle
console.log('Problem 9. Point in Circle and outside Rectangle');
var x=[1,2.5,0,2.5,2,4,2.5,2,1,-100];
var y=[2,2,1,1,0,0,1.5,1.5,2.5,-100];
var c = [];
// c must be greater then 3swroot2, c2 musst be smaller than 18:)
for(var index =0; index<x.length; ++index) {
    c.push(x[index]*x[index] +y[index]*y[index]);

    var inCircleOutRec = (x[index]>0&&c[index] < 18 &&(y[index]>1||y[index]<-1))||(x[index]<-1&&c[index] < 2.5);
    if (inCircleOutRec) {

        console.log('Point TRUE' + '' + x[index] + ' ' + y[index] + ' is in the the Circle&Out Rec');
    }
    else{
        console.log('FALSE');
    }
}
