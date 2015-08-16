/* Task Description */
/*
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * ///
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {

    function validateTitle(text) {
        if (typeof text !== 'string' || text === undefined) {
            throw new Error('Must be a string');
        }
        if (text === '') {
            throw new Error('Not empty string');
        }
        if (text.length < 1) {
            throw new Error('Must be at least one symbol')
        }
        if (text[0] === ' ' || text[text.length - 1] === ' ') {
            throw new Error('Titles do not start or end with spaces');
        }
        if (/(  )+/.test(text)) {
            throw new Error('Titles do not have consecutive spaces');
        }
    }

    function validatePresentations(arr) {
        if (arr.length < 1) {
            throw new Error('Must have at least one presentation')
        }
        for (var i = 0; i < arr.length; i += 1) {
            var currentPresenation = arr[i];
            validateTitle(currentPresenation);
        }
    }

    // validate student Name // the name is Fistname Lastname
    function validateStudentName(name){
        if (typeof name !== 'string'|| name === undefined) {
            throw new Error('Must be a string');
        }
        if (name === '') {
            throw new Error('Not empty string');
        }

        var numberOfSpaces = name.match(/ /g).length;

        if(numberOfSpaces>1){
            throw new Error('No more than 1 space');
        }

        var splitted = name.split(' ');
        // name can be also only one letter!
        if(splitted[0].length===1){
            if(!/^[A-Z]$/.test(splitted[0])){
                throw new Error('Name one letter Fname must be in uppercase')
            }
        }
        if(splitted[1].length===1){
            if(!/^[A-Z]$/.test(splitted[1])){
                throw new Error('Name one letter Last must be in uppercase')
            }
        }
        if(splitted[0].length>1) {
            if (!/^[A-Z]+[a-z]+/.test(splitted[0])) {
                throw new Error('Invalid First Name - must be Firstname');
            }
        }
        if(splitted[1].length>1) {
            if (!/^[A-Z]+[a-z]+/.test(splitted[1])) {
                throw new Error('Invalid Last Name - must be Firstname');
            }
        }
    }

    // check if student with this id exist
    function validateStudentId(id,arrOfStudents){
        var exists = false;
        for(var i = 0; i<arrOfStudents.length; i++){
            var currentStudent = arrOfStudents[i];
            if(currentStudent.id===id){
               exists=true;
            }
        }
        // if exists ===false
        if(!exists){
            throw new Error('Student with this id does not exists!');
        }
    }

    //check if certain presentation exist, because homework homeworkID 1 is for the first presentation
// homeworkID 2 is for the second one
    function validateHomeworkId(idH, presentations){
        var exists = false;
        for(var i = 0; i<presentations.length; i+=1){
            //the index of the presentation is i+1, because ist starts form zero, homeworkID 2 is for the second one
            if(idH===i+1){
                exists=true;
                break;
            }
        }
        if(!exists){
            throw new Error('Homework with this ID does not exist');
        }
    }

   // validator for duplicating id in array, same student twice
     function validateForDuplicatedID(resultsArr){

         var isDuplicated = false;

         for (var i = 0; i<resultsArr.length; i+=1){

             var curretIDtoCheck = resultsArr[i].StudentID;

             for(var k = i+1; k<resultsArr.length; k+=1){
                 var nextIDtoCheck = resultsArr[k].StudentID;
                 if(curretIDtoCheck===nextIDtoCheck){
                     isDuplicated=true;
                 }
             }
         }
         if(isDuplicated){
             throw  new Error('Duplicated property value;')
         }

     }

    // Helper function for sort from best to worse!!!!!!!! (if number)
    function sortOn(arr, prop) {
        arr.sort (
            function (a, b) {
                if (a[prop] < b[prop]){
                    return 1;
                } else if (a[prop] > b[prop]){
                    return -1;
                } else {
                    return 0;
                }
            }
        );
    }

    //Helper to find student by id
    function findById(arrayStudents, id) {
        for (var i = 0; i < arrayStudents.length; i++) {
            if (arrayStudents[i].id === id) {
                return arrayStudents[i];
            }
        }
    }

    var Course = {
        init: function(title, presentations) {
            validateTitle(title);
            validatePresentations(presentations);

            this.title = title;
            this.presentations = presentations;
            this.students = [];
            this.results=[];

            return this;
        },
        addStudent: function(name) {
            //the name is Fistname Lastname
            validateStudentName(name);

            var splittedNames = name.split(' ');

            //initially this.stuent lenght is 0, so when add first student his id must be 1;
            var id = this.students.length+1;

            var student={};
            student.firstname=splittedNames[0];
            student.lastname=splittedNames[1];
            student.id=id;
            student.homeworks = [];// not sure if it's printed???
            /*Object.defineProperty(student,'id',{
                value:id
                // enumerable: false
            });*/

            this.students.push(student);

            return id;
        },
        getAllStudents: function() {
            //create method getAllStudents that returns an array of students in the format:
            // {firstname: 'string', lastname: 'string', id: StudentID}
            return this.students.slice();

        },
        submitHomework: function(studentID, homeworkID) {
          /*  Create method submitHomework
            * Accepts studentID and homeworkID
            * homeworkID 1 is for the first presentation
            * homeworkID 2 is for the second one
            * ...
            * Throws if any of the IDs are invalid*/

             validateStudentId(studentID, this.students);
             validateHomeworkId(homeworkID, this.presentations);

            // find student by id and assign it array of homeworks;
            var currStudent = findById(this.students, studentID);
            currStudent.homeworks.push(homeworkID);

            return this;
        },
        pushExamResults: function(results) {
            /*Accepts an array of items in the format {StudentID: ..., Score: ...}
            * StudentIDs which are not listed get 0 points
            * Throw if there is an invalid StudentID
            * Throw if same StudentID is given more than once ( he tried to cheat (: )
            * Throw if Score is not a number*/

            //check if Results is array
            if(!(results instanceof Array)){
                throw  new Error('result is not array');
            }

            //check if score is a Number
            for(var j=0; j<results.length; j+=1){
                var currentScore = results[j].score;
                if(currentScore != Number(currentScore)){
                    throw new Error('Score must be a number');
                }
            }

            // validate student ID, check if student with this ID exists
            for(var i=0; i<results.length; i+=1){

                var currentID = results[i].StudentID;
                validateStudentId(currentID,this.students);
            }

            //check if Student ID is not unique, check for duplicates
           validateForDuplicatedID(results);

            //initalize it in order to use it in the next method
            this.results=results;

            return this;

        },
        getTopStudents: function() {
       /*     * Create method getTopStudents which returns an array of the top 10 performing students
            * Array must be sorted from best to worst
            * If there are less than 10, return them all
            * The final score that is used to calculate the top performing students is done as follows:
            * 75% of the exam result
            * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
            *!/*/
            var topStudents = [];

            // calculate final score  75% exam result an give points for HW
            for (var i = 0; i<this.results.length; i++){

                this.results[i].score*=0.75;
                var currStudent = findById(this.students, this.results[i].id);

                // of the number of homeworks is equal to the number of presentation
                // ( for each presentation there is a homework)
                if(currStudent.homeworks.length===this.presentations.length){
                    // give him full points - 25
                    this.results[i].score+=25;
                }
            }

            // sort the array from best to worse by score, so this.result is already sorted

            this.results=sortOn(this.results, 'score');

            //If there are less than 10, return them all
            if(this.results.length<=10){
                topStudents=this.results;
            }
            else {
               topStudents=this.results.slice(0,10);
            }

            return topStudents;

        }
    };

    return Course;
}

module.exports = solve;

