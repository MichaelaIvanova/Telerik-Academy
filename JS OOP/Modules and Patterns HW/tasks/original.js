/**
 * Created by b50 on 28.6.2015 ã..
 */
function solve() {

    // validate Titles, a string,
    /** Throws if there is an invalid title
     * Titles do not start or end with spaces
     * Titles do not have consecutive spaces
     * Titles have at least one character*/
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

        // validate presentations, Throws if there are no presentations, presenntation also has a s title
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
        function validateStudentName(name) {
            if (typeof name !== 'string' || name === undefined) {
                throw new Error('Must be a string');
            }
            if (name === '') {
                throw new Error('Not empty string');
            }
            var numberOfSpaces = name.match(/ /g).length;
            if (numberOfSpaces > 1) {
                throw new Error('No more than 1 space');
            }
            var splitted = name.split(' ');
            if (!/^[A-Z]+[a-z]+/.test(splitted[0])) {
                throw new Error('Invalid First Name - must be Firstname');
            }
            if (!/^[A-Z]+[a-z]+/.test(splitted[1])) {
                throw new Error('Invalid Last Name - must be Firstname');
            }
        }


        var Course = {
            init: function (title, presentations) {
                validateTitle(title);
                validatePresentations(presentations);

                this.title = title;
                this.presentations = presentations;
                this.students = [];

                return this;
            },
            addStudent: function (name) {
                // the name is Fistname Lastname
                //validateStudentName(name);
                this.students.push(name);
                return this;
            },
            getAllStudents: function () {
            },
            submitHomework: function (studentID, homeworkID) {
            },
            pushExamResults: function (results) {
            },
            getTopStudents: function () {
            }
        };

        return Course;


    }


    module.exports = solve;