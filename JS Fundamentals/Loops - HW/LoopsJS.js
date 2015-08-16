//Problem 1. Numbers
console.log('Problem 1. Numbers');
//Write a script that prints all the numbers from 1 to N.
var n = 30;
for(var i =0; i<=n;++i){
    console.log(i);
}
//Problem 2. Numbers not divisible
console.log('Problem 2. Numbers not divisible');
//Write a script that prints all the numbers from 1 to N,
// that are not divisible by 3 and 7 at the same time

for(var i =0; i<=n;++i){
    var notDev=(i%(3*7)!==0);
    if(notDev){
        console.log(i);
    }
}
console.log('');
//Problem 3. Min/Max of sequence
console.log('Problem 3. Min/Max of sequence');
var seq=[-1,2,4,5,99000,3,2,1,-200];
var min=seq[0];
var max=seq[1];
for(var i=0; i<seq.length; ++i){
    if(seq[i]<min){
        min=seq[i];
    }
    if(seq[i]>max){
        max=seq[i];
    }
}
console.log('Max is:'+max+' Min is: '+min);
console.log('');
//Problem 4. Lexicographically smallest
console.log('Problem 4. Lexicographically smallest');
//Write a script that finds the lexicographically smallest and largest property
// in document, window and navigator objects.
var win = new Object();
var name='window';
win[name]='MSWindows:)';
console.log(win.window);
console.log('window');
getProperties(window);
console.log('navigator');
getProperties(navigator);
console.log('document');
getProperties(document);

function getProperties(obj){
    var min = 0;
    var max = 0;

    for(var property in obj){
        if(!min){
            min = property;
        }
        if(!max){
            max = property;
        }

        if(property < min){
            min = property;
        }

        if(property > max){
            max = property;
        }
    }

    console.log('min: ' + min);
    console.log('max: ' + max + '\n\r');
}

