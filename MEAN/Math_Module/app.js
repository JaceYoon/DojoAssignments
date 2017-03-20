var mylib = require("./mathlib.js");
var math = new mylib();

num1 = 70;
num2 = 75;

console.log("Sum " + num1 + " + " + num2 + " = ", math.add(num1, num2))
console.log("Multiply " + num1 + " * " + num2 + " = ", math.multiply(num1, num2))
console.log("Square " + num1 + " = ", math.square(num1))
console.log("Random number between " + num1 + " , " + num2 + "= ", math.random(num1, num2))
