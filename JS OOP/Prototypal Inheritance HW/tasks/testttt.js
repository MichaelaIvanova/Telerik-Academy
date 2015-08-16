function solve() {
    var domElement = (function () {

        //a valid type is any non-empty string that contains only Latin letters and digits
        function validateType(text){
            if(text === ''||text === undefined){
                throw new Error('Name/Type cannot be empty');
            }
            if(!(/^\w+$/.test(text))){
                throw new Error('Name/Type must contain only latin letters or digits');
            }
            if(typeof text !== 'string'){
                throw new Error('Input must be only string');
            }

        }

        //* a valid attribute has a non-empty string for a name
        // that contains only Latin letters and digits or dashes (-)
        function validateAttribute(text){
            if(text === ''||text === undefined){
                throw new Error('Name/Type cannot be empty');
            }
            if(typeof text !== 'string'){
                throw new Error('Input must be only string');
            }
            if (!/^[A-Z0-9\-]+$/i.test(text)){
                throw new Error('Name/Type must contain only latin letters or digits and dashes');
            }

        }
        // SORTER



        var domElement = {
            init: function(type) {
                validateType(type);
                this.type = type;
                this.parent;
                this.content='';
                this.children = [];
                this.attributes = [];
                return this;
            },
            appendChild: function(child){
                this.children.push(child);
                child.parent = this;
                return this;
            },
            addAttribute: function(name, value) {
                validateAttribute(name);

                this.attributes[name] = value;
                return this;
            },
            removeAttribute:function(attribute){
                if(!this.attributes[attribute]){
                    throw new Error('This attribute does not exist.');
                }

                delete this.attributes[attribute];

                return this;
            },
            get innerHTML(){

                var openTag = '<'+this.type;
                var closeTag = '</'+this.type+'>';
                var result = '';
                result+=openTag+' ';

                var sortedAtributes = [];

                for (var k in this.attributes) {
                    sortedAtributes.push([k, this.attributes[k]]);
                }
                sortedAtributes.sort();
                // [ [ 'bgcolor', '#012345' ], [ 'id', 'cuki' ] ] return array of arrays
                //console.log(sortedAtributes);

                for (var i = 0; i<sortedAtributes.length; i++){
                   result+=sortedAtributes[i] [0]+'="';
                    result+=sortedAtributes[i][1]+'" ';

                }

                result = result.trim();
                result+='>';
                if(this.children.length>0){
                    var child;
                    for(var ind = 0, len = this.children.length; ind < len; ind += 1){
                        child = this.children[ind];

                        if(typeof child === 'string') {
                            result += child;
                        } else {
                            result += child.innerHTML;
                        }
                    }
                }
                result+=this.content;
                result+=closeTag;

                return result;

            }

        };


        return domElement;
    } ());
    return domElement;
}

var domElement = solve();

var m = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');

var h= Object.create(domElement)
    .init('head')
    .appendChild(meta);

var div = Object.create(domElement)
    .init('div')
    .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
    .init('body')
    .appendChild(div)
    .addAttribute('id', 'cuki')
    .addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
    .init('html')
    .appendChild(head)
    .appendChild(body);
// Outputs:
// <html><head><meta charset="utf-8"></meta></head><body
// bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
//console.log(root);
console.log(root.innerHTML);
console.log(body.children);




