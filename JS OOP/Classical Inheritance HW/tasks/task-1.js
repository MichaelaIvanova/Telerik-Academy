/* Task Description */
/*
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {
    var Person = (function () {
        // validator Name;
        function validateName(name) {
            if(!(/^[A-Za-z]{3,20}$/.test(name))) {
                throw new Error('First and last name must consist only of latin letters and be between 3 and 20 characters long.');
            }

        }

        // validator age;
        function isAgeValid(age){
            if(age ===''){
                throw new Error();
            }
            /// MNogo e vajno taka/......................
            if(age != Number(age)){
                throw new Error();
            }
            if(age<0||age>150){
                throw new Error();
            }
        }
        function Person(firstname, lastname, age) {
            var _firstname,_lastname,_age;
            this.firstname=firstname;
            this.lastname=lastname;
            this.age = age;
        }


        Person.prototype.introduce = function() {
            return 'Hello! My name is ' + this.firstname + ' ' + this.lastname +
                ' and I am ' + this.age + '-years-old';
        };

        Object.defineProperty(Person.prototype,'firstname',{
            get: function(){
                return this._firstname;
            },
            set: function(value){
                validateName(value);
                this._firstname = value;
            }

        });

        Object.defineProperty(Person.prototype,'lastname',{
            get: function(){
                return this._lastname;
            },
            set: function(value){
                validateName(value);
                this._lastname = value;
            }
        });

        Object.defineProperty(Person.prototype,'age',{
            get: function(){
                return this._age;
            },
            set: function(value){
                isAgeValid(value);
                this._age = value;
            }
        });
        Object.defineProperty(Person.prototype,'fullname',{
            //the getter returns a string in the format 'FIRST_NAME LAST_NAME'
            get: function(){
                return this.firstname+' '+this.lastname;
            },
            //the setter receives a string is the format 'FIRST_NAME LAST_NAME'
            set: function(value){
                var fullName = value.split(' ');
                this.firstname=fullName[0];
                this.lastname=fullName[1];
            }
        });
        return Person;
    } ());
    return Person;
}
module.exports = solve;