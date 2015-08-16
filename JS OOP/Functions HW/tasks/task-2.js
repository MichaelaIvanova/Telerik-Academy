/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(from,to) {
  if (from==='undefined'||to==='undefined'){
   throw  new Error();
  }
 if(arguments.length<=1){
  throw new Error();
 }

 from = +from;
 to=+to;

 if(isNaN(from)||isNaN(to)){
  throw  new Error();
 }

 function isPrime(number) {
  var maxDivisor = Math.sqrt(number),
      isPrime = true,
      currDivisor;

  if(number < 2) {
   return false;
  }

  for(currDivisor = 2; currDivisor <= maxDivisor; currDivisor += 1) {
   if(!(number % currDivisor)) {
    isPrime = false;
    break;
   }
  }

  return isPrime;
 }

 var primes = [];

 for(var i=from; i<=to; i++){
   if(isPrime(i)){
    primes.push(i);
   }
 }
return primes;
}

module.exports = findPrimes;
