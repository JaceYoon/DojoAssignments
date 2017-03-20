// function awesome() {     // the function floated to the top!
//   console.log("too good to be true");
// }
// awesome();

// var varFunction;
// varFunction = function() {
//   console.log("How will this get hoisted?")
// }
// varFunction();

// //declarations get hoisted
// var hello;
// function example() {
//   var hello;
//   hello = "hi";
//   console.log(hello);
// }
// //assignments and invocation maintain order
// hello = "interesting";
// example();
// console.log(hello);
function NewPerson(name){
  return {
    name:name,
    sayName:function(){
      console.log(name);
    }
  }
}

function Person(name){
  this.name = name;
  this.sayName = function(){
    console.log(name);
  }
}

var Jimmy = new Person("Jimmy");
Jimmy.sayName();
