

function solve(p){
    var colsAndRows =p[0].split(' ');
    var rowsTotal = +colsAndRows[0]; //3;
    var colsTotal = +colsAndRows[1]; //5

    p.splice(0,1);
    var matrix = p.map(function(item){
        return item.split('');
    });

    var r = rowsTotal-1; // start here
    var c = colsTotal-1;//start here
    //

    var directions ={
        8:'-2-1',
        7:'-1-2',
        6:'+1-2',
        5:'+2-1',
        4:'+2+1',
        3:'+1+2',
        2:'-1+2',
        1:'-2+1'
    };

    var sum = 0;
    var steps = 0;

    while(true){
        if(r<0||c<0||r>rowsTotal-1||c>colsTotal-1){// zerobased index of cols and rows
            return 'Go go Horsy! Collected '+sum+' weeds';
        }
        if(matrix[r][c]=== 'X'){
            return 'Sadly the horse is doomed in '+steps +' jumps';
        }

        sum+= Math.pow(2,r)-c;
        steps+=1;
        var dir = matrix[r][c];
        var upOrD = +directions[dir].substr(0,2);// get first 2 chars and make than as  number
        var lOrRight =+directions[dir].substr(2,2);

        matrix[r][c]='X';
        r+=upOrD;
        c+=lOrRight;

    }

}


var args1 = [
    '3 5',
    '54561',
    '43328',
    '52388'
];
console.log(solve(args1));
var args2 = [
    '3 5',
    '54361',
    '43326',
    '52188'
];
console.log(solve(args2));
