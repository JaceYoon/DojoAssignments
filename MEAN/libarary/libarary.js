var _ = {
   map: function(arr, callback) {
     newArr=[]
     for(var i = 0; i<arr.length; i++){
       newArr.push(callback(arr[i]))
     }
     return newArr
     //code here;
   },
   reduce: function() {
     // code here;
   },
   find: function(arr, callback) {
    for(i=0; i<arr.length; i++){
      if(callback(arr[i])){
        return arr[i];
      }
    }
   },
   filter: function(arr, callback) {
    newArr=[]
    for(i=0; i<arr.length; i++){
      if(callback(arr[i])){
        newArr.push(arr[i])
      }
    }
    return newArr;
   },
   reject: function(arr, callback) {
     newArr = []
     for(i=0; i<arr.length; i++){
      if(!callback(arr[i])){
        newArr.push(arr[i])
      }
     }
     return newArr;
   }
 }
// you just created a library with 5 methods!
// var evens = _.filter([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; });
console.log(_.filter([1, 2, 3, 4, 5, 6], function(num){ return num % 2 == 0; })); // if things are working right, this will return [2,4,6].
//using map function

_.map([1, 2, 3], function(num){ return num * 4; });
console.log(_.map([1, 2, 3], function(num){ return num * 4; }));

var odd =[2, 8, 10, 4, 11, 6]
 console.log(_.find(odd, function(num){ return num % 2 == 1; }));

var odd2 = [8, 2, 200, 4, 5, 6]
console.log(_.reject(odd2, function(num){ return num % 2 == 0; }));
