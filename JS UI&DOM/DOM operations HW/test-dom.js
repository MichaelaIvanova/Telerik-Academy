(function () {

    var selectedElement = document.getElementById('root');
    console.log(selectedElement);
    var content = selectedElement.childNodes;
    console.log(content.length);
/*

    var elementsCount = content.length;
    console.log(elementsCount);

    var docFrag = document.createDocumentFragment();
    var div = document.createElement('div');

    for(var i = 0; i<elementsCount; i+=1){

        var current = document.cloneNode(div);
        current.appendChild(content[i]);
        docFrag.appendChild(current);
    }
    console.log(docFrag);
    var body = document.getElementsByTagName('body')[0];
    body.appendChild('div');
*/

        }());
