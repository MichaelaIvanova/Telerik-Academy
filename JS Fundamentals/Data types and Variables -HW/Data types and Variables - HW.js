//Problem 1. JavaScript literals
//Assign all the possible JavaScript literals to different variables.
console.log('Problem 1. JavaScript literals');
var intNum =5;
console.log('Integer number:'+intNum);
var floatNum = 5.55;
console.log('Float number:'+floatNum);
var string ='Hello word';
console.log(string);
var isDifferent = (intNum === floatNum);
console.log('Is '+floatNum +' different from '+intNum +':' +isDifferent);
//Problem 2. Quoted text
//Create a string variable with quoted text in it.
//For example: `'How you doin'?', Joey said'.
console.log('');
console.log('Problem 2. Quoted text');
var quotedText = '\'How you doin\'?\', \'Joey said\'';
console.log(quotedText);
console.log('');
//Problem 3. Typeof variables
console.log('Problem 3. Typeof variables');
console.log('Try typeof on all variables you created.');
console.log(intNum+' is type: '+ typeof(intNum));
console.log(floatNum+' is type:'+typeof (floatNum));
console.log(string + 'is type: ' +typeof(string));
console.log( isDifferent + 'is type: ' +typeof(isDifferent));
console.log('');
//Problem 4. Typeof null
console.log('Problem 4. Typeof null');
console.log('Create null, undefined variables and try typeof on them.');
var isNullInt=2;
isNullInt=null;
var secondNull = '2string';
secondNull=null;
var thirdNull = false;
thirdNull=null;
var realNull = null;
console.log('isNullInt is type: ' + typeof(isNullInt));
console.log('secondNull is type:'+typeof (secondNull));
console.log('thirdNull is type: ' + typeof (thirdNull));
console.log('RealNUll is type: ' + typeof (realNull));
console.log('');
















