// function awesome() {     // the function floated to the top!
//   console.log("too good to be true");
// }
// awesome();

// var varFunction;
// varFunction = function() {
//   console.log("How will this get hoisted?")
// }
// varFunction();

//declarations get hoisted
// var hello;
// function example() {
//   var hello;
//   hello = "hi";
//   console.log(hello);
// }
// //assignments and invocation maintain order
// hello = "interesting";
// example();
// // console.log(hello);
//
//
// function Person(name){
//   this.name = name;
//   this.sayName = function(){
//     console.log(name);
//   }
// }
//
// var Jimmy = new Person("Jimmy");
// Jimmy.sayName();

// function NinjaConstructor(name, prevOccupation) {
//   this.name = name;
//   this.prevOccupation = prevOccupation;
//   this.introduce = function() {
//     console.log("Hi my name is " + this.name + ". I used to be a " + this.prevOccupation + " and now I'm a Ninja!");
//
//     if (!(this instanceof NinjaConstructor))
//     {
//       return new NinjaConstructor(name, prevOccupation);
//     }
//   }
// }

function User(name, ssn){
  var social = ssn;
  this.name = name;
  // Adds a so-called 'getter' function to allow reading private variables
  this.getSSN = function(){
    return social;
  }
}

var mike = new User('Mike', 274164398);
console.log(mike.getSSN()); // 274164398
