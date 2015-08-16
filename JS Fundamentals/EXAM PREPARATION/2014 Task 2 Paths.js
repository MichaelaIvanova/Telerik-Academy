/**
 * Created by b50 on 9.6.2015 ã..
 */

function solve(p){
    var colsAndRows = p[0].split(' ');
    var rowsTotal = +colsAndRows[0]; //3;
    var colsTotal = +colsAndRows[1]; //5

    p.splice(0,1);
    var matrix = p.map(function(item){
        return item.split(' ');
    });
    var directions={
        u:-1,
        d:+1,
        l:-1,
        r:+1
    };

    var c = 0;
    var r = 0;


    var sum = 0;  // cell value - 2 pow Row +1
    var moves = 0;


    while(true){
        if( r<0 || c<0 || r>rowsTotal-1 || c>colsTotal-1){
            return 'successed with '+ sum;
        }
        if(matrix[r][c] === 'X'){
            return 'failed at '+'('+r+', '+c+')';
        }
        sum+= Math.pow(2,r)+c;
        var dir = matrix[r][c];
        /// zaduljitelno sled kato sme vzeli dir!!!
        matrix[r][c]='X';
        var upOrDown = dir[0];//get vertical direction;
        var leftOrRight = dir[1];// get horizontal direction;

        r+=directions[upOrDown];
        c+=directions[leftOrRight];

    }



}

args1 =[
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
];
args2 = [
    '3 5',
    'dr dl dl ur ul',
    'dr dr ul ul ur',
    'dl dr ur dl ur'
];
console.log(solve(args1));
console.log(solve(args2));
