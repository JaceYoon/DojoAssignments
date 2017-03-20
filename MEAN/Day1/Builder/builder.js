function runningLogger(){
  console.log("I am running!");
}
runningLogger();

function multiplyByTen(i){
  console.log(i * 10);
}
multiplyByTen(5); //answer 1

function stringReturnOne(){
  var one = 'this is stringOne';
  console.log(one);
}

function stringReturnTwo(){
  var two = 'this is stringTwo';
  console.log(two);
}
stringReturnOne();
stringReturnTwo(); //answer 2

function caller(i){
  if (typeof(i) != 'number')
  {
    console.log('this is not a number!')
  }
  else
  {
    console.log(i)
  }
}
caller("haha"); //answer3

function myDoubleConsoleLog(a,b){
  console.log(a);
  console.log(b);
}
myDoubleConsoleLog("hello",3); //answer4

console.log("starting")
setTimeout(function caller2(){
  if (typeof(stringReturnOne)&&typeof(stringReturnTwo) === "function")
  {
    stringReturnOne();
    stringReturnTwo();
  }
  console.log("Ending?")
}
,2000);
