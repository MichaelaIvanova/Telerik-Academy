function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function checkLenght(name) {
            if (name.length < 2 || name.length > 100) {
                throw RangeError('The name is NOT b-n 2-100 symbols.');
            }

        }

        function checkISBN(isbn) {
            var lenght = (isbn + "").length,
                isNotNum = !!(isNaN(isbn));
            if (lenght < 10 || lenght > 13 || isNotNum) {
                throw ReferenceError("The ISBN must be b-n 10-13 digits number.");
            }

        }

        function checkRepeat(checking, strElement) {
            var idx;
            for (idx in books) {
                if (books[idx][strElement] === checking) {
                    throw Error("The " + strElement + " is repeating.");
                }

            }

        }

        function categoryAdd(category) {
            if (!(categories.indexOf(category) > -1)) {
                category.ID = categories.length + 1;
                categories.push(category);
            }

        }

        function checkDefined(sthng) {
            return sthng !== undefined;
        }

        function listBooks(listBook) {
            if (books.length === 0) {
                return [];
            }

            if (checkDefined(listBook)) {
                if (checkDefined(listBook.category)) {
                    return books.filter(function (book) {
                        if (book.category === listBook.category) {
                            return book;
                        }

                    });
                }

                if (checkDefined(listBook.author)) {
                    return books.filter(function (book) {
                        if (book.author === listBook.author) {
                            return book;
                        }
                    });
                }
            }
            return books;
        }

        function addBook(book) {
            checkLenght(book.title);
            checkLenght(book.category);
            checkISBN(book.isbn);
            book.ID = books.length + 1;
            checkRepeat(book.title, 'title');
            checkRepeat(book.isbn, 'isbn');
            books.push(book);
            categoryAdd(book.category);
            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

module.exports = solve;
