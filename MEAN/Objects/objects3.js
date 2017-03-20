function VehicleConstructor(name, wheels, passenger, speed){
  if (!(this instanceof VehicleConstructor)){
    return new VehicleConstructor(name,wheels,passenger,speed);
  }
}
var chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
this.distance_traveled = 0;
this.speed = speed;
this.name = name || "unicycle"
this.wheels = wheels || 1;
this.passenger = passenger || 0;
this.vin = createVin();

function createVin(){
  var vin = '';
  for (var i=0; i<17, i+=1){
    vin += chars(Math.floor(Math.random()*35));
  }
}

VehicleConstructor.prototype.makeNoise = function(noise){
  var noise = noise || "Honk Honk"
  console.log(noise);
  return this;
}

VehicleConstructor.prototype.move = function(){
  this.makeNoise();
  this.updateDistanceTraveled();
  return this;
}

VehicleConstructor.prototype.checkMiles = function(){
  console.log(this.distance_traveled);
  return this;
}

VehicleConstructor.protoype.updateDistanceTraveled = function(){
  this.distance_traveled += this.speed;
  console.log(this.distance_traveled);
}

var car = new VehicleConstructor('car',4,4,85);
