/**
 * Created by b50 on 9.6.2015 ã..
 */

function solve(p){
   var s = +p[0],
       p1=+p[1],
       p2=+p[2],
       p3=+p[3],
       currS;
       var maxSum=1;
        for(var i = 0; i<=s/p1; i++){
            for(var j=0; j<=s/p2; j++){
                for(var k=0;k<=s/p3; k++){
                    currS=i*p1+j*p2+k*p3;
                    if(currS>maxSum && currS<=s){
                        maxSum=currS;
                    }
                }
            }
        }
   return maxSum;
}

var input = ['110','13','15','17'];
console.log(solve(input));