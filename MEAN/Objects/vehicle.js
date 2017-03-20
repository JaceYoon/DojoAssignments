// nop = NumberOfPassengers
function Vehicles(name,wheels,nop){
  var vehicle = {};

  vehicle.name = name;
  vehicle.wheels = wheels;
  vehicle.nop = nop;
  vehicle.makeNoise = function(){
    console.log("PangPangPPangg");
  }
  return vehicle;
}

var bike = Vehicles("Bike",2,1)
bike.makeNoise = function(){
  console.log("ring ring!");
}
bike.makeNoise();

var sedan = Vehicles("Sedan",4,3)
sedan.makeNoise = function(){
  console.log("Honk Honk!");
}
var bus = Vehicles("Bus",4,15)
bus.pickup = function(nop){
  bus.nop+= nop;
}

console.log(bus.nop);
bus.pickup(4);
console.log(bus.nop);
console.log(sedan)
