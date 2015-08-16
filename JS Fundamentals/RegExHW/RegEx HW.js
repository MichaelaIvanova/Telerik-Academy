/**
 * Created by b50 on 8.6.2015 ã..
 */
//Problem 1. Format with placeholders
//Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        var pattern,
            result = this,
            prop;
        for (prop in options) {
            pattern = new RegExp('\#\{' + prop + '\}');
            result = result.replace(pattern, options[prop]);
        }
        return result;
    }

}
var options01 = { name: 'John' };
var options02 = { name: 'John', age: 13 };
var string01 = 'Hello, there! Are you #{name}?';
var string02 = 'My name is #{name} and I am #{age}-years-old';

    console.log(string01.format(options01));
    console.log(string02.format(options02));
// ### Problem 2. HTML binding
// *	Write a function that puts the value of an object into the content/attributes of HTML tags.
// 	*	Add the function to the **String.prototype**

if (!String.hasOwnProperty('bind')) {
    String.prototype.bind = function(params) {
        var result;

        // process content bind
        result = this.replace(/ data-bind-content="(.*?)".*?>/g,
            function(match, bindName) {
                return match + params[bindName];
            });

        // process non-content binds
        result = result.replace(/ data-bind-(.*?)="(.*?)"/g,
            function(match, bindType, bindName) {
                if (bindType === 'content') {
                    return match;
                } else {
                    return match + ' ' + bindType + '="' + params[bindName] + '"';
                }
            });

        return result;
    }
}