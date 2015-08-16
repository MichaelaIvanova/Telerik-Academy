/**
 * Created by b50 on 10.6.2015 ã..
 */

function Solve(params) {
    var N = parseInt(params[0]),
        answer = 0,
        arr = [],
        i;
    for(i=1;i<=N;i+=1){
        arr.push(parseInt(params[i]));
    }
    for(i=0;i<N;i+=1){
        if(arr[i]<=arr[i+1]&&i+1<N){
            continue;
        }else{
            answer+=1;
        }
    }

    return answer;
}


var args =['7','1', '2','-3', '4','4','0','1'];
console.log(Solve(args));
var args2=['6','1', '3', '-5', '8', '7', '-6'];
console.log(Solve(args2));