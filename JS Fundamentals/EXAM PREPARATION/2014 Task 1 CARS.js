/**
 * Created by b50 on 9.6.2015 ã..
 */

function solve(p){
    var s = +p[0];
     var trucks,cars,trikes;
     var counter = 0;

    for(trucks=0; trucks<=s;trucks++){
        for(cars=0; cars<=s; cars++){
            for(trikes=0; trikes<=s; trikes++){
                if(trucks*10+cars*4 +trikes*3===s){
                    counter++;
                }
            }
        }
    }
    return counter;
}
var c =['40'];
console.log(solve(c));

