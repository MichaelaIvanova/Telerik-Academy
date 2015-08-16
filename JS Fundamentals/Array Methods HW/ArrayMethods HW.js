/**
 * Created by b50 on 6.6.2015 ã..
 */
//Problem 1. Make person
//Each person must have firstname, lastname,
// age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders
function buildPerson(fname, lname,age, gender){
    return {
        firstName: fname,
        lastName: lname,
        age: +age,
        gender: gender
    };
}


function createPeople() {
    var i,
        firstNames = ['Asen', 'Angel', 'Boris', 'Georgi', 'Marin', 'Ana', 'Eli', 'Elena', 'Gergana', 'Mariika'],
        lastNames = ['Ivanov', 'Dimitrov', 'Petrov', 'Georgiev', 'Nikolov', 'Borisova', 'Gigova', 'Atanasova', 'Ivanova', 'Georgieva'],
        arr = [];
    for (i = 0; i < 10; i += 1) {
        arr[i] = buildPerson(firstNames[i], lastNames[i], (Math.random() * 90) | 0, (i > 4));
    }
    return arr;
}
people = createPeople();
console.log(people);
//Problem 2. People of age
console.log('Problem 2. People of age');
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 //only people of age (with age 18 or greater)
var isPeopleOver18 = people.every(function(item){
    return(item.age>=18);

});
console.log('Are all people over 18?: '+isPeopleOver18);
//
console.log('');
console.log('Problem 3. Underage people');
//Write a function that prints all underaged persons of an array of person
console.log('Write a function that prints all underaged persons of an array of person');

var underaged = people.filter(function(item){
    return(item.age<=18);
}).forEach(function(item){
        console.log(item);

});
console.log(underaged);
console.log('');
//Problem 4. Average age of females
console.log('Problem 4. Average age of females');
//Write a function that calculates the average age
// of all females, extracted from an array of persons
// females are TRUE
function calcEvgAgeByGenderF(people){
    var result = 0;
    var counter = 0;
    people.filter(function(item){
        return item.gender;
    }).forEach(function(item){
        result+=item.age;
        counter+=1;
    });
    return result/counter;
}
var avgFemaleAge = calcEvgAgeByGenderF(people);
console.log('Female avg age is:'+avgFemaleAge);
console.log('');
//Problem 5. Youngest person
console.log('Problem 5. Youngest person');
if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i+=1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}

var youngest  = people.sort(function(x, y) {
    return x.age - y.age;
}).find(function(item){
    return !(item.gender);
});
console.log(youngest);
console.log('');
console.log('Problem 6. Group people');
//Write a function that groups an array of persons by first letter of
// first name and returns the groups as a JavaScript Object
var groups = people.reduce(function (gr, person) {
    var letter = person.firstName[0];

    if (gr[letter]) {
        gr[letter.toLowerCase()].push(person);
    } else {
        gr[letter.toLowerCase()] = [person];
    }

    return gr;
}, {});

console.log(groups);


