/**
 * Created by b50 on 10.6.2015 ã..
 */

function solve(p){
    var colsAndRow = p[0].split(' ').map(Number);

    //get size ot matrix
    var rowsTotal = colsAndRow[0];
    var colsTotal = colsAndRow[1];

    // get initial row and col
    var initialPosition = p[1].split(' ').map(Number);
    var r = initialPosition[0];
    var c = initialPosition[1];

    function create2DArray(rows,columns) {
        rows = parseInt(rows);
        columns = parseInt(columns);
        var x = new Array(rows);
        for (var i = 0; i < rows; i++) {
            x[i] = new Array(columns);
        }
        return x;
    }
    // initialize direction matrix
    var matrixD =[];
    for (var i = 2; i< p.length; i++){
        matrixD.push(p[i].split('').map(String));
    }

    // create empty matrix N M for points value
    var field = create2DArray(rowsTotal,colsTotal);

    //fill field with value and direction
    var filler = 1;
    for (var i = 0; i<rowsTotal ;i++){

        for (var k = 0; k<colsTotal; k++){

            field[i][k] = {
                value:parseInt(filler++),
                direction: matrixD[i][k]
            }

        }
    }
    //console.log(field);

    var sumPoints = 0;
    var numerSteps = 0;

   // var currentTile = field[r][c];
    //console.log(sumPoints+=currentTile.value);

    while(true){
        if(r<0|| c<0 || r>=rowsTotal || c>=colsTotal){
            return 'out '+sumPoints;
        }
        if(field[r][c]==='X'){
            return 'lost '+numerSteps;
        }

        var currentTile = field[r][c];
        field[r][c]='X';
        //ad value trought property
        sumPoints+=currentTile.value;
        numerSteps++;

        // u d l r options
        var dir = currentTile.direction;

        if(dir === 'u'){
            r-=1;
        }
        if(dir === 'd'){
            r+=1;
        }
        if(dir === 'l'){
            c-=1;
        }
        if(dir === 'r'){
            c+=1;
        }


    }


}

var args =[
    "3 4",
    "1 3",
    "lrrd",
    "dlll",
    "rddd"];
console.log(solve(args));
var args2 =[
    "5 8",
    "0 0",
    "rrrrrrrd",
    "rludulrd",
    "durlddud",
    "urrrldud",
    "ulllllll"];
console.log(solve(args2));
