/**
 * Created by b50 on 10.6.2015 ã..
 */
//- the maximum possible sum of consecutive numbers

//Find the maximum possible sum of consecutive numbers in arr.
function Solve(input) {
    input = input.splice(1).map(Number);

    var bestSum = input[1];

    for (var i = 0; i<input.length; i++){
        var currSum = 0;
        for(var k =  i ; k<input.length; k++){
            currSum+=input[k];
            if(currSum>bestSum){
                bestSum=currSum;
            }
        }
    }

    return bestSum;
}
var args = ['8', '1', '6','-9','4', '4' ,'-2', '10', '-1'];
console.log(Solve(args));
