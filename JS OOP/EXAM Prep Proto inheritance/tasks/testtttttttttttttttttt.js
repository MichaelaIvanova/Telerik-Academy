/**
 * Created by b50 on 8.7.2015 ã..
 */
var STRING_MIN_LENGTH = 3;
var STRING_MAX_LENGTH = 25;

function validateString(text, min, max){
    if(text=== null){
        throw new Error('Invalid string, null or undefined')
    }
    if (typeof text !== 'string'|| text === undefined) {
        throw new Error('Must be a string');
    }
    if (text === '') {
        throw new Error('Not empty string');
    }
    if(text.length<min){
        throw new Error('string must be MORE than' + min + ' symbols');
    }
    if(text.length>max){
        throw new Error('string must be LESS than' + max + ' symbols');
    }
}
var playable = (function(){
    var playable = Object.create({});

    function makeCounter() {
        var i = 1;// id starts form 1;
        return function() {
            return i++;
        }
    }

    var id = makeCounter();

    Object.defineProperty(playable,'init',{
        value: function(title,author){
            this.title=title;
            this.author=author;
            this._id=id();

            return this;
        }
    });

    Object.defineProperty(playable,'title',{
        get:function(){
            return this._title;
        },
        set:function(value){
            validateString(value,STRING_MIN_LENGTH, STRING_MAX_LENGTH);
            this._title=value;
        }

    });

    Object.defineProperty(playable,'author',{
        get:function(){
            return this._author;
        },
        set:function(value){
            validateString(value,STRING_MIN_LENGTH, STRING_MAX_LENGTH);
            this._author=value;
        }

    });

    Object.defineProperty(playable,'id',{
        get: function(){
            return this._id;
        }
    });
    Object.defineProperty(playable,'eee',{
        get: function(){
            return this._id;
        }
    });


    return playable;
}());

var audio = (function(parent){
    var audio = Object.create(parent);

    Object.defineProperty(audio, 'init',{
        value:function(title, author, length){
            parent.init.call(this, title,author);
            this.length = length;
            return this;
        }
    });

    Object.defineProperty(audio,'length',{
        get:function(){
            return this._length;
        },
        set: function(value){
           // validateLength(value);
            this._length=value;
        }
    });

    Object.defineProperty(audio,'play',{
        value: function(){
            var audioasString =  parent.play.call(this)+ ' - '+this.length;
            return audioasString;
        }
    });

    return audio;
}(playable));

// test sequence id;
var a = playable.init('aaaaa','ede',);
console.log(a['id']);
var b = audio.init('bbbb','yyyy',5);
console.log(b);
var c = audio.init('ccccc','hhhh',34);

// check if a is a child of playable
console.log(Object.getPrototypeOf(b) === playable );
console.log(Object.getPrototypeOf(c) === playable );

//check object type
console.log(Object.getPrototypeOf(a)===Object.getPrototypeOf(c));
console.log(Object.getPrototypeOf(b)===Object.getPrototypeOf(c));
console.log(b.constructor.name);


function validateLength(length){
    if(length===undefined || length===null){
        throw new Error('Lenght cannot be null or undefined');
    }
    if(+length!== Number(length)){
        throw new Error('Lenght must be a number');
    }
    if(length<0){
        throw new Error('Lenght must be more than ZERO');
    }
}
//validateLength('3');

var a = ['a','b','c','d','e','f','g']
    , chunk,
    page = 2;
var arr=[];
while (a.length>0) {

    chunk = a.splice(0,3);

    arr.push(chunk);

}
console.log(arr);
console.log(arr[page].length);