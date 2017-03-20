function SumBetween(a,b){
  var sum = 0
  if (a < b ){
    while(a < b)
    {
      sum += a;
      a++;
    }
  }
  else {
    while(b < a)
    {
      sum += b;
      b++;
    }
  }
  console.log(sum)
}
SumBetween(10,3); //answer1

var Arr = []
var Max = 0
var Sum = 0
function Maxis(Arr){
  for(i=0; i<Arr.length; i++){
    if(Arr[i] > Max){
      Max = Arr[i];
    }
    else{
      Max = Max
    }
  }
  console.log(Max)
}
var NewArr = [3,7,-1,100]
Maxis(NewArr); // answer2

function Avgis(Arr){
  for(i=0; i<Arr.length; i++){
    Sum += Arr[i]
  }
  console.log(Sum/Arr.length)
}
Avgis(NewArr); // answer3


var Person = {
  name: 'Jace Yoon',
  distance_traveled : 0,
  say_name : function(){
    console.log(Person.name);
  }
  ,
  say_something : function(){
    console.log(Person.name + " is Awesome!!");
  },
  walk : function(){
    console.log(Person.name + " is walking");
    Person.distance_traveled += 3;
    return Person;
    }
  ,
  run : function(){
    console.log(Person.name + " is running");
    Person.distance_traveled += 10
    return Person;
  }
  ,
  crawl : function(){
    console.log(Person.name + " is crawling");
    Person.distance_traveled += 1
    return Person;
  }
}

Person.walk().run() // answer4
console.log(Person.distance_traveled)
