/**
 * Created by b50 on 6.6.2015 ã..
 */
//Problem 1. Reverse string
console.log('Problem 1. Reverse string');
 var str = 'abcdefghigk 123';
//Write a JavaScript function that reverses a string and returns it.
if (!String.prototype.reverse){

    String.prototype.reverse=function(){return this.split('').reverse().join("");}

}
var reversed = str.reverse();
console.log(reversed);
console.log(str);
console.log('');

console.log('Problem 2. Correct brackets');
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).


var exp = '((a+b)/5-d)';

String.prototype.countChar = function(el){
    var count = 0;
    for( var i of this){
        if(i===el)
        count+=1;
    }
  return count;
};


var test = exp.countChar('(');
console.log(test);

function checkExp(exp){
     var openB = exp.indexOf('(');
     var closeB = exp.indexOf(')');

    for (var i =0; i<exp.length; i++){
        if(exp[i]==='('){
            openB=exp[i];
        }
        if(exp[i]===')'){
            closeB=exp[i];
        }

    }

    if( exp.countChar('(')!== exp.countChar(')')){
        return 'Incorrect Expression';
    }
    if(openB>closeB){
        return 'Incorrect Expression';
    }

          return 'Correct EXPR!'


}
console.log(checkExp(exp));
// correct function:
function correctBrackets(expression) {
    var i,
        count = 0;

    for (var i = 0; i < expression.length; i++) {
        if (expression[0] === '(') {
            count += 1;
        } else if (expression[0] === ')') {
            count -= 1;
            if (count < 0) {
                return false;
            }
        }
    }

    return true;
}
//Problem 3. Sub-string in text
console.log('Problem 3. Sub-string in text');
//Write a JavaScript function that finds how many times a
//substring is contained in a given text (perform case insensitive search).

 var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
var regex = new RegExp('in', 'gi');
var result = text.match(regex).length;
console.log(result);
console.log('');

console.log('Problem 4. Parse tags');
text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>.' +
    'We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.',
    result = '';

for (var i = 0; i < text.length; i += 1) {

    if (text[i] == '<' && text[i + 1] == 'u') {
        i += 8;
        while (text[i] != '<' ) {
            result += text[i].toUpperCase();
            i += 1;
        }
        if(text[i + 1] == '/') {
            i += 8;
        }
        else {
            i--;
        }
    }
    else if(text[i] == '<' && text[i + 1] == 'm'){
        i += 9;
        while (text[i] != '<'){
            if(Math.random() < 0.5){
                result += text[i].toUpperCase();
                i += 1;
            }
            else{
                result += text[i].toLowerCase();
                i += 1;
            }
        }
        if(text[i + 1] == '/') {
            i += 9;
        }else {
            i--;
        }
    }
    else if (text[i] == '<' && text[i + 1] == 'l') {
        i += 9;
        while (text[i] != '<') {
            result += text[i].toLowerCase();
            i += 1;
        }
        if(text[i + 1] == '/'){
            i += 9;
        } else {
            i--;
        }
    }

    else {
        result += text[i];
    }
}


console.log(text);
console.log(result);
//
console.log('');
console.log('Problem 5. nbsp');

var text = ' ababa aaoaoja   aaa ccc';
var replaced = text.replace(/ /g, '&nbsp');
console.log(text);
console.log(replaced);
console.log('');

//Problem 6. Extract text from HTML
console.log('Problem 6. Extract text from HTML');
 var htmlDoc = text = '<html><head><title>Sample site</title></head> <body> ' +
     '<div>text <div>more text</div>and more... </div>in body </body>';

console.log(htmlDoc);

function extractTextHtml(text){
    var openTag = '<',
        closeTag = '>',
        inTag = false,
        i,
        result='';
    for ( i=0; i<text.length; i+=1){
       if( text[i]===openTag){
           inTag=true;
       }
       else if (text[i] === closeTag) {
           inTag = false;
       }
        else{
           if(!inTag){
               result+=text[i];
           }

       }

    }
        return result;

}

console.log(extractTextHtml(htmlDoc));
console.log('');
function getText(html) {
    return html.replace(/<[^>]*>/g, '');
}
console.log('');

//Problem 7. Parse URL
console.log('Problem 7. Parse URL');

url = 'http://telerikacademy.com/Courses/Courses/Details/239';


function parseURL(url) {
    var protocol = '',
        server = '',
        resource = '';

    protocol = url.substr(0, url.indexOf("://"));
    url = url.substr(url.indexOf("://") + 3);
    server = url.substr(0, url.indexOf("/"));
    resource = url.substr(url.indexOf("/"));

    return{
        protocol: protocol,
        server: server,
        resource: resource
    }
}
var obj = parseURL(url);

console.log(obj);
console.log('');

//Problem 8. Replace tags
console.log('Problem 8. Replace tags');
 var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. ' +
     'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';


var re = new RegExp('</a>', 'g');
var re2 = new RegExp('">', 'g');
var result = input.replace(/<a href="/g, '[URL=').replace(re2, ']').replace(re,'[/URL]');
console.log(result);
console.log('');

//Problem 9. Extract e-mails
console.log('Problem 9. Extract e-mails');
var text = 'sdabhikagathara@rediffmail.com, "assdsdf" <dsfassdfhsdfarkal@gmail.com>, "rodnsdfald ferdfnson" <rfernsdfson@gmal.com>, ' +
    '"Affdmdol Gondfgale" <gyfanamosl@gmail.com>, "truform techno" <pidfpinfg@truformdftechnoproducts.com>, "NiTsdfeSh ThIdfsKaRe" ' +
    '<nthfsskare@ysahoo.in>, "akasdfsh kasdfstla" <akashkatsdfsa@yahsdfsfoo.in>, "Bisdsdfamal Prakaasdsh" <bimsdaalprakash@live.com>,; ' +
    '"milisdfsfnd ansdfasdfnsftwar" <dfdmilifsd.ensfdfcogndfdfatia@gmail.com>';

console.log(getEmails(text).join('\n\r'));

function getEmails(text){
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}
console.log('');

//Problem 10. Find palindromes
console.log('Problem 10. Find palindromes');

var input = 'aahaihaihiaihaiha'
var sub = input.substr(0,3);// duljinata na stinga e 2roto
console.log(sub);
var sub2 = input.substring(0,input.length);
console.log(sub2);

var input = 'abba lamal exe cat dog';
var input = input.split(' ');
console.log(input);
var result =[];

for (var i = 0; i<input.length; i+=1){
    var currentItem = input[i];
    var isPoly = false;
    for (var j = 0; j < (Math.floor(currentItem.length/2)); j+=1){
        if(currentItem[j]===currentItem[currentItem.length-1-j]){
            isPoly=true;
        }

    }
    if(isPoly)
    result.push(currentItem);
}
console.log(result);
console.log('');

//Problem 11. String format
console.log('Problem 11. String format');
console.log(format('{0}, {1}, {0} text {2}',  1, 'Pesho', 'Gosho'));

function format(){
    var args = arguments,
        string = args[0],
        placeholder;

    for (var ind = 1; ind < args.length; ind++) {
        placeholder ='{' + (ind - 1) + '}';

        while(string.indexOf(placeholder) > -1) {
            string = string.replace(placeholder, args[ind]);
        }
    }

    return string;
}
console.log('');

//Problem 12. Generate list
console.log('Problem 12. Generate list');
// Write a function that creates a HTML UL using a
// template for every HTML LI. The source of the list
// should an array of elements. Replace all
// placeholders marked with –{…}– with the value of
// the corresponding property of the object.

// to view the result, start index.html and click the 'Generate List' button

var people = [
        {name: 'Nikolay', age: 24},
        {name: 'Ivaylo', age: 25},
        {name: 'Doncho', age: 25},
        {name: 'Evlogi', age: 32},
        {name: 'Nikolay', age: 31}],
    template = document.getElementById('list-item').innerHTML;

function generateList() {
    var ul = document.createElement('ul');

    for (var ind in people) {
        var li = document.createElement('li');
        li.innerHTML = format(template, people[ind]);
        ul.appendChild(li);
    }
    document.body.appendChild(ul);
};

function format(string, person){
    return string.replace(/\-{(\w+)\}-/g, function (match, prop) {
        return person[prop] || '';
    });
}


