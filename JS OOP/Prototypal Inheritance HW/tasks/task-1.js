/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example
 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');
 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)
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
 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px"></div></body></html>
 */


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
            if (!/^[A-z0-9\-]+$/.test(text)){
                throw new Error('Name/Type must contain only latin letters or digits and dashes');
            }

        }
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
                    result+=sortedAtributes[i][0]+'="';
                    result+=sortedAtributes[i][1]+'" ';

                }

                result = result.trim();
                result+='>';

                if(this.children.length>0){
                    var child;
                    for(var i = 0; i<this.children.length; i += 1){
                        child = this.children[i];

                        if(typeof child === 'string') {
                            result += child;
                            //children string ovveride content
                            this.content='';
                        } else {

                            result += child.innerHTML;
                        }
                    }
                }
                else{
                    result+=this.content;
                }

                result+=closeTag;
                return result;

            }
        };


        return domElement;
    } ());
    return domElement;
}

module.exports = solve;
