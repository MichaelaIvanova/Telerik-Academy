/**
 * Created by b50 on 10.6.2015 ã..
 */
function solve(p){
    var input = [];
    for(var i = 0; i< p.length; i++){
        var current = p[i].split(' ').map(Number);
        input.push(current);
    }

    function create2DArray(rows,columns) {
        rows = parseInt(rows);
        columns = parseInt(columns);
        var x = new Array(rows);
        for (var i = 0; i < rows; i++) {
            x[i] = new Array(columns);
        }
        return x;
    }

    var rowsTotal = input[0][0];//number of rows
    var colsTotal = input[0][1];//number of rows
    var jumpsTotal = input[0][2];

    var r = input[1][0];//start r
    var c = input[1][1];//start c


    // create an fill withvalue the field
    var field  = create2DArray(rowsTotal,colsTotal);
    var filler = 1;
    for (var i = 0; i<rowsTotal ;i++){

        for (var k = 0; k<colsTotal; k++){

            field[i][k] = filler++;
        }

    }

    var moves = [];
    for(var i = 2; i< p.length; i++){
        moves.push(input[i]);
    }

    var sum = 0;

    var stepsSUM = 0;

    var stepIndex = 0;

       while(true){
        if(r<0|| c<0 || r>=rowsTotal || c>=colsTotal){
            return "escaped " + sum;
        }
           if(field[r][c] === 'X'){
               return 'caught '+stepsSUM;
           }

           //get  value of the  tile
           var visitedTile = field[r][c];
           //mark it as visited
           field[r][c]='X';

           sum +=visitedTile;
           stepsSUM++;

           //define next step;
           r+=moves[stepIndex][0];
           c+=moves[stepIndex][1];

           // max step index = 2 (moves.lenght -1)
           stepIndex++;
           if(stepIndex>=moves.length){
               stepIndex=0;
           }


    }


}




var args = ['6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1'
];

console.log(solve(args));

