function solve(){

   var module=(function(){

       //helper
       if (!Array.prototype.indexOf) {
           Array.prototype.indexOf = function(searchElement, fromIndex) {
               var k;
               if (this == null) {
                   throw new TypeError('"this" is null or not defined');
               }
               var O = Object(this);
               var len = O.length >>> 0;

               // 4. If len is 0, return -1.
               if (len === 0) {
                   return -1;
               }

               var n = +fromIndex || 0;

               if (Math.abs(n) === Infinity) {
                   n = 0;
               }

               // 6. If n >= len, return -1.
               if (n >= len) {
                   return -1;
               }

               k = Math.max(n >= 0 ? n : len - Math.abs(n), 0);

               // 9. Repeat, while k < len
               while (k < len) {

                   if (k in O && O[k] === searchElement) {
                       return k;
                   }
                   k++;
               }
               return -1;
           };
       }

       var STRING_MIN_LENGTH = 3;
       var STRING_MAX_LENGTH = 25;


       // validators
       //NAME, TITLE, AUTHOR VALIDATOR
       function validateString(text, min, max){
           if(text=== null){
               throw new Error('Invalid string, null')
           }
           if (typeof text !== 'string'|| text === undefined) {
               throw new Error('Must be a string not undefined or other type var');
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

       // validator For LENGHT, must be a number greater than 0

            function validateNumber(n){
                if(n===undefined || n===null){
                    throw new Error('Lenght cannot be null or undefined');
                }
                // the sign plus is IMportant
                if(+n!== Number(n)){
                    throw new Error('Lenght must be a number');
                }
                if(n<0){
                    throw new Error('Lenght must be more than ZERO');
                }
            }

       // validate IMDB number betwen 1 and 5
       function validateimdbRating(imdb){
           if(length===undefined || length===null){
               throw new Error('Lenght cannot be null or undefined');
           }
           // the sign plus is IMportant
           if(+length!== Number(length)){
               throw new Error('Lenght must be a number');
           }
           if(imdb<1){
               throw new Error('Imdb must be GREATER than 1');

           }
           if(imdb>5){
               throw new Error('IMdb must be LESS than 5');
           }
       }

       // check if playeble with ID alredy exists
       // find playable by ID
       function indexOfElementWithIdInCollection(collection, id) {
           var i, len;
           for (i = 0, len = collection.length; i < len; i++) {
               if (collection[i].id == id) {
                   return i;
               }
           }

           return -1;
       }
       // remove Item
       function removeItem(array, item){
           for(var arrItem in array){
               if(array[arrItem]==item){
                   array.splice(arrItem,1);
                   break;
               }
           }
       }
       //helper sorter
       function sortOn (arr, prop) {
           arr.sort (
               function (a, b) {
                   if (a[prop] < b[prop]){
                       return -1;
                   } else if (a[prop] > b[prop]){
                       return 1;
                   } else {
                       return 0;
                   }
               }
           );
       }


       /*var player = (function(){
           var player = Object.create({});
           var playerID = 0;
           Object.defineProperty(player,'init',{
               value: function(name){
                   this.name = name;
                   //Each player instance has an unique id
                   this._id = ++playerID;
                   this._playLISTS = [];
                   return this;
               }
           });

           Object.defineProperty(player,'name',{
               get: function(){
                   return this._name;
               },
               set: function(value){
                   validateString(value,STRING_MIN_LENGTH,STRING_MAX_LENGTH);
                   this._name = value;
               }
           });

           Object.defineProperty(player, 'id', {
               get: function () {
                   return this._id;
               }
           });

           Object.defineProperty(player, 'addPlaylist',{
               value: function(playlistToAdd){
                 //check if it is a playlist
                  var temporaryPlaylist = playlist.init('tester');
                   if(Object.getPrototypeOf(playlistToAdd)!==Object.getPrototypeOf(temporaryPlaylist)){
                      throw new Error('Playlist is not an instance of playlist');
                   }
                   this._playLISTS.push(playlistToAdd);
                   return this;
               }
           });
*/
           //getPlaylistById(id)
         /*  Finds and returns a playlist from the playlists in this player instance
           Returns null, if a playlist with the provided id is not contained in the player*/

          /* Object.defineProperty(player,'getPlaylistById',{
               value:function(id){
                   var currPlaylist = findPlayableByID(id, this._playLISTS);
                   return currPlaylist;
               }
           });*/

           /*removePlaylist(id)
           Removes a playlists from this player instance, and the playlist must have an id equal to the provided id
           Enables chaining
           Throws an error, if a playlist with the provided id is not contained in the player*/

           /*Object.defineProperty(player,'removePlaylist', {
               value:function(item) {

                   //check if item is ID or PlayList
                   var temporaryPlaylist = playlist.init('tester');
                   if(Object.getPrototypeOf(temporaryPlaylist)===Object.getPrototypeOf(item))
                    {
                       var index = this._playLISTS.indexOf(item);
                       this._playLISTS.splice(index, 1);
                   }

                   //Removes a playlist from this player, and the playlist must have an id equal to the provided id
                   //if item is ID - number

                   if (+item === Number(item)) {

                       var currentPlayList = findPlayableByID(item, this._playLISTS);
                       if (currentPlayList === null) {
                           //Throws an error, if a playable with the provided id is not contained in the playlist
                           throw new Error('This playList does not exist')
                       }
                       else {
                           removeItem(this._playLISTS, currentPlayList);
                       }

                   }
                   //Enables chaining
                   return this;
               }
           });


           return player;
       }());*/

       var validator = {
           validateIfUndefined: function (val, name) {
               name = name || 'Value';
               if (val === undefined) {
                   throw new Error(name + ' cannot be undefined');
               }
           },
           validateIfObject: function(val, name) {
               name = name || 'Value';
               if (typeof val !== 'object') {
                   throw new Error(name + ' must be an object');
               }
           },
           validateIfNumber: function (val, name) {
               name = name || 'Value';
               if (typeof val !== 'number') {
                   throw new Error(name + ' must be a number');
               }
           },
           validateString: function (val, name) {
               name = name || 'Value';
               this.validateIfUndefined(val, name);

               if (typeof val !== 'string') {
                   throw new Error(name + ' must be a string');
               }

               if (val.length < CONSTANTS.TEXT_MIN_LENGTH
                   || CONSTANTS.TEXT_MAX_LENGTH < val.length) {
                   throw new Error(name + ' must be between ' + CONSTANTS.TEXT_MIN_LENGTH +
                       ' and ' + CONSTANTS.TEXT_MAX_LENGTH + ' symbols');
               }
           },
           validatePositiveNumber: function (val, name) {
               name = name || 'Value';
               this.validateIfUndefined(val, name);
               this.validateIfNumber(val, name);

               if (val <= 0) {
                   throw new Error(name + ' must be positive number');
               }
           },
           validateImdbRating: function (val) {
               this.validateIfUndefined(val, 'IMDB Rating');
               this.validateIfNumber(val, 'IMDB Rating');

               if (val < CONSTANTS.IMDB_MIN_RATING || CONSTANTS.IMDB_MAX_RATING < val) {
                   throw new Error('IMDB Rating must be between '
                       + CONSTANTS.IMDB_MIN_RATING
                       + ' and ' + CONSTANTS.IMDB_MAX_RATING);
               }
           },
           validateId: function (id) {
               this.validateIfUndefined(id, 'Object id');
               if (typeof id !== 'number') {
                   id = id.id;
               }

               this.validateIfUndefined(id, 'Object must have id');
               return id;
           },
           validatePageAndSize: function (page, size, maxElements) {
               this.validateIfUndefined(page);
               this.validateIfUndefined(size);
               this.validateIfNumber(page);
               this.validateIfNumber(size);

               if (page < 0) {
                   throw new Error('Page must be greather than or equal to 0');
               }

               this.validatePositiveNumber(size, 'Size');

               if (page * size > maxElements) {
                   throw new Error('Page * size will not return any elements from collection');
               }
           }
       };




       var playlist = (function(){
           var playlist = Object.create({});

           //produce unique ID
           function makeCounter() {
               var i = 1;// id starts form 1;
               return function() {
                   return i++;
               }
           }

           var id = makeCounter();

           Object.defineProperty(playlist,'init',{
               value: function(name){
                   this.name=name;
                   this._id=id();
                   this._playables = [];
                   return this;
               }
           });

           Object.defineProperty(playlist,'name',{
               get: function(){
                   return this._name;
               },
               set:function(value){
                   validateString(value);
                   this._name=value;
               }
           });

           Object.defineProperty(playlist, 'id', {
               get: function () {
                   return this._id;
               }
           });

           Object.defineProperty(playlist,'addPlayable',{
               value: function(playableToAdd){
                   //check if valid playable
                   validator.validateIfUndefined(playableToAdd, 'Playlist add playable parameter');
                   validator.validateIfObject(playableToAdd, 'Playlist add playable parameter');
                   validator.validateIfUndefined(playableToAdd.id, 'Playlist add playable parameter must have id')

                   this._playables.push(playableToAdd);
                   //Enables chaining
                   return this;
               }
           });

           Object.defineProperty(playlist,'getPlayableById',{
               value: function(id){

                   var i, len;
                   validator.validateIfUndefined(id, 'Playlist get playable parameter id');
                   validator.validateIfNumber(id, 'Playlist get playable paratemeter id');

                   var foundIndex = indexOfElementWithIdInCollection(this._playables, id);
                   if (foundIndex < 0) {
                       return null;
                   }

                   return this._playables[foundIndex];

               }
           });

           /*
           Object.defineProperty(playlist,'removePlayable',{
               value:function(item) {

                   //check if item is ID or Playable
                   if (Object.getPrototypeOf(item) === playable) {
                       var index = this._playables.indexOf(playable);
                       this._playables.splice(index, 1);
                   }

                   //Removes a playable from this playlist, and the playable must have an id equal to the provided id
                   //if item is ID - number

                   if (+item === Number(item)) {

                       var currentPlayable = findPlayableByID(item, this._playables);
                       if (currentPlayable === null) {
                           //Throws an error, if a playable with the provided id is not contained in the playlist
                           throw new Error('This playable does not exist')
                       }
                       else {
                           removeItem(this._playables, currentPlayable);
                       }

                   }
                   //Enables chaining
                   return this;
               }
           });

           Object.defineProperty(playlist,'listPlaylables',{
               value: function(page, size){
                   // validate page and size
                  /!* Throw an error if:
                   page*size > COUNT_OF_PLAYABLE_IN_PLAYLIST
                   page < 0
                   size <= 0*!/
                   // chech if thery are numbers use old functions;
                   validateimdbRating(page);
                   validateimdbRating(size);

                   if((page*size)>this._playables.length){
                       throw new Error('Invalid page and size');
                   }
                   if(page<0 || size<=0){
                       throw new Error('Page and size must be more than zero');
                   }


                   //sorting the playables by title, then by id
                   this._playables=sortOn(this._playables,'title');
                   this._playables=sortOn(this._playables,'id');

                   //split the big array into pages by fixed size
                   var arrayOfSplittedByPage = [];

                   while (this._playables.length > 0) {

                       var chunk = this._playables.splice(0,size);
                       arrayOfSplittedByPage.push(chunk);

                   }
                   return arrayOfSplittedByPage[page];

               }

           });*/




           return playlist;
       }());

       var playable = (function(){

           var playable = Object.create({});

           //produce unique ID
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

         //play()
           //returns a string in the format: [id]. [title] - [author]

           Object.defineProperty(playable,'play',{
               value: function(){
                   var result = this.id+'. '+this.title+' - '+this.author;
                   return result;
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
                    validateNumber(value);
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

       var video =(function(parent){
           var video = Object.create(parent);

           Object.defineProperty(video,'init',{
               value: function(title, author, imdbRating){
                   parent.init.call(this, title,author);
                   this.imdbRating = imdbRating;
                   return this;
               }
           });

           Object.defineProperty(video, 'imdbRating',{
               get: function(){
                   return this._imdbRating;
               },
               set: function(value){
                 validateimdbRating(value);
                   this._imdbRating = value;
               }
           });

          //reuses the play() from Playable and adds: - [imdbRating] at the end
           Object.defineProperty(video, 'play',{
               value: function(){
                  var videoToString = parent.play.call(this) + ' - '+this.imdbRating;
                   return videoToString;
               }
           });

           return video;
       }(playable));


       return {
           getPlayer: function (name){
               // returns a new player instance with the provided name
              // return Object.create(player).init(name);
           },
           getPlaylist: function(name){
               //returns a new playlist instance with the provided name
               return Object.create(playlist).init(name);
           },
           getAudio: function(title, author, length){
               //returns a new audio instance with the provided title, author and length
               return Object.create(audio).init(title, author, length);
           },
           getVideo: function(title, author, imdbRating){
               //returns a new video instance with the provided title, author and imdbRating
               return Object.create(video).init(title, author, imdbRating);
           }
       };

   }());

    return module;
}

